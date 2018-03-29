using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Kursovik_UD
{
    public partial class Technic : Form
    {
        public Technic()
        {
            InitializeComponent();
        }

        private void tEHOSMOTRBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tEHOSMOTRBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.taxiDataSet);
            }
            catch
            {
            }
        }

        private void Technic_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet1.TEHOSMOTR". При необходимости она может быть перемещена или удалена.
                this.tEHOSMOTRTableAdapter.Fill(this.taxiDataSet1.TEHOSMOTR);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet1.STATUS_TO". При необходимости она может быть перемещена или удалена.
                this.sTATUS_TOTableAdapter.Fill(this.taxiDataSet1.STATUS_TO);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet1.EMPLOYEE". При необходимости она может быть перемещена или удалена.
                this.eMPLOYEETableAdapter.Fill(this.taxiDataSet1.EMPLOYEE);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet1.AVTO". При необходимости она может быть перемещена или удалена.
                this.aVTOTableAdapter.Fill(this.taxiDataSet1.AVTO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выгрузки: \r\n" + ex.Message);
            }
        }

        private void carInfo_Click(object sender, EventArgs e)
        {
            T_AddCar newChild = new T_AddCar();
            ShowChildForm(newChild);
        }

        void ShowChildForm(Form form)
        {
            form.MdiParent = this.ParentForm;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            T_NewTO form = new T_NewTO();
            ShowChildForm(form);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            T_carInfo newChild = new T_carInfo();
            ShowChildForm(newChild);
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            /*
            this.tEHOSMOTRTableAdapter.Update(this.taxiDataSet);
            this.tEHOSMOTRTableAdapter.Fill(this.taxiDataSet.TEHOSMOTR);
            FbCommand myCommand = new FbCommand();
            myCommand.Connection = tEHOSMOTRTableAdapter.Connection;
            myCommand.CommandText =
            "UPDATE TEHOSMOTR SET STATUS = @NEW_STATUS WHERE ID = @ID_ROW";
            int id = Convert.ToInt32( this.dataGridView1.SelectedRows[e.RowIndex].Cells[0].Value);
            myCommand.Parameters.Add("@ID_ROW", id);
            //myCommand.Parameters.Add("@NEW_STATUS", comboBox1.SelectedValue);

            myCommand.Connection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();
            myCommand.Dispose();
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
