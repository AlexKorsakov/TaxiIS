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
    public partial class Report_drv_profit : Form
    {

        public Report_drv_profit()
        {
            InitializeComponent();
        }

        public Report_drv_profit(int month, int year)
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "TaxiDataSet.REPORT_DRIVER_PROFIT". При необходимости она может быть перемещена или удалена.
            this.REPORT_DRIVER_PROFITTableAdapter.Fill(this.TaxiDataSet.REPORT_DRIVER_PROFIT, month, year);
            reportViewer1.RefreshReport();
        }

        private void Report_drv_profit_Load(object sender, EventArgs e)
        {
        }
    }
}
