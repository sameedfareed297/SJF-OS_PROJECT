namespace OSPROJECT
{
    partial class calPreemp
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
            this.AT_pre = new System.Windows.Forms.NumericUpDown();
            this.Pid_pre = new System.Windows.Forms.NumericUpDown();
            this.BT_Pre = new System.Windows.Forms.NumericUpDown();
            this.label_processid = new System.Windows.Forms.Label();
            this.label_arrivalTime = new System.Windows.Forms.Label();
            this.label_burstime = new System.Windows.Forms.Label();
            this.btn_CalPreemp = new System.Windows.Forms.Button();
            this.btn_addprocess = new System.Windows.Forms.Button();
            this.btnclearprocess = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxavgwt = new System.Windows.Forms.TextBox();
            this.label_avgwt = new System.Windows.Forms.Label();
            this.textBoxavgtat = new System.Windows.Forms.TextBox();
            this.label_AVGTAT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_preemp = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_preemp = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnshowsteps = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_sjf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AT_pre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pid_pre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_Pre)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_preemp.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_preemp)).BeginInit();
            this.SuspendLayout();
            // 
            // AT_pre
            // 
            this.AT_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AT_pre.Location = new System.Drawing.Point(376, 68);
            this.AT_pre.Name = "AT_pre";
            this.AT_pre.Size = new System.Drawing.Size(175, 27);
            this.AT_pre.TabIndex = 117;
            // 
            // Pid_pre
            // 
            this.Pid_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pid_pre.Location = new System.Drawing.Point(74, 68);
            this.Pid_pre.Name = "Pid_pre";
            this.Pid_pre.Size = new System.Drawing.Size(175, 27);
            this.Pid_pre.TabIndex = 118;
            // 
            // BT_Pre
            // 
            this.BT_Pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Pre.Location = new System.Drawing.Point(668, 68);
            this.BT_Pre.Name = "BT_Pre";
            this.BT_Pre.Size = new System.Drawing.Size(175, 27);
            this.BT_Pre.TabIndex = 135;
            // 
            // label_processid
            // 
            this.label_processid.AutoSize = true;
            this.label_processid.BackColor = System.Drawing.Color.Transparent;
            this.label_processid.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_processid.ForeColor = System.Drawing.Color.Indigo;
            this.label_processid.Location = new System.Drawing.Point(70, 43);
            this.label_processid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_processid.Name = "label_processid";
            this.label_processid.Size = new System.Drawing.Size(101, 22);
            this.label_processid.TabIndex = 136;
            this.label_processid.Text = "Process ID";
            // 
            // label_arrivalTime
            // 
            this.label_arrivalTime.AutoSize = true;
            this.label_arrivalTime.BackColor = System.Drawing.Color.Transparent;
            this.label_arrivalTime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_arrivalTime.ForeColor = System.Drawing.Color.Indigo;
            this.label_arrivalTime.Location = new System.Drawing.Point(372, 43);
            this.label_arrivalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_arrivalTime.Name = "label_arrivalTime";
            this.label_arrivalTime.Size = new System.Drawing.Size(111, 22);
            this.label_arrivalTime.TabIndex = 137;
            this.label_arrivalTime.Text = "Arrival Time";
            // 
            // label_burstime
            // 
            this.label_burstime.AutoSize = true;
            this.label_burstime.BackColor = System.Drawing.Color.Transparent;
            this.label_burstime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_burstime.ForeColor = System.Drawing.Color.Indigo;
            this.label_burstime.Location = new System.Drawing.Point(664, 43);
            this.label_burstime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_burstime.Name = "label_burstime";
            this.label_burstime.Size = new System.Drawing.Size(96, 22);
            this.label_burstime.TabIndex = 138;
            this.label_burstime.Text = "Burst Time";
            // 
            // btn_CalPreemp
            // 
            this.btn_CalPreemp.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_CalPreemp.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalPreemp.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_CalPreemp.Location = new System.Drawing.Point(366, 131);
            this.btn_CalPreemp.Name = "btn_CalPreemp";
            this.btn_CalPreemp.Size = new System.Drawing.Size(223, 47);
            this.btn_CalPreemp.TabIndex = 139;
            this.btn_CalPreemp.Text = "CALCULATE";
            this.btn_CalPreemp.UseVisualStyleBackColor = false;
            this.btn_CalPreemp.Click += new System.EventHandler(this.btn_CalPreemp_Click);
            // 
            // btn_addprocess
            // 
            this.btn_addprocess.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_addprocess.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addprocess.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_addprocess.Location = new System.Drawing.Point(990, 52);
            this.btn_addprocess.Name = "btn_addprocess";
            this.btn_addprocess.Size = new System.Drawing.Size(223, 52);
            this.btn_addprocess.TabIndex = 140;
            this.btn_addprocess.Text = "ADD PROCESS";
            this.btn_addprocess.UseVisualStyleBackColor = false;
            this.btn_addprocess.Click += new System.EventHandler(this.btn_addprocess_Click);
            // 
            // btnclearprocess
            // 
            this.btnclearprocess.BackColor = System.Drawing.SystemColors.Menu;
            this.btnclearprocess.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclearprocess.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnclearprocess.Location = new System.Drawing.Point(990, 147);
            this.btnclearprocess.Name = "btnclearprocess";
            this.btnclearprocess.Size = new System.Drawing.Size(223, 58);
            this.btnclearprocess.TabIndex = 141;
            this.btnclearprocess.Text = "CLEAR PROCESS";
            this.btnclearprocess.UseVisualStyleBackColor = false;
            this.btnclearprocess.Click += new System.EventHandler(this.btnclearprocess_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxavgwt);
            this.panel3.Controls.Add(this.label_avgwt);
            this.panel3.Controls.Add(this.textBoxavgtat);
            this.panel3.Controls.Add(this.label_AVGTAT);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(920, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 286);
            this.panel3.TabIndex = 142;
            // 
            // textBoxavgwt
            // 
            this.textBoxavgwt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxavgwt.Location = new System.Drawing.Point(10, 194);
            this.textBoxavgwt.Multiline = true;
            this.textBoxavgwt.Name = "textBoxavgwt";
            this.textBoxavgwt.Size = new System.Drawing.Size(110, 40);
            this.textBoxavgwt.TabIndex = 131;
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
            // textBoxavgtat
            // 
            this.textBoxavgtat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxavgtat.Location = new System.Drawing.Point(10, 115);
            this.textBoxavgtat.Multiline = true;
            this.textBoxavgtat.Name = "textBoxavgtat";
            this.textBoxavgtat.Size = new System.Drawing.Size(110, 40);
            this.textBoxavgtat.TabIndex = 129;
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
            // panel_preemp
            // 
            this.panel_preemp.BackColor = System.Drawing.Color.White;
            this.panel_preemp.Controls.Add(this.panel2);
            this.panel_preemp.Location = new System.Drawing.Point(12, 199);
            this.panel_preemp.Name = "panel_preemp";
            this.panel_preemp.Size = new System.Drawing.Size(834, 355);
            this.panel_preemp.TabIndex = 143;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_preemp);
            this.panel2.Location = new System.Drawing.Point(16, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 277);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView_preemp
            // 
            this.dataGridView_preemp.AllowUserToAddRows = false;
            this.dataGridView_preemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_preemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView_preemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_preemp.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_preemp.Name = "dataGridView_preemp";
            this.dataGridView_preemp.RowHeadersWidth = 51;
            this.dataGridView_preemp.RowTemplate.Height = 24;
            this.dataGridView_preemp.Size = new System.Drawing.Size(802, 277);
            this.dataGridView_preemp.TabIndex = 0;
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
            // btnshowsteps
            // 
            this.btnshowsteps.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnshowsteps.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowsteps.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnshowsteps.Location = new System.Drawing.Point(537, 582);
            this.btnshowsteps.Name = "btnshowsteps";
            this.btnshowsteps.Size = new System.Drawing.Size(223, 61);
            this.btnshowsteps.TabIndex = 144;
            this.btnshowsteps.Text = "SHOW STEPS";
            this.btnshowsteps.UseVisualStyleBackColor = false;
            this.btnshowsteps.Click += new System.EventHandler(this.btnshowsteps_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_exit.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_exit.Location = new System.Drawing.Point(1259, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(52, 48);
            this.button_exit.TabIndex = 145;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_sjf
            // 
            this.label_sjf.AutoSize = true;
            this.label_sjf.BackColor = System.Drawing.Color.Transparent;
            this.label_sjf.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sjf.ForeColor = System.Drawing.Color.Indigo;
            this.label_sjf.Location = new System.Drawing.Point(24, 174);
            this.label_sjf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sjf.Name = "label_sjf";
            this.label_sjf.Size = new System.Drawing.Size(123, 22);
            this.label_sjf.TabIndex = 146;
            this.label_sjf.Text = "SJF(PRE-EMP)";
            // 
            // calPreemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1323, 655);
            this.Controls.Add(this.label_sjf);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.btnshowsteps);
            this.Controls.Add(this.panel_preemp);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnclearprocess);
            this.Controls.Add(this.btn_addprocess);
            this.Controls.Add(this.btn_CalPreemp);
            this.Controls.Add(this.label_burstime);
            this.Controls.Add(this.label_arrivalTime);
            this.Controls.Add(this.label_processid);
            this.Controls.Add(this.BT_Pre);
            this.Controls.Add(this.Pid_pre);
            this.Controls.Add(this.AT_pre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calPreemp";
            this.Text = "calPreemp";
            ((System.ComponentModel.ISupportInitialize)(this.AT_pre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pid_pre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_Pre)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_preemp.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_preemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown AT_pre;
        private System.Windows.Forms.NumericUpDown Pid_pre;
        private System.Windows.Forms.NumericUpDown BT_Pre;
        private System.Windows.Forms.Label label_processid;
        private System.Windows.Forms.Label label_arrivalTime;
        private System.Windows.Forms.Label label_burstime;
        private System.Windows.Forms.Button btn_CalPreemp;
        private System.Windows.Forms.Button btn_addprocess;
        private System.Windows.Forms.Button btnclearprocess;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxavgwt;
        private System.Windows.Forms.Label label_avgwt;
        private System.Windows.Forms.TextBox textBoxavgtat;
        private System.Windows.Forms.Label label_AVGTAT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_preemp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_preemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnshowsteps;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_sjf;
    }
}