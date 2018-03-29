using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursovik_UD
{
    public partial class ReportConfig : Form
    {
        public int Month = DateTime.Now.Month;
        public int Year = DateTime.Now.Year;
        public int Value = 0;

        public ReportConfig(int value)
        {
            InitializeComponent();
            Value = value;
        }

        private void accept_Click(object sender, EventArgs e)
        {
            switch (Value)
            {
                case 1:
                    Report_drv_stats newMDIChild1 = new Report_drv_stats(Month, Year);
                    newMDIChild1.MdiParent = Admin.ActiveForm;
                    newMDIChild1.Show();
                    break;
                case 2:
                    Report_drv_profit newMDIChild2 = new Report_drv_profit(Month, Year);
                    newMDIChild2.MdiParent = Admin.ActiveForm;
                    newMDIChild2.Show();
                    break;
                case 3:
                    Report_technic newMDIChild3 = new Report_technic(Month, Year);
                    newMDIChild3.MdiParent = Admin.ActiveForm;
                    newMDIChild3.Show();
                    break;
                case 4:
                    Report_medic newMDIChild4 = new Report_medic(Month, Year);
                    newMDIChild4.MdiParent = Admin.ActiveForm;
                    newMDIChild4.Show();
                    break;

            }
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Month = dateTimePicker1.Value.Month;
            Year = dateTimePicker1.Value.Year;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
