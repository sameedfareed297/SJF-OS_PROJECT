using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OSPROJECT
{
    public partial class GantChart : Form
    {
        private List<(int ProcessId, int BurstTime)> processSequence;

        public GantChart(List<(int, int)> sequence)
        {
            InitializeComponent();
            processSequence = new List<(int ProcessId, int BurstTime)>(sequence);
        }

        protected override void OnPaint(PaintEventArgs e)
        {


        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Handle background work here
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e); // Call base implementation of OnPaint if necessary

            // Obtain graphics object from the panel
            Graphics g = e.Graphics;

            // Call your drawing method here, passing the Graphics object
            DrawGanttChart(g);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle list view selected index changed event here
            // Clear the panel before drawing
            panel.Invalidate(); // Forces the panel to redraw itself
        }
        private void DrawGanttChart(Graphics g)
        {
            // Example dimensions and positioning
            int startX = 50;
            int startY = 50;
            int rectHeight = 30;
            int rectWidthUnit = 30; // Adjust based on burst times

            // Draw the Gantt chart
            for (int i = 0; i < processSequence.Count; i++)
            {
                int burstTime = processSequence[i].BurstTime;
                int rectWidth = burstTime * rectWidthUnit;
                Rectangle rect = new Rectangle(startX, startY, rectWidth, rectHeight);

                // Draw the rectangle representing the process
                g.FillRectangle(Brushes.LightBlue, rect);
                g.DrawRectangle(Pens.Black, rect);

                // Draw process ID text centered in the rectangle
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString($"P{processSequence[i].ProcessId}", this.Font, Brushes.Black, rect, sf);

                // Draw burst time text centered below the rectangle
                Rectangle timeRect = new Rectangle(startX, startY + rectHeight, rectWidth, rectHeight / 2);
                g.DrawString(burstTime.ToString(), this.Font, Brushes.Black, timeRect, sf);

                // Update startX for the next rectangle
                startX += rectWidthUnit * burstTime;
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}