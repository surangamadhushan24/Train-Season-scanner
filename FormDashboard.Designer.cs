namespace ScanerProject
{
    partial class FormDashboard
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
            this.labelDetail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonDestination = new System.Windows.Forms.Button();
            this.labelSid = new System.Windows.Forms.Label();
            this.labelDid = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxDid = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.labelDetail);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 69);
            this.panel1.TabIndex = 1;
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.BackColor = System.Drawing.Color.Navy;
            this.labelDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetail.ForeColor = System.Drawing.Color.White;
            this.labelDetail.Location = new System.Drawing.Point(207, 17);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(356, 38);
            this.labelDetail.TabIndex = 8;
            this.labelDetail.Text = "ADMIN DASHBOARD";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(860, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(37, 137);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(691, 176);
            this.dataGridView.TabIndex = 2;
            // 
            // buttonDestination
            // 
            this.buttonDestination.BackColor = System.Drawing.Color.Navy;
            this.buttonDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDestination.ForeColor = System.Drawing.Color.White;
            this.buttonDestination.Location = new System.Drawing.Point(37, 92);
            this.buttonDestination.Name = "buttonDestination";
            this.buttonDestination.Size = new System.Drawing.Size(159, 39);
            this.buttonDestination.TabIndex = 3;
            this.buttonDestination.Text = "Destination";
            this.buttonDestination.UseVisualStyleBackColor = false;
            this.buttonDestination.Click += new System.EventHandler(this.buttonDestination_Click);
            // 
            // labelSid
            // 
            this.labelSid.AutoSize = true;
            this.labelSid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSid.ForeColor = System.Drawing.Color.Navy;
            this.labelSid.Location = new System.Drawing.Point(42, 343);
            this.labelSid.Name = "labelSid";
            this.labelSid.Size = new System.Drawing.Size(176, 25);
            this.labelSid.TabIndex = 4;
            this.labelSid.Text = "Add Destinations";
            // 
            // labelDid
            // 
            this.labelDid.AutoSize = true;
            this.labelDid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDid.ForeColor = System.Drawing.Color.Navy;
            this.labelDid.Location = new System.Drawing.Point(51, 390);
            this.labelDid.Name = "labelDid";
            this.labelDid.Size = new System.Drawing.Size(44, 25);
            this.labelDid.TabIndex = 5;
            this.labelDid.Text = "Did";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.ForeColor = System.Drawing.Color.Navy;
            this.labelDestination.Location = new System.Drawing.Point(178, 390);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(120, 25);
            this.labelDestination.TabIndex = 6;
            this.labelDestination.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(648, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 7;
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistance.ForeColor = System.Drawing.Color.Navy;
            this.labelDistance.Location = new System.Drawing.Point(365, 390);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(96, 25);
            this.labelDistance.TabIndex = 8;
            this.labelDistance.Text = "Distance";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Navy;
            this.labelPrice.Location = new System.Drawing.Point(528, 390);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(61, 25);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Price";
            // 
            // textBoxDid
            // 
            this.textBoxDid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDid.ForeColor = System.Drawing.Color.Navy;
            this.textBoxDid.Location = new System.Drawing.Point(37, 433);
            this.textBoxDid.Name = "textBoxDid";
            this.textBoxDid.Size = new System.Drawing.Size(100, 27);
            this.textBoxDid.TabIndex = 10;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDestination.ForeColor = System.Drawing.Color.Navy;
            this.textBoxDestination.Location = new System.Drawing.Point(183, 433);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(100, 27);
            this.textBoxDestination.TabIndex = 11;
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDistance.ForeColor = System.Drawing.Color.Navy;
            this.textBoxDistance.Location = new System.Drawing.Point(361, 433);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 27);
            this.textBoxDistance.TabIndex = 12;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.ForeColor = System.Drawing.Color.Navy;
            this.textBoxPrice.Location = new System.Drawing.Point(533, 433);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 27);
            this.textBoxPrice.TabIndex = 13;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Navy;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(714, 410);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(145, 50);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 483);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.textBoxDid);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelDid);
            this.Controls.Add(this.labelSid);
            this.Controls.Add(this.buttonDestination);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDestination;
        private System.Windows.Forms.Label labelSid;
        private System.Windows.Forms.Label labelDid;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxDid;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAdd;
    }
}