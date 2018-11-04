using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingManagementSystem.BLL;

namespace ParkingManagementSystem.UserControls
{
    public partial class CarParkingUserControl : UserControl
    {
        #region Fields
        int locationInfo;
        List<int> locationInfoList;
        #endregion
        #region Ctor
        public CarParkingUserControl()
        {
            InitializeComponent();
            locationInfoList = GetLocationInfoList();
            CreateCarParkingAreas();

        }
        #endregion
        #region Events
        void ButtonClick(object sender, EventArgs e)
        {
            //MessageBox.Show((sender as Button).Name.ToString());
            locationInfo = Convert.ToInt32((sender as Button).Name);
            if (locationInfoList.Contains(locationInfo))
            {
                carParkingEntryToolStripMenuItem.Visible = false;
                carParkingOutToolStripMenuItem.Visible = true;

            }
            else
            {
                carParkingEntryToolStripMenuItem.Visible = true;
                carParkingOutToolStripMenuItem.Visible = false;
            }
            carParkingMenuStrip.Show((sender as Button), new Point(0, (sender as Button).Height));

        }

        private void carParkingEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarParkingEntryForm carParkingEntryForm = new CarParkingEntryForm();
            carParkingEntryForm.FormClosed += new FormClosedEventHandler(Form_Closed);
            carParkingEntryForm.locationInfo = locationInfo;
            carParkingEntryForm.Show();
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Form mainForm = Application.OpenForms["MainForm"];
            ((MainForm)mainForm).RefreshParkingAreas();
        }

        private void carParkingOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarParkingOutForm carParkingOutForm = new CarParkingOutForm();
            carParkingOutForm.FormClosed += new FormClosedEventHandler(Form_Closed);
            carParkingOutForm.GetCarParkingInfo(locationInfo);
            //carParkingOutForm.locationInfo = locationInfo;
            carParkingOutForm.Show();
        }
        #endregion
        #region Methods
        void CreateCarParkingAreas()
        {
            int x = 50;
            int y = 50;


            for (int i = 1; i <= 40; i++)
            {
                Button button = new Button();
                button.Left = x;
                button.Top = y;
                button.Width = 100;
                button.Height = 40;
                button.BackColor = Color.Green;
                button.ForeColor = Color.White;

                button.Text = "P - " + i.ToString();
                button.Name = i.ToString();
                button.ContextMenuStrip = carParkingMenuStrip;
                if (locationInfoList.Contains(i))
                {
                    button.BackColor = Color.Red;
                }
                button.Click += new EventHandler(ButtonClick);
                this.Controls.Add(button);
                x += button.Width + 10;
                if (i % 5 == 0)
                {
                    y += button.Height + 10;
                    x = 50;
                }
            }
        }

        public List<int> GetLocationInfoList()
        {
            ParkingManagementBLL parkingManagementBLL = new ParkingManagementBLL();
            return parkingManagementBLL.GetLocationInfoList();
        }
        #endregion
    }

}
