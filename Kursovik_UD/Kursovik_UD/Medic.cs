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
    public partial class Medic : Form
    {
        public Medic()
        {
            InitializeComponent();
        }

        private void Medic_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet1.STATUS_MEDOSMOTRA". При необходимости она может быть перемещена или удалена.
                this.sTATUS_MEDOSMOTRATableAdapter.Fill(this.taxiDataSet1.STATUS_MEDOSMOTRA);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet1.EMPLOYEE". При необходимости она может быть перемещена или удалена.
                this.eMPLOYEETableAdapter.Fill(this.taxiDataSet1.EMPLOYEE);
                this.tableAdapterManager.UpdateAll(this.taxiDataSet1);
                this.medosmotrTableAdapter.Fill(this.taxiDataSet1.MEDOSMOTR);
                this.checkToday.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.mEDOSMOTRBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.taxiDataSet1);
                this.medosmotrTableAdapter.Fill(this.taxiDataSet1.MEDOSMOTR);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save error: \r\n" + ex.Message);
            }
        }

        private void checkToday_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkToday.Checked == true)
            {
                this.mEDOSMOTRBindingSource.Filter = "[DATE_OSMOTR] >= '" + DateTime.Today + "'";
            }
            else
            {
                this.mEDOSMOTRBindingSource.Filter = null;
            }
        }

        private void buttonNewInspection_Click(object sender, EventArgs e)
        {
            MedicInspection newMdiChild = new MedicInspection();      //Окрытие интерфейса оператора
            ShowChildForm(newMdiChild);

            /////////////
            if (newMdiChild.Closing)
            {
                Medic_Load(sender, e); 
            }
        }

        void ShowChildForm(Form form)
        {
            form.MdiParent = this.ParentForm;
            form.Show();
        }
    }
}
