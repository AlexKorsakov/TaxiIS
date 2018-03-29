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
    public partial class T_AddCar : Form
    {
        public T_AddCar()
        {
            InitializeComponent();
        }

        private void aVTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.aVTOBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.taxiDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления: " + ex.Message);
            }
        }

        private void T_AddCar_Load(object sender, EventArgs e)
        {
            try
            {

                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.AVTO". При необходимости она может быть перемещена или удалена.
                this.aVTOTableAdapter.Fill(this.taxiDataSet.AVTO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка. " + ex.Message);
            }
        }

        private void aVTODataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.aVTOTableAdapter.Update(this.taxiDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка. " + ex.Message);
            }
        }
    }
}
