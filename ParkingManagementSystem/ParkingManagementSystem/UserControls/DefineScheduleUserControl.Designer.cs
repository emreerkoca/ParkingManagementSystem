namespace ParkingManagementSystem.UserControls
{
    partial class DefineScheduleUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtPickerFirstHour = new System.Windows.Forms.DateTimePicker();
            this.dtPickerLastHour = new System.Windows.Forms.DateTimePicker();
            this.lblFirstHour = new System.Windows.Forms.Label();
            this.lblLastHour = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblScheduleName = new System.Windows.Forms.Label();
            this.txtScheduleName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtPickerFirstHour
            // 
            this.dtPickerFirstHour.Location = new System.Drawing.Point(154, 73);
            this.dtPickerFirstHour.Name = "dtPickerFirstHour";
            this.dtPickerFirstHour.Size = new System.Drawing.Size(123, 20);
            this.dtPickerFirstHour.TabIndex = 0;
            // 
            // dtPickerLastHour
            // 
            this.dtPickerLastHour.Location = new System.Drawing.Point(154, 114);
            this.dtPickerLastHour.Name = "dtPickerLastHour";
            this.dtPickerLastHour.Size = new System.Drawing.Size(123, 20);
            this.dtPickerLastHour.TabIndex = 1;
            // 
            // lblFirstHour
            // 
            this.lblFirstHour.AutoSize = true;
            this.lblFirstHour.Location = new System.Drawing.Point(75, 73);
            this.lblFirstHour.Name = "lblFirstHour";
            this.lblFirstHour.Size = new System.Drawing.Size(46, 13);
            this.lblFirstHour.TabIndex = 2;
            this.lblFirstHour.Text = "İlk Saat:";
            // 
            // lblLastHour
            // 
            this.lblLastHour.AutoSize = true;
            this.lblLastHour.Location = new System.Drawing.Point(67, 114);
            this.lblLastHour.Name = "lblLastHour";
            this.lblLastHour.Size = new System.Drawing.Size(54, 13);
            this.lblLastHour.TabIndex = 3;
            this.lblLastHour.Text = "Son Saat:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(85, 159);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Ücret:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(154, 152);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(123, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(202, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblScheduleName
            // 
            this.lblScheduleName.AutoSize = true;
            this.lblScheduleName.Location = new System.Drawing.Point(75, 44);
            this.lblScheduleName.Name = "lblScheduleName";
            this.lblScheduleName.Size = new System.Drawing.Size(55, 13);
            this.lblScheduleName.TabIndex = 9;
            this.lblScheduleName.Text = "Tarife Adı:";
            // 
            // txtScheduleName
            // 
            this.txtScheduleName.Location = new System.Drawing.Point(154, 41);
            this.txtScheduleName.Name = "txtScheduleName";
            this.txtScheduleName.Size = new System.Drawing.Size(123, 20);
            this.txtScheduleName.TabIndex = 10;
            // 
            // DefineScheduleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtScheduleName);
            this.Controls.Add(this.lblScheduleName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblLastHour);
            this.Controls.Add(this.lblFirstHour);
            this.Controls.Add(this.dtPickerLastHour);
            this.Controls.Add(this.dtPickerFirstHour);
            this.Name = "DefineScheduleUserControl";
            this.Size = new System.Drawing.Size(431, 386);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPickerFirstHour;
        private System.Windows.Forms.DateTimePicker dtPickerLastHour;
        private System.Windows.Forms.Label lblFirstHour;
        private System.Windows.Forms.Label lblLastHour;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblScheduleName;
        private System.Windows.Forms.TextBox txtScheduleName;
    }
}
