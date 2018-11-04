namespace ParkingManagementSystem.UserControls
{
    partial class CarParkingUserControl
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
            this.components = new System.ComponentModel.Container();
            this.carParkingMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.carParkingEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carParkingOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.carParkingMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // carParkingMenuStrip
            // 
            this.carParkingMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carParkingEntryToolStripMenuItem,
            this.carParkingOutToolStripMenuItem});
            this.carParkingMenuStrip.Name = "carParkingMenuStrip";
            this.carParkingMenuStrip.Size = new System.Drawing.Size(223, 48);
            // 
            // carParkingEntryToolStripMenuItem
            // 
            this.carParkingEntryToolStripMenuItem.Name = "carParkingEntryToolStripMenuItem";
            this.carParkingEntryToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.carParkingEntryToolStripMenuItem.Text = "Araç Girişi";
            this.carParkingEntryToolStripMenuItem.Click += new System.EventHandler(this.carParkingEntryToolStripMenuItem_Click);
            // 
            // carParkingOutToolStripMenuItem
            // 
            this.carParkingOutToolStripMenuItem.Name = "carParkingOutToolStripMenuItem";
            this.carParkingOutToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.carParkingOutToolStripMenuItem.Text = "Araç Çıkışı ve Ücretlendirme";
            this.carParkingOutToolStripMenuItem.Click += new System.EventHandler(this.carParkingOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(231, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otopark Düzeni";
            // 
            // CarParkingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Name = "CarParkingUserControl";
            this.Size = new System.Drawing.Size(648, 517);
            this.carParkingMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip carParkingMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem carParkingEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carParkingOutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}
