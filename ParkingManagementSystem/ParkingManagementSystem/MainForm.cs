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
        #region Ctor
        public MainForm()
        {
            InitializeComponent();
        } 
        #endregion

        #region Events
        private void defineSubscriberInfoToolStripMenuMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            DefinitionSubscriberInfoUserControl definitionSubscriberInfo = new DefinitionSubscriberInfoUserControl();
            pnlMain.Controls.Add(definitionSubscriberInfo);
        }

        private void createSubscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            CreateSubscriptionsUserControl createSubscriptions = new CreateSubscriptionsUserControl();
            pnlMain.Controls.Add(createSubscriptions);

        }

        private void defineScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            DefineScheduleUserControl defineSchedule = new DefineScheduleUserControl();
            pnlMain.Controls.Add(defineSchedule);
        }

        private void insertParkingEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshParkingAreas();
        }
        #endregion

        #region Methods
        void ClearPanel()
        {
            foreach (Control control in pnlMain.Controls)
            {
                control.Dispose();
            }
        }

        public void RefreshParkingAreas()
        {
            ClearPanel();
            CarParkingUserControl carParkingUserControl = new CarParkingUserControl();
            pnlMain.Controls.Add(carParkingUserControl);
        }
        #endregion
    }
}
