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
    public partial class T_carInfo : Form
    {
        public T_carInfo()
        {
            InitializeComponent();
        }

        private void T_AddService_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.EMPLOYEE". При необходимости она может быть перемещена или удалена.
                this.eMPLOYEETableAdapter.Fill(this.taxiDataSet.EMPLOYEE);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.DRIVER_AVTO". При необходимости она может быть перемещена или удалена.
                this.dRIVER_AVTOTableAdapter.Fill(this.taxiDataSet.DRIVER_AVTO);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.AVTO". При необходимости она может быть перемещена или удалена.
                this.aVTOTableAdapter.Fill(this.taxiDataSet.AVTO);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             FbCommand command = new FbCommand();
            command.Connection = grafiK_DEJURSTVATableAdapter1.Connection;
            command.Connection.Open();
            command.CommandText = "select next value for gen_grafik_dejurstva_id from rdb$database";
            FbCommandBuilder fbcommandbuild = new FbCommandBuilder(grafiK_DEJURSTVATableAdapter1.Adapter);
            //договор

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                DataRow t2 = dataSet1.Tables["GRAFIK_DEJURSTVA"].NewRow();
                t2["ID_SOTRUDNIKA"] = dataGridView1[0, i].Value;
                t2["VREMYA_NACHALA_RABOTI"] = dataGridView1[1, i].Value;
                t2["DATA_NACHALA"] = dataGridView1[2, i].Value;
                t2["VREMYA_OKONCHANIYA_RABOTI"] = dataGridView1[3, i].Value;
                t2["DATA_OKONCHANIYA"] = dataGridView1[4, i].Value;
                t2["ID_GRAFIK"] = int.Parse(command.ExecuteScalar().ToString());
                dataSet1.Tables["GRAFIK_DEJURSTVA"].Rows.Add(t2);
                grafiK_DEJURSTVATableAdapter1.Adapter.Update(dataSet1, "GRAFIK_DEJURSTVA");
                this.grafiK_DEJURSTVATableAdapter1.Fill(this.dataSet1.GRAFIK_DEJURSTVA);
            } 
             
             */
        }

        private void addCar_Click(object sender, EventArgs e)           //Добавление авто
        {
            T_AddCar newChildform = new T_AddCar();
            newChildform.MdiParent = this.ParentForm;
            newChildform.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void dRIVER_AVTODataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            dRIVER_AVTOTableAdapter.Update(this.taxiDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
