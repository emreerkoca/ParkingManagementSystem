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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtPickerFirstHour
            // 
            this.dtPickerFirstHour.Location = new System.Drawing.Point(160, 87);
            this.dtPickerFirstHour.Name = "dtPickerFirstHour";
            this.dtPickerFirstHour.Size = new System.Drawing.Size(123, 20);
            this.dtPickerFirstHour.TabIndex = 0;
            // 
            // dtPickerLastHour
            // 
            this.dtPickerLastHour.Location = new System.Drawing.Point(160, 128);
            this.dtPickerLastHour.Name = "dtPickerLastHour";
            this.dtPickerLastHour.Size = new System.Drawing.Size(123, 20);
            this.dtPickerLastHour.TabIndex = 1;
            // 
            // lblFirstHour
            // 
            this.lblFirstHour.AutoSize = true;
            this.lblFirstHour.Location = new System.Drawing.Point(81, 87);
            this.lblFirstHour.Name = "lblFirstHour";
            this.lblFirstHour.Size = new System.Drawing.Size(46, 13);
            this.lblFirstHour.TabIndex = 2;
            this.lblFirstHour.Text = "İlk Saat:";
            // 
            // lblLastHour
            // 
            this.lblLastHour.AutoSize = true;
            this.lblLastHour.Location = new System.Drawing.Point(73, 128);
            this.lblLastHour.Name = "lblLastHour";
            this.lblLastHour.Size = new System.Drawing.Size(54, 13);
            this.lblLastHour.TabIndex = 3;
            this.lblLastHour.Text = "Son Saat:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(91, 173);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Ücret:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(160, 166);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(123, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(208, 206);
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
            this.lblScheduleName.Location = new System.Drawing.Point(81, 58);
            this.lblScheduleName.Name = "lblScheduleName";
            this.lblScheduleName.Size = new System.Drawing.Size(55, 13);
            this.lblScheduleName.TabIndex = 9;
            this.lblScheduleName.Text = "Tarife Adı:";
            // 
            // txtScheduleName
            // 
            this.txtScheduleName.Location = new System.Drawing.Point(160, 55);
            this.txtScheduleName.Name = "txtScheduleName";
            this.txtScheduleName.Size = new System.Drawing.Size(123, 20);
            this.txtScheduleName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(124, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tarife Bilgisi Tanımla";
            // 
            // DefineScheduleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}
