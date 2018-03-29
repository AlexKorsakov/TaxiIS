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
    public partial class MedicInspection : Form
    {
        public bool Success = true;
        public bool Closing = false;
        public MedicInspection()
        {
            InitializeComponent();
        }

        private void eMPLOYEEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLOYEEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);

        }

        private void MedicInspection_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.STATUS_MEDOSMOTRA". При необходимости она может быть перемещена или удалена.
            this.sTATUS_MEDOSMOTRATableAdapter.Fill(this.taxiDataSet.STATUS_MEDOSMOTRA);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.EMPLOYEE". При необходимости она может быть перемещена или удалена.
            this.eMPLOYEETableAdapter.FillByDriversOnly(this.taxiDataSet.EMPLOYEE);
            //this.eMPLOYEEDataGridView.
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                foreach (DataGridViewRow row in eMPLOYEEDataGridView.Rows)
                {
                    row.Cells[4].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in eMPLOYEEDataGridView.Rows)
                {
                    row.Cells[4].Value = false;
                }
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (DataGridViewRow row in eMPLOYEEDataGridView.Rows)
            {
                if (counter == eMPLOYEEDataGridView.Rows.Count - 1)
                    break;
                FbCommand cmd = new FbCommand("insert into MEDOSMOTR(ID, ID_EMPLOYEE, DESCRIPTION, DATE_OSMOTR, ID_STATUS) "
                + "values (@id, @id_emp, @description, @date_osmotr, @id_status);");
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", -1);
                cmd.Parameters.Add("@id_emp", row.Cells[0].Value);
                if (row.Cells[3].Value == null)
                    cmd.Parameters.Add("@description", "");
                else
                    cmd.Parameters.Add("@description", row.Cells[3].Value.ToString());     
                    
                cmd.Parameters.Add("@date_osmotr", DateTime.Today);
                bool bChecked = (null != row.Cells[4] && null != row.Cells[4].Value && true == (bool)row.Cells[4].Value);
                if (bChecked)
                    cmd.Parameters.Add("@id_status", 1);
                else 
                    cmd.Parameters.Add("@id_status", 2);

                using (cmd.Connection = new FbConnection(Properties.Settings.Default.TaxiConnectionString))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                    }
                    catch(Exception ex)
                    {
                        Success = false;
                        MessageBox.Show(ex.Message);
                    }
                }
                counter++;
            }
            Closing = true;
            this.Close();
        }

        private void fillByDriversOnlyToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eMPLOYEETableAdapter.FillByDriversOnly(this.taxiDataSet.EMPLOYEE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByDriversOnlyToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.eMPLOYEETableAdapter.FillByDriversOnly(this.taxiDataSet.EMPLOYEE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByDriversOnlyToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.eMPLOYEETableAdapter.FillByDriversOnly(this.taxiDataSet.EMPLOYEE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
