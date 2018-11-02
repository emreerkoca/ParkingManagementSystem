using ParkingManagementSystem.Helpers;
using ParkingManagementSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        #region Events
        private void defineSubscriberInfoToolStripMenuMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Control control in panel1.Controls)
            //{
            //    control.Dispose();
            //}
            //UserControl1 usercontrol1 = new UserControl1();
            //panel1.Controls.Add(usercontrol1);

            foreach (Control control in panel1.Controls)
            {
                control.Dispose();
            }
            DefinitionSubscriberInfo definitionSubscriberInfo = new DefinitionSubscriberInfo();
            panel1.Controls.Add(definitionSubscriberInfo);
        }
        #endregion

        private void createSubscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
