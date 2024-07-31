namespace OSPROJECT
{
    partial class calNonPreemp
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label_processid = new System.Windows.Forms.Label();
            this.label_arrivalTime = new System.Windows.Forms.Label();
            this.label_burstime = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_clearprocess = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_sjf = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_avgwt = new System.Windows.Forms.TextBox();
            this.label_avgwt = new System.Windows.Forms.Label();
            this.textBox_avgtat = new System.Windows.Forms.TextBox();
            this.label_AVGTAT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_showsteps = new System.Windows.Forms.Button();
            this.numericUpDown_AT2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3_BT = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3_BT)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(65, 64);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(175, 27);
            this.numericUpDown1.TabIndex = 116;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label_processid
            // 
            this.label_processid.AutoSize = true;
            this.label_processid.BackColor = System.Drawing.Color.Transparent;
            this.label_processid.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_processid.ForeColor = System.Drawing.Color.Indigo;
            this.label_processid.Location = new System.Drawing.Point(61, 39);
            this.label_processid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_processid.Name = "label_processid";
            this.label_processid.Size = new System.Drawing.Size(101, 22);
            this.label_processid.TabIndex = 117;
            this.label_processid.Text = "Process ID";
            // 
            // label_arrivalTime
            // 
            this.label_arrivalTime.AutoSize = true;
            this.label_arrivalTime.BackColor = System.Drawing.Color.Transparent;
            this.label_arrivalTime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_arrivalTime.ForeColor = System.Drawing.Color.Indigo;
            this.label_arrivalTime.Location = new System.Drawing.Point(335, 39);
            this.label_arrivalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_arrivalTime.Name = "label_arrivalTime";
            this.label_arrivalTime.Size = new System.Drawing.Size(111, 22);
            this.label_arrivalTime.TabIndex = 118;
            this.label_arrivalTime.Text = "Arrival Time";
            // 
            // label_burstime
            // 
            this.label_burstime.AutoSize = true;
            this.label_burstime.BackColor = System.Drawing.Color.Transparent;
            this.label_burstime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_burstime.ForeColor = System.Drawing.Color.Indigo;
            this.label_burstime.Location = new System.Drawing.Point(595, 39);
            this.label_burstime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_burstime.Name = "label_burstime";
            this.label_burstime.Size = new System.Drawing.Size(96, 22);
            this.label_burstime.TabIndex = 120;
            this.label_burstime.Text = "Burst Time";
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_enter.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_enter.Location = new System.Drawing.Point(922, 39);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(223, 52);
            this.btn_enter.TabIndex = 122;
            this.btn_enter.Text = "ADD PROCESS";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_clearprocess
            // 
            this.btn_clearprocess.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_clearprocess.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearprocess.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_clearprocess.Location = new System.Drawing.Point(922, 135);
            this.btn_clearprocess.Name = "btn_clearprocess";
            this.btn_clearprocess.Size = new System.Drawing.Size(223, 58);
            this.btn_clearprocess.TabIndex = 123;
            this.btn_clearprocess.Text = "CLEAR PROCESS";
            this.btn_clearprocess.UseVisualStyleBackColor = false;
            this.btn_clearprocess.Click += new System.EventHandler(this.btn_clearprocess_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(1236, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 48);
            this.button2.TabIndex = 124;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkViolet;
            this.button1.Location = new System.Drawing.Point(321, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 47);
            this.button1.TabIndex = 125;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 355);
            this.panel1.TabIndex = 126;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(16, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 277);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Process No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Arrival Time";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Burst Time";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Completion Time";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Turn Around Time";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Waiting Time";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // label_sjf
            // 
            this.label_sjf.AutoSize = true;
            this.label_sjf.BackColor = System.Drawing.Color.Transparent;
            this.label_sjf.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sjf.ForeColor = System.Drawing.Color.Indigo;
            this.label_sjf.Location = new System.Drawing.Point(13, 193);
            this.label_sjf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sjf.Name = "label_sjf";
            this.label_sjf.Size = new System.Drawing.Size(172, 22);
            this.label_sjf.TabIndex = 128;
            this.label_sjf.Text = "SJF(NON-PRE-EMP)";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_avgwt);
            this.panel3.Controls.Add(this.label_avgwt);
            this.panel3.Controls.Add(this.textBox_avgtat);
            this.panel3.Controls.Add(this.label_AVGTAT);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(880, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 286);
            this.panel3.TabIndex = 129;
            // 
            // textBox_avgwt
            // 
            this.textBox_avgwt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_avgwt.Location = new System.Drawing.Point(10, 194);
            this.textBox_avgwt.Multiline = true;
            this.textBox_avgwt.Name = "textBox_avgwt";
            this.textBox_avgwt.Size = new System.Drawing.Size(110, 40);
            this.textBox_avgwt.TabIndex = 131;
            // 
            // label_avgwt
            // 
            this.label_avgwt.AutoSize = true;
            this.label_avgwt.BackColor = System.Drawing.Color.Transparent;
            this.label_avgwt.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_avgwt.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label_avgwt.Location = new System.Drawing.Point(6, 169);
            this.label_avgwt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_avgwt.Name = "label_avgwt";
            this.label_avgwt.Size = new System.Drawing.Size(197, 22);
            this.label_avgwt.TabIndex = 130;
            this.label_avgwt.Text = "Average WaitingTime";
            // 
            // textBox_avgtat
            // 
            this.textBox_avgtat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_avgtat.Location = new System.Drawing.Point(10, 115);
            this.textBox_avgtat.Multiline = true;
            this.textBox_avgtat.Name = "textBox_avgtat";
            this.textBox_avgtat.Size = new System.Drawing.Size(110, 40);
            this.textBox_avgtat.TabIndex = 129;
            this.textBox_avgtat.TextChanged += new System.EventHandler(this.textBox_avgtat_TextChanged);
            // 
            // label_AVGTAT
            // 
            this.label_AVGTAT.AutoSize = true;
            this.label_AVGTAT.BackColor = System.Drawing.Color.Transparent;
            this.label_AVGTAT.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AVGTAT.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label_AVGTAT.Location = new System.Drawing.Point(4, 90);
            this.label_AVGTAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_AVGTAT.Name = "label_AVGTAT";
            this.label_AVGTAT.Size = new System.Drawing.Size(234, 22);
            this.label_AVGTAT.TabIndex = 128;
            this.label_AVGTAT.Text = "Average TurnAroundTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 34);
            this.label2.TabIndex = 117;
            this.label2.Text = "AVERAGE TIME";
            // 
            // btn_showsteps
            // 
            this.btn_showsteps.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_showsteps.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showsteps.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_showsteps.Location = new System.Drawing.Point(528, 590);
            this.btn_showsteps.Name = "btn_showsteps";
            this.btn_showsteps.Size = new System.Drawing.Size(223, 61);
            this.btn_showsteps.TabIndex = 132;
            this.btn_showsteps.Text = "SHOW STEPS";
            this.btn_showsteps.UseVisualStyleBackColor = false;
            this.btn_showsteps.Click += new System.EventHandler(this.btn_showsteps_Click);
            // 
            // numericUpDown_AT2
            // 
            this.numericUpDown_AT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_AT2.Location = new System.Drawing.Point(321, 70);
            this.numericUpDown_AT2.Name = "numericUpDown_AT2";
            this.numericUpDown_AT2.Size = new System.Drawing.Size(175, 27);
            this.numericUpDown_AT2.TabIndex = 133;
            this.numericUpDown_AT2.ValueChanged += new System.EventHandler(this.numericUpDown_AT2_ValueChanged);
            // 
            // numericUpDown3_BT
            // 
            this.numericUpDown3_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3_BT.Location = new System.Drawing.Point(599, 70);
            this.numericUpDown3_BT.Name = "numericUpDown3_BT";
            this.numericUpDown3_BT.Size = new System.Drawing.Size(175, 27);
            this.numericUpDown3_BT.TabIndex = 134;
            this.numericUpDown3_BT.ValueChanged += new System.EventHandler(this.numericUpDown3_BT_ValueChanged);
            // 
            // calNonPreemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1289, 682);
            this.Controls.Add(this.numericUpDown3_BT);
            this.Controls.Add(this.numericUpDown_AT2);
            this.Controls.Add(this.btn_showsteps);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label_sjf);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_clearprocess);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label_burstime);
            this.Controls.Add(this.label_arrivalTime);
            this.Controls.Add(this.label_processid);
            this.Controls.Add(this.numericUpDown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calNonPreemp";
            this.Text = "calNonPreemp";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3_BT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label_processid;
        private System.Windows.Forms.Label label_arrivalTime;
        private System.Windows.Forms.Label label_burstime;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_clearprocess;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_sjf;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_avgwt;
        private System.Windows.Forms.Label label_avgwt;
        private System.Windows.Forms.TextBox textBox_avgtat;
        private System.Windows.Forms.Label label_AVGTAT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_showsteps;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.NumericUpDown numericUpDown_AT2;
        private System.Windows.Forms.NumericUpDown numericUpDown3_BT;
    }
}