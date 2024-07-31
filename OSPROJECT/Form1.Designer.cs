namespace OSPROJECT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_prevsnon = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_FIRST = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.label_JOB = new System.Windows.Forms.Label();
            this.label_shortest = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 642);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1089, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 642);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.label_prevsnon);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1069, 48);
            this.panel3.TabIndex = 2;
            // 
            // label_prevsnon
            // 
            this.label_prevsnon.AutoSize = true;
            this.label_prevsnon.BackColor = System.Drawing.Color.MidnightBlue;
            this.label_prevsnon.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prevsnon.ForeColor = System.Drawing.Color.Azure;
            this.label_prevsnon.Location = new System.Drawing.Point(215, 3);
            this.label_prevsnon.Name = "label_prevsnon";
            this.label_prevsnon.Size = new System.Drawing.Size(645, 47);
            this.label_prevsnon.TabIndex = 12;
            this.label_prevsnon.Text = "PROCESS SCHEDULER SIMULATOR";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(1000, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label_FIRST);
            this.panel4.Controls.Add(this.btn_enter);
            this.panel4.Controls.Add(this.label_JOB);
            this.panel4.Controls.Add(this.label_shortest);
            this.panel4.Controls.Add(this.label_welcome);
            this.panel4.Location = new System.Drawing.Point(20, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1069, 595);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(789, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 77);
            this.label1.TabIndex = 7;
            this.label1.Text = "(SJF)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(375, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Click Enter To Continue";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_FIRST
            // 
            this.label_FIRST.AutoSize = true;
            this.label_FIRST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_FIRST.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FIRST.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_FIRST.Location = new System.Drawing.Point(576, 19);
            this.label_FIRST.Name = "label_FIRST";
            this.label_FIRST.Size = new System.Drawing.Size(187, 77);
            this.label_FIRST.TabIndex = 6;
            this.label_FIRST.Text = "FIRST";
            this.label_FIRST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_enter.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.ForeColor = System.Drawing.Color.SlateBlue;
            this.btn_enter.Location = new System.Drawing.Point(390, 336);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(241, 53);
            this.btn_enter.TabIndex = 9;
            this.btn_enter.Text = "ENTER";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // label_JOB
            // 
            this.label_JOB.AutoSize = true;
            this.label_JOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_JOB.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_JOB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_JOB.Location = new System.Drawing.Point(416, 19);
            this.label_JOB.Name = "label_JOB";
            this.label_JOB.Size = new System.Drawing.Size(134, 77);
            this.label_JOB.TabIndex = 5;
            this.label_JOB.Text = "JOB";
            this.label_JOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_shortest
            // 
            this.label_shortest.AutoSize = true;
            this.label_shortest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_shortest.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_shortest.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_shortest.Location = new System.Drawing.Point(71, 19);
            this.label_shortest.Name = "label_shortest";
            this.label_shortest.Size = new System.Drawing.Size(316, 77);
            this.label_shortest.TabIndex = 4;
            this.label_shortest.Text = "SHORTEST";
            this.label_shortest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.BackColor = System.Drawing.Color.Transparent;
            this.label_welcome.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label_welcome.Location = new System.Drawing.Point(63, 164);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(902, 47);
            this.label_welcome.TabIndex = 4;
            this.label_welcome.Text = "WELCOME TO PROCESS SCHEDULER SIMULATOR";
            this.label_welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_username.Location = new System.Drawing.Point(501, 184);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(0, 27);
            this.label_username.TabIndex = 5;
            this.label_username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(20, 602);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1069, 40);
            this.panel6.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 642);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_FIRST;
        private System.Windows.Forms.Label label_JOB;
        private System.Windows.Forms.Label label_shortest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_prevsnon;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

