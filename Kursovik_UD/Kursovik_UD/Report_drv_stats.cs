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
    public partial class Report_drv_stats : Form
    {
        public Report_drv_stats()
        {
            InitializeComponent();
        }

        public Report_drv_stats(int month, int year)
        {
            InitializeComponent();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "TaxiDataSet.REPORT_DRIVER_STATS". При необходимости она может быть перемещена или удалена.
            this.REPORT_DRIVER_STATSTableAdapter.Fill(this.TaxiDataSet.REPORT_DRIVER_STATS, month, year);
            reportViewer1.RefreshReport();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            /*
            // TODO: данная строка кода позволяет загрузить данные в таблицу "TaxiDataSet.REPORT_DRIVERS_ZAYAVKI". При необходимости она может быть перемещена или удалена.
            this.REPORT_DRIVERS_ZAYAVKITableAdapter.Fill(this.TaxiDataSet.REPORT_DRIVERS_ZAYAVKI);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "TaxiDataSet.REPORT_DRIVERS". При необходимости она может быть перемещена или удалена.
            this.REPORT_DRIVERSTableAdapter.Fill(this.TaxiDataSet.REPORT_DRIVERS);
            this.reportViewer1.RefreshReport();
            */
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //REPORT_DRIVER_STATSBindingSource.Filter = "[TIME_CREATE] >= '" + dateTimePicker1.Value.ToShortDateString() + "' AND [TIME_CREATE] <= '" + dateTimePicker2.Value.ToShortDateString() + "'";
            //this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //REPORT_DRIVER_STATSBindingSource.Filter = "[TIME_CREATE] >= '" + dateTimePicker1.Value.ToShortDateString() + "' AND [TIME_CREATE] <= '" + dateTimePicker2.Value.ToShortDateString() + "'";
            //this.reportViewer1.RefreshReport();
        }

    }
}
