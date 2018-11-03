namespace ParkingManagementSystem
{
    partial class CarEntryForm
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
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbBoxUsers = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.lblPlate = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.dtPickerEntryDate = new System.Windows.Forms.DateTimePicker();
            this.grpBoxScheduleInfo = new System.Windows.Forms.GroupBox();
            this.lblLastHour = new System.Windows.Forms.Label();
            this.lblFirstHour = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxSchedules = new System.Windows.Forms.ComboBox();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.grpBoxScheduleInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(61, 35);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(49, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Kullanıcı:";
            // 
            // cmbBoxUsers
            // 
            this.cmbBoxUsers.FormattingEnabled = true;
            this.cmbBoxUsers.Location = new System.Drawing.Point(131, 32);
            this.cmbBoxUsers.Name = "cmbBoxUsers";
            this.cmbBoxUsers.Size = new System.Drawing.Size(196, 21);
            this.cmbBoxUsers.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(131, 77);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(196, 20);
            this.txtPlate.TabIndex = 3;
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Location = new System.Drawing.Point(61, 80);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(37, 13);
            this.lblPlate.TabIndex = 4;
            this.lblPlate.Text = "Plaka:";
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.Location = new System.Drawing.Point(39, 117);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(59, 13);
            this.lblEntryDate.TabIndex = 5;
            this.lblEntryDate.Text = "Giriş Tarihi:";
            // 
            // dtPickerEntryDate
            // 
            this.dtPickerEntryDate.Location = new System.Drawing.Point(131, 117);
            this.dtPickerEntryDate.Name = "dtPickerEntryDate";
            this.dtPickerEntryDate.Size = new System.Drawing.Size(196, 20);
            this.dtPickerEntryDate.TabIndex = 6;
            // 
            // grpBoxScheduleInfo
            // 
            this.grpBoxScheduleInfo.Controls.Add(this.lblLastHour);
            this.grpBoxScheduleInfo.Controls.Add(this.lblFirstHour);
            this.grpBoxScheduleInfo.Controls.Add(this.lblPrice);
            this.grpBoxScheduleInfo.Controls.Add(this.label3);
            this.grpBoxScheduleInfo.Controls.Add(this.label2);
            this.grpBoxScheduleInfo.Controls.Add(this.label1);
            this.grpBoxScheduleInfo.Location = new System.Drawing.Point(128, 186);
            this.grpBoxScheduleInfo.Name = "grpBoxScheduleInfo";
            this.grpBoxScheduleInfo.Size = new System.Drawing.Size(200, 144);
            this.grpBoxScheduleInfo.TabIndex = 11;
            this.grpBoxScheduleInfo.TabStop = false;
            this.grpBoxScheduleInfo.Text = "Tarife Bilgileri";
            this.grpBoxScheduleInfo.Visible = false;
            // 
            // lblLastHour
            // 
            this.lblLastHour.AutoSize = true;
            this.lblLastHour.Location = new System.Drawing.Point(85, 90);
            this.lblLastHour.Name = "lblLastHour";
            this.lblLastHour.Size = new System.Drawing.Size(0, 13);
            this.lblLastHour.TabIndex = 5;
            // 
            // lblFirstHour
            // 
            this.lblFirstHour.AutoSize = true;
            this.lblFirstHour.Location = new System.Drawing.Point(85, 60);
            this.lblFirstHour.Name = "lblFirstHour";
            this.lblFirstHour.Size = new System.Drawing.Size(0, 13);
            this.lblFirstHour.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(85, 29);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ücret:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlk Saat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Son Saat:";
            // 
            // cmbBoxSchedules
            // 
            this.cmbBoxSchedules.FormattingEnabled = true;
            this.cmbBoxSchedules.Location = new System.Drawing.Point(131, 158);
            this.cmbBoxSchedules.Name = "cmbBoxSchedules";
            this.cmbBoxSchedules.Size = new System.Drawing.Size(198, 21);
            this.cmbBoxSchedules.TabIndex = 10;
            this.cmbBoxSchedules.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSchedules_SelectedIndexChanged);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(57, 164);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(37, 13);
            this.lblSchedule.TabIndex = 9;
            this.lblSchedule.Text = "Tarife:";
            // 
            // CarEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 377);
            this.Controls.Add(this.grpBoxScheduleInfo);
            this.Controls.Add(this.cmbBoxSchedules);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.dtPickerEntryDate);
            this.Controls.Add(this.lblEntryDate);
            this.Controls.Add(this.lblPlate);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbBoxUsers);
            this.Controls.Add(this.lblUser);
            this.Name = "CarEntryForm";
            this.Text = "CarEntryForm";
            this.grpBoxScheduleInfo.ResumeLayout(false);
            this.grpBoxScheduleInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbBoxUsers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.DateTimePicker dtPickerEntryDate;
        private System.Windows.Forms.GroupBox grpBoxScheduleInfo;
        private System.Windows.Forms.Label lblLastHour;
        private System.Windows.Forms.Label lblFirstHour;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxSchedules;
        private System.Windows.Forms.Label lblSchedule;
    }
}