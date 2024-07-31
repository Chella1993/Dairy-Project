namespace group9cmpg
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calenderReturnDate = new System.Windows.Forms.MonthCalendar();
            this.cBReturnReason = new System.Windows.Forms.ComboBox();
            this.txtBoxOrderID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.btnLogReturn = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.lblReturnStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(460, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 188);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calenderReturnDate);
            this.groupBox1.Controls.Add(this.cBReturnReason);
            this.groupBox1.Controls.Add(this.txtBoxOrderID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblOrderID);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 283);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // calenderReturnDate
            // 
            this.calenderReturnDate.Location = new System.Drawing.Point(108, 95);
            this.calenderReturnDate.Name = "calenderReturnDate";
            this.calenderReturnDate.TabIndex = 5;
            this.calenderReturnDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calenderReturnDate_DateChanged);
            // 
            // cBReturnReason
            // 
            this.cBReturnReason.FormattingEnabled = true;
            this.cBReturnReason.Items.AddRange(new object[] {
            "Defective Stock",
            "Incorrect Product",
            "Incorrect Quantity",
            "Other"});
            this.cBReturnReason.Location = new System.Drawing.Point(108, 52);
            this.cBReturnReason.Name = "cBReturnReason";
            this.cBReturnReason.Size = new System.Drawing.Size(121, 21);
            this.cBReturnReason.TabIndex = 4;
            // 
            // txtBoxOrderID
            // 
            this.txtBoxOrderID.Location = new System.Drawing.Point(108, 19);
            this.txtBoxOrderID.Name = "txtBoxOrderID";
            this.txtBoxOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOrderID.TabIndex = 3;
            this.txtBoxOrderID.TextChanged += new System.EventHandler(this.txtBoxOrderID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Return Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Return Reason";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(6, 26);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(47, 13);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Return Status";
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.AutoSize = true;
            this.lblDisclaimer.Location = new System.Drawing.Point(457, 319);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(16, 13);
            this.lblDisclaimer.TabIndex = 4;
            this.lblDisclaimer.Text = "...";
            // 
            // btnLogReturn
            // 
            this.btnLogReturn.Location = new System.Drawing.Point(21, 311);
            this.btnLogReturn.Name = "btnLogReturn";
            this.btnLogReturn.Size = new System.Drawing.Size(108, 28);
            this.btnLogReturn.TabIndex = 5;
            this.btnLogReturn.Text = "Log Return";
            this.btnLogReturn.UseVisualStyleBackColor = true;
            this.btnLogReturn.Click += new System.EventHandler(this.btnLogReturn_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(137, 311);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(113, 28);
            this.btnRetry.TabIndex = 6;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // lblReturnStatus
            // 
            this.lblReturnStatus.AutoSize = true;
            this.lblReturnStatus.Location = new System.Drawing.Point(134, 356);
            this.lblReturnStatus.Name = "lblReturnStatus";
            this.lblReturnStatus.Size = new System.Drawing.Size(16, 13);
            this.lblReturnStatus.TabIndex = 7;
            this.lblReturnStatus.Text = "...";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 392);
            this.Controls.Add(this.lblReturnStatus);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.btnLogReturn);
            this.Controls.Add(this.lblDisclaimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Return";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar calenderReturnDate;
        private System.Windows.Forms.ComboBox cBReturnReason;
        private System.Windows.Forms.TextBox txtBoxOrderID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDisclaimer;
        private System.Windows.Forms.Button btnLogReturn;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Label lblReturnStatus;
    }
}