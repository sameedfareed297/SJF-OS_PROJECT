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
    public partial class calNonPreemp : Form
    {
        public calNonPreemp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            List<Process> Process_List = new List<Process>();
            int processId = int.Parse(numericUpDown1.Text);
            int burstTime;

            // Validate Burst Time
            if (!int.TryParse(numericUpDown3_BT.Text, out burstTime) || burstTime == 0)
            {
                MessageBox.Show("Invalid Burst Time. Burst Time cannot be null or zero.", "Error");
                return;
            }

            // Check if the processId already exists in the dataGridView1
            if (dataGridView1.Rows.Cast<DataGridViewRow>().Any(row => row.Cells[0].Value.ToString() == processId.ToString()))
            {
                MessageBox.Show("Process ID already exists. Please enter a unique ID.", "Error");
                return;
            }
            Process process = new Process
            {
                P_id = processId,
                arrival_time = int.Parse(numericUpDown_AT2.Text),
                burst_time = int.Parse(numericUpDown3_BT.Text)
            };
            Process_List.Add(process);

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = numericUpDown1.Text;
            dataGridView1.Rows[n].Cells[1].Value = numericUpDown_AT2.Text;
            dataGridView1.Rows[n].Cells[2].Value = numericUpDown3_BT.Text;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_AT2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_BT_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_clearprocess_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Remove all Process?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                numericUpDown1.Value = 0;
                numericUpDown3_BT.Value = 0;
                numericUpDown_AT2.Value = 0;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }
        }

        public class Process
        {
            public int P_id { get; set; }
            public int arrival_time { get; set; }
            public int burst_time { get; set; }
            public int completion_time { get; set; }
            public int turnAround_time { get; set; }
            public int waiting_time { get; set; }
            public int compeletion_time { get; set; }
            public int PturnAround_time { get; set; }
            public int Pwaiting_time { get; set; }
        }

        public List<(int, int)> SJFNonPreemptive(List<Process> ProcessList)
        {
            int n = ProcessList.Count;

            // Sort processes by arrival time and then by burst time
            ProcessList = ProcessList.OrderBy(p => p.arrival_time).ThenBy(p => p.burst_time).ToList();

            int[] completionTimes = new int[n];
            int[] waitingTimes = new int[n];
            int[] turnAroundTimes = new int[n];

            // Calculate completion, waiting, and turnaround times
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    completionTimes[i] = ProcessList[i].arrival_time + ProcessList[i].burst_time;
                }
                else
                {
                    completionTimes[i] = completionTimes[i - 1] + ProcessList[i].burst_time;
                }

                waitingTimes[i] = completionTimes[i] - ProcessList[i].arrival_time - ProcessList[i].burst_time;
                if (waitingTimes[i] < 0)
                {
                    waitingTimes[i] = 0;
                }

                turnAroundTimes[i] = completionTimes[i] - ProcessList[i].arrival_time;

                // Update process properties with computed times
                ProcessList[i].completion_time = completionTimes[i];
                ProcessList[i].turnAround_time = turnAroundTimes[i];
                ProcessList[i].waiting_time = waitingTimes[i];
            }

            // Create and return process sequence
            List<(int, int)> processSequence = new List<(int, int)>();
            for (int i = 0; i < n; i++)
            {
                processSequence.Add((ProcessList[i].P_id, ProcessList[i].burst_time));
            }
            return processSequence;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            List<Process> Process_List = new List<Process>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    Process process = new Process
                    {
                        P_id = int.Parse(row.Cells[0].Value.ToString()),
                        arrival_time = int.Parse(row.Cells[1].Value.ToString()),
                        burst_time = int.Parse(row.Cells[2].Value.ToString())
                    };
                    Process_List.Add(process);
                }
            }

            if (Process_List.Count == 0)
            {
                MessageBox.Show("Please insert data first.", "Error");
                return;
            }

            SJFNonPreemptive(Process_List);

            // Clear the DataGridView
            dataGridView1.Rows.Clear();

            // Populate the DataGridView with updated process information
            foreach (var process in Process_List.OrderBy(p => p.P_id))
            {
                dataGridView1.Rows.Add(
                    process.P_id,
                    process.arrival_time,
                    process.burst_time,
                    process.completion_time,
                    process.turnAround_time,
                    process.waiting_time
                );
            }

            int total_turnAround_time = Process_List.Sum(p => p.turnAround_time);
            int total_waiting_time = Process_List.Sum(p => p.waiting_time);

            textBox_avgtat.Text = (total_turnAround_time / (double)Process_List.Count).ToString("F2");
            textBox_avgwt.Text = (total_waiting_time / (double)Process_List.Count).ToString("F2");
        }

        private void btn_showsteps_Click(object sender, EventArgs e)
        {
            List<Process> Process_List = new List<Process>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    Process process = new Process
                    {
                        P_id = int.Parse(row.Cells[0].Value.ToString()),
                        arrival_time = int.Parse(row.Cells[1].Value.ToString()),
                        burst_time = int.Parse(row.Cells[2].Value.ToString())
                    };
                    Process_List.Add(process);
                }
            }

            if (Process_List.Count == 0)
            {
                MessageBox.Show("Please insert data first.", "Error");
                return;
            }

            SJFNonPreemptive(Process_List);

            // Clear the DataGridView
            dataGridView1.Rows.Clear();

            // Populate the DataGridView with updated process information
            foreach (var process in Process_List.OrderBy(p => p.P_id))
            {
                dataGridView1.Rows.Add(
                    process.P_id,
                    process.arrival_time,
                    process.burst_time,
                    process.completion_time,
                    process.turnAround_time,
                    process.waiting_time
                );
            }

            int total_turnAround_time = Process_List.Sum(p => p.turnAround_time);
            int total_waiting_time = Process_List.Sum(p => p.waiting_time);

            textBox_avgtat.Text = (total_turnAround_time / (double)Process_List.Count).ToString("F2");
            textBox_avgwt.Text = (total_waiting_time / (double)Process_List.Count).ToString("F2");

            // Call GantChart form and pass process sequence
            List<(int, int)> processSequence = SJFNonPreemptive(Process_List);
            GantChart gantChart = new GantChart(processSequence);
            gantChart.Show();
        }

        private void textBox_avgtat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
