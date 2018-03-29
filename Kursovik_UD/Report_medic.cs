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
    public partial class Report_medic : Form
    {
        public Report_medic()
        {
            InitializeComponent();
        }

        public Report_medic(int month, int year)
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "TaxiDataSet.REPORT_medic". При необходимости она может быть перемещена или удалена.
            this.REPORT_medicTableAdapter.Fill(this.TaxiDataSet.REPORT_medic, month, year);
            reportViewer1.RefreshReport();
        }

        private void Report_medic_Load(object sender, EventArgs e)
        {

        }
    }
}
