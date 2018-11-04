namespace ParkingManagementSystem
{
    partial class CarParkingOutForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtPickerOutDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.dtPickerEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStayTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çıkış Tarihi:";
            // 
            // dtPickerOutDate
            // 
            this.dtPickerOutDate.Location = new System.Drawing.Point(134, 59);
            this.dtPickerOutDate.Name = "dtPickerOutDate";
            this.dtPickerOutDate.Size = new System.Drawing.Size(200, 20);
            this.dtPickerOutDate.TabIndex = 1;
            this.dtPickerOutDate.ValueChanged += new System.EventHandler(this.dtPickerOutDate_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(259, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ücret:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(134, 127);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(200, 20);
            this.txtTotalPrice.TabIndex = 4;
            // 
            // dtPickerEntryDate
            // 
            this.dtPickerEntryDate.Enabled = false;
            this.dtPickerEntryDate.Location = new System.Drawing.Point(134, 27);
            this.dtPickerEntryDate.Name = "dtPickerEntryDate";
            this.dtPickerEntryDate.Size = new System.Drawing.Size(200, 20);
            this.dtPickerEntryDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giriş Tarihi:";
            // 
            // txtStayTime
            // 
            this.txtStayTime.Location = new System.Drawing.Point(134, 93);
            this.txtStayTime.Name = "txtStayTime";
            this.txtStayTime.ReadOnly = true;
            this.txtStayTime.Size = new System.Drawing.Size(200, 20);
            this.txtStayTime.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Süre(Gün):";
            // 
            // CarParkingOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 351);
            this.Controls.Add(this.txtStayTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPickerEntryDate);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtPickerOutDate);
            this.Controls.Add(this.label1);
            this.Name = "CarParkingOutForm";
            this.Text = "CarParkingOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPickerOutDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.DateTimePicker dtPickerEntryDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStayTime;
        private System.Windows.Forms.Label label4;
    }
}