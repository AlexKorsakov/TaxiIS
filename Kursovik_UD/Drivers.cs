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
    public partial class Drivers : Form
    {
        public int ReturnDriverId { get; set; }
        int DriverIdNumberCell = 0;
        bool fromStatus = false;

        public Drivers()
        {
            InitializeComponent();
        }

        public Drivers(bool status)
        {
            fromStatus = status;
            InitializeComponent();
            this.Text = "Выбрать водителя";
            eMPLOYEEBindingNavigator.Visible = false;
            eMPLOYEEDataGridView.ReadOnly = true;
        }

        private void eMPLOYEEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLOYEEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet1);

        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet1.AVTO". При необходимости она может быть перемещена или удалена.
                this.aVTOTableAdapter.Fill(this.taxiDataSet1.AVTO);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet1.DRIVER_AVTO". При необходимости она может быть перемещена или удалена.
                this.dRIVER_AVTOTableAdapter.Fill(this.taxiDataSet1.DRIVER_AVTO);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet1.EMPLOYEE". При необходимости она может быть перемещена или удалена.
                this.eMPLOYEETableAdapter.Fill(this.taxiDataSet1.EMPLOYEE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void fillByDriverToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eMPLOYEETableAdapter.FillByDriver(this.taxiDataSet1.EMPLOYEE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByDriverToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.eMPLOYEETableAdapter.FillByDriver(this.taxiDataSet1.EMPLOYEE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dRIVER_AVTOTableAdapter.FillBy(this.taxiDataSet1.DRIVER_AVTO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void eMPLOYEEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fromStatus == true)
            {
                //Получение ID водителя
                ReturnDriverId = Convert.ToInt32(eMPLOYEEDataGridView.Rows[e.RowIndex].Cells[DriverIdNumberCell].Value);
                this.Close();
            }
        }
    }
}
