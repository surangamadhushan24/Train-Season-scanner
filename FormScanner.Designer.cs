namespace ScanerProject
{
    partial class FormScanner
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelCamera = new System.Windows.Forms.Label();
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonViewDetail = new System.Windows.Forms.Button();
            this.labelViewSid = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelLog = new System.Windows.Forms.Label();
            this.buttonAdminDashboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.labelLog);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 72);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(684, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(45, 150);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(337, 309);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // labelCamera
            // 
            this.labelCamera.AutoSize = true;
            this.labelCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCamera.ForeColor = System.Drawing.Color.Navy;
            this.labelCamera.Location = new System.Drawing.Point(428, 164);
            this.labelCamera.Name = "labelCamera";
            this.labelCamera.Size = new System.Drawing.Size(74, 20);
            this.labelCamera.TabIndex = 2;
            this.labelCamera.Text = "Camera";
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(524, 161);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(200, 28);
            this.comboBoxDevice.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.White;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Navy;
            this.buttonStart.Location = new System.Drawing.Point(432, 246);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(117, 39);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonViewDetail
            // 
            this.buttonViewDetail.BackColor = System.Drawing.Color.White;
            this.buttonViewDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewDetail.ForeColor = System.Drawing.Color.Navy;
            this.buttonViewDetail.Location = new System.Drawing.Point(432, 313);
            this.buttonViewDetail.Name = "buttonViewDetail";
            this.buttonViewDetail.Size = new System.Drawing.Size(117, 58);
            this.buttonViewDetail.TabIndex = 5;
            this.buttonViewDetail.Text = "VIEW DETAIL";
            this.buttonViewDetail.UseVisualStyleBackColor = false;
            this.buttonViewDetail.Click += new System.EventHandler(this.buttonViewDetail_Click);
            // 
            // labelViewSid
            // 
            this.labelViewSid.AutoSize = true;
            this.labelViewSid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewSid.ForeColor = System.Drawing.Color.Navy;
            this.labelViewSid.Location = new System.Drawing.Point(66, 475);
            this.labelViewSid.Name = "labelViewSid";
            this.labelViewSid.Size = new System.Drawing.Size(37, 20);
            this.labelViewSid.TabIndex = 6;
            this.labelViewSid.Text = "****";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.BackColor = System.Drawing.Color.Navy;
            this.labelLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLog.ForeColor = System.Drawing.Color.White;
            this.labelLog.Location = new System.Drawing.Point(271, 17);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(186, 38);
            this.labelLog.TabIndex = 8;
            this.labelLog.Text = "SCANNER";
            // 
            // buttonAdminDashboard
            // 
            this.buttonAdminDashboard.BackColor = System.Drawing.Color.White;
            this.buttonAdminDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminDashboard.ForeColor = System.Drawing.Color.Navy;
            this.buttonAdminDashboard.Location = new System.Drawing.Point(432, 401);
            this.buttonAdminDashboard.Name = "buttonAdminDashboard";
            this.buttonAdminDashboard.Size = new System.Drawing.Size(117, 58);
            this.buttonAdminDashboard.TabIndex = 7;
            this.buttonAdminDashboard.Text = "Admin Dashboard";
            this.buttonAdminDashboard.UseVisualStyleBackColor = false;
            this.buttonAdminDashboard.Click += new System.EventHandler(this.buttonAdminDashboard_Click);
            // 
            // FormScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 592);
            this.Controls.Add(this.buttonAdminDashboard);
            this.Controls.Add(this.labelViewSid);
            this.Controls.Add(this.buttonViewDetail);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxDevice);
            this.Controls.Add(this.labelCamera);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormScanner";
            this.Text = "FormScanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScanner_FormClosing);
            this.Load += new System.EventHandler(this.FormScanner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelCamera;
        private System.Windows.Forms.ComboBox comboBoxDevice;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonViewDetail;
        private System.Windows.Forms.Label labelViewSid;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button buttonAdminDashboard;
    }
}