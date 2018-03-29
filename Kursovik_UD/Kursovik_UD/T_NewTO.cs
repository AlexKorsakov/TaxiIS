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
    public partial class T_NewTO : Form
    {
        public T_NewTO()
        {
            InitializeComponent();
        }

        private void T_NewTO_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.STATUS_TO". При необходимости она может быть перемещена или удалена.
            this.sTATUS_TOTableAdapter.Fill(this.taxiDataSet.STATUS_TO);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.AVTO". При необходимости она может быть перемещена или удалена.
            this.aVTOTableAdapter.Fill(this.taxiDataSet.AVTO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand myCommand = new FbCommand("INSERT INTO TEHOSMOTR (ID_AVTO, DESCRIPTION, ID_STATUS)"
                + "VALUES (@AVTO, @DESC, @STATUS);", tehosmotrTableAdapter.Connection);
                myCommand.Parameters.Add("@AVTO", comboBox1.SelectedValue);
                myCommand.Parameters.Add("@DESC", textBox1.Text);
                myCommand.Parameters.Add("@STATUS", comboBox3.SelectedValue);

                myCommand.Connection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            MessageBox.Show("Успешно!");
            this.Close();
        }
    }
}
