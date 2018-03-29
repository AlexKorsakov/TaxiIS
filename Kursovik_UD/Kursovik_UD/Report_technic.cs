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
    public partial class Report_technic : Form
    {
        public Report_technic()
        {
            InitializeComponent();
        }

        public Report_technic(int month, int year)
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "TaxiDataSet.REPORT_technic". При необходимости она может быть перемещена или удалена.
            this.REPORT_technicTableAdapter.Fill(this.TaxiDataSet.REPORT_technic, month, year);
            reportViewer1.RefreshReport();
        }

        private void Report_technic_Load(object sender, EventArgs e)
        {

        }
    }
}
