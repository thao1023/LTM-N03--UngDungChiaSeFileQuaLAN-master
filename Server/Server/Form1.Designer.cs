namespace Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnStart = new Button();
            txtPort = new TextBox();
            txtHost = new TextBox();
            btnStop = new Button();
            btnExit = new Button();
            txtStatus = new TextBox();
            btnSave = new Button();
            txtDuongDan = new TextBox();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(126, 14);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 0;
            label1.Text = "SHARE FILES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 48);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 1;
            label2.Text = "Port:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 85);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 2;
            label3.Text = "Host:";
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ButtonFace;
            btnStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(175, 45);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(85, 25);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start Server";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // txtPort
            // 
            txtPort.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPort.Location = new Point(49, 45);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(120, 25);
            txtPort.TabIndex = 4;
            txtPort.Text = "9000";
            // 
            // txtHost
            // 
            txtHost.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHost.Location = new Point(49, 82);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(211, 25);
            txtHost.TabIndex = 5;
            txtHost.Text = "127.0.0.1";
            // 
            // btnStop
            // 
            btnStop.BackColor = SystemColors.ButtonFace;
            btnStop.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStop.Location = new Point(266, 45);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(85, 25);
            btnStop.TabIndex = 6;
            btnStop.Text = "Stop Server";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonFace;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(266, 82);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(85, 26);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(12, 120);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.ScrollBars = ScrollBars.Both;
            txtStatus.Size = new Size(339, 163);
            txtStatus.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ButtonFace;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(12, 295);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(65, 26);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save as:";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtDuongDan
            // 
            txtDuongDan.Location = new Point(83, 295);
            txtDuongDan.Multiline = true;
            txtDuongDan.Name = "txtDuongDan";
            txtDuongDan.Size = new Size(268, 27);
            txtDuongDan.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(146, 328);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 11;
            label4.Text = "Loading ...";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(11, 351);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(340, 23);
            progressBar1.TabIndex = 12;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 383);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(txtDuongDan);
            Controls.Add(btnSave);
            Controls.Add(txtStatus);
            Controls.Add(btnExit);
            Controls.Add(btnStop);
            Controls.Add(txtHost);
            Controls.Add(txtPort);
            Controls.Add(btnStart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnStart;
        private TextBox txtPort;
        private TextBox txtHost;
        private Button btnStop;
        private Button btnExit;
        private TextBox txtStatus;
        private Button btnSave;
        private TextBox txtDuongDan;
        private Label label4;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
