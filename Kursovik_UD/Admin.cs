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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                try
                {
                    this.Validate();
                    this.lIKETOWNBindingSource.EndEdit();
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet1.EMPLOYEE". При необходимости она может быть перемещена или удалена.
                    this.lIKE_TOWNTableAdapter.GetData(textBox1.Text);                    
                    dataGridView1.DataSource = taxiDataSet1.LIKE_TOWN;
                    //update datagrid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet1.STATUS_EMPLOYEE". При необходимости она может быть перемещена или удалена.
            this.sTATUS_EMPLOYEETableAdapter.Fill(this.taxiDataSet1.STATUS_EMPLOYEE);
            if (!groupBox1.Visible)
            {
                groupBox2.Location = new Point(12, 27);
                groupBox2.Size = this.Size;
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet1.EMPLOYEE". При необходимости она может быть перемещена или удалена.
            this.eMPLOYEETableAdapter.Fill(this.taxiDataSet1.EMPLOYEE);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void ShowChildForm(Form form)
        {
            form.MdiParent = this.ParentForm;
            form.Show();
        }

        private void статистикаПоВодителямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportConfig form = new ReportConfig(1);
            ShowChildForm(form);
        }


        private void выручкаВодителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportConfig form = new ReportConfig(2);
            ShowChildForm(form);
        }

        private void техосмотрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportConfig form = new ReportConfig(3);
            ShowChildForm(form);
        }

        private void медосмотрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportConfig form = new ReportConfig(4);
            ShowChildForm(form);
        }

        private void dataGridView2_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.eMPLOYEETableAdapter.Update(this.taxiDataSet1);
        }
    }
}
