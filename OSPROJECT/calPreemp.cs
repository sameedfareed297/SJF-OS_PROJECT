using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSPROJECT
{
    public partial class calPreemp : Form
    {
        private List<Process> processes = new List<Process>();


        public class Process
        {
            public int ProcessID { get; set; }
            public int ArrivalTime { get; set; }
            public int BurstTime { get; set; }
            public int CompletionTime { get; set; }
            public int TurnAroundTime { get; set; }
            public int WaitingTime { get; set; }
        }

        public calPreemp()
        {
            InitializeComponent();
        }

        private void btn_addprocess_Click(object sender, EventArgs e)
        {
            int processId;
            int arrivalTime;
            int burstTime;

            // Validate Burst Time
            if (!int.TryParse(BT_Pre.Text, out burstTime) || burstTime == 0)
            {
                MessageBox.Show("Invalid Burst Time. Burst Time cannot be null or zero.", "Error");
                return;
            }

            // Validate Process ID
            if (!int.TryParse(Pid_pre.Text, out processId))
            {
                MessageBox.Show("Invalid Process ID. Please enter a valid integer.", "Error");
                return;
            }

            // Check if the processId already exists in the dataGridView_preemp
            if (dataGridView_preemp.Rows.Cast<DataGridViewRow>().Any(row => row.Cells[0].Value.ToString() == processId.ToString()))
            {
                MessageBox.Show("Process ID already exists. Please enter a unique ID.", "Error");
                return;
            }

            Process process = new Process
            {
                ProcessID = processId,
                ArrivalTime = int.TryParse(AT_pre.Text, out arrivalTime) ? arrivalTime : 0,
                BurstTime = burstTime
            };
            processes.Add(process);

            int n = dataGridView_preemp.Rows.Add();
            dataGridView_preemp.Rows[n].Cells[0].Value = Pid_pre.Text;
            dataGridView_preemp.Rows[n].Cells[1].Value = AT_pre.Text;
            dataGridView_preemp.Rows[n].Cells[2].Value = BT_Pre.Text;
        }

        private void btnclearprocess_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you really want to Remove all Process?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                // Clear all processes from DataGridView and reset input fields
                Pid_pre.Value = 0;
                BT_Pre.Value = 0;
                AT_pre.Value = 0;
                dataGridView_preemp.Rows.Clear();
                dataGridView_preemp.Refresh();
                textBoxavgtat.Text = "";
                textBoxavgwt.Text = "";

            }
        }

        private void CalculatePreemptiveSJF()
        {
            processes = processes.OrderBy(p => p.ArrivalTime).ToList();
            int n = processes.Count;
            int[] completionTimes = new int[n];
            int[] waitingTimes = new int[n];
            int[] turnAroundTimes = new int[n];

            // Calculate completion, waiting, and turnaround times
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    completionTimes[i] = processes[i].ArrivalTime + processes[i].BurstTime;
                }
                else
                {
                    completionTimes[i] = completionTimes[i - 1] + processes[i].BurstTime;
                }

                waitingTimes[i] = completionTimes[i] - processes[i].ArrivalTime - processes[i].BurstTime;
                if (waitingTimes[i] < 0)
                {
                    waitingTimes[i] = 0;
                }

                turnAroundTimes[i] = completionTimes[i] - processes[i].ArrivalTime;

                // Update process properties with computed times
                processes[i].CompletionTime = completionTimes[i];
                processes[i].TurnAroundTime = turnAroundTimes[i];
                processes[i].WaitingTime = waitingTimes[i];
            }

            // Clear and refresh DataGridView to reflect updated data
            dataGridView_preemp.Rows.Clear();
            foreach (var process in processes)
            {
                dataGridView_preemp.Rows.Add(
                    process.ProcessID,
                    process.ArrivalTime,
                    process.BurstTime,
                    process.CompletionTime,
                    process.TurnAroundTime,
                    process.WaitingTime
                );
            }

            // Calculate and display average times
            double avgTurnAround = processes.Average(p => p.TurnAroundTime);
            double avgWaiting = processes.Average(p => p.WaitingTime);
            textBoxavgtat.Text = avgTurnAround.ToString("F2");
            textBoxavgwt.Text = avgWaiting.ToString("F2");
        }

        private void btn_CalPreemp_Click(object sender, EventArgs e)
        {
            // Call CalculatePreemptiveSJF to calculate and display results
            CalculatePreemptiveSJF();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void btnshowsteps_Click(object sender, EventArgs e)
        {
            List<(int, int)> processSequence = processes.Select(p => (p.ProcessID, p.BurstTime)).ToList();
            GantChart gc = new GantChart(processSequence);
            gc.Show();
        }
    }
}
