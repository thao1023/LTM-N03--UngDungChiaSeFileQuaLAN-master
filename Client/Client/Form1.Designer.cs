namespace Client
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPort = new TextBox();
            txtHost = new TextBox();
            btnConnect = new Button();
            btnDisconnect = new Button();
            btnSend = new Button();
            btnExit = new Button();
            txtLog = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(121, 16);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 0;
            label1.Text = "SHARE FILES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 54);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 1;
            label2.Text = "Port:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 89);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 2;
            label3.Text = "Server IP:";
            // 
            // txtPort
            // 
            txtPort.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPort.Location = new Point(70, 51);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(178, 25);
            txtPort.TabIndex = 3;
            txtPort.Text = "9000";
            // 
            // txtHost
            // 
            txtHost.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHost.Location = new Point(70, 86);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(178, 25);
            txtHost.TabIndex = 4;
            txtHost.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = SystemColors.ButtonFace;
            btnConnect.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConnect.Location = new Point(254, 50);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(83, 26);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = SystemColors.ButtonFace;
            btnDisconnect.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDisconnect.Location = new Point(254, 84);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(83, 26);
            btnDisconnect.TabIndex = 6;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.ButtonFace;
            btnSend.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(196, 120);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 26);
            btnSend.TabIndex = 7;
            btnSend.Text = "Send File";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonFace;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(277, 120);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(60, 26);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtLog
            // 
            txtLog.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLog.Location = new Point(12, 157);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ScrollBars = ScrollBars.Both;
            txtLog.Size = new Size(325, 161);
            txtLog.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 329);
            Controls.Add(txtLog);
            Controls.Add(btnExit);
            Controls.Add(btnSend);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Controls.Add(txtHost);
            Controls.Add(txtPort);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPort;
        private TextBox txtHost;
        private Button btnConnect;
        private Button btnDisconnect;
        private Button btnSend;
        private Button btnExit;
        private TextBox txtLog;
    }
}
