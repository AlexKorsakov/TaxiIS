using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Kursovik_UD
{
    public partial class Operator : Form
    {
        public int ColNum;          //Текущий столбец
        public int RowNum;          //Текущая строка
        public bool IsLoaded = false;
        string PreviousFilter = "";
        int SearchCounter = 0;      //Счетчик поиска

        int columnChange = 1;       //колонка "Изменить"
        int columnDriver = 2;       //колонка "Водитель"
        int columnStatus = 3;       //колонка "статус"
        int columnEnding = 15;      //колонка "Выполнить"

        int LastStatus = 0;

        public Operator()
        {
            InitializeComponent();
        }

        private void Operator_Load_1(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.STREETS". При необходимости она может быть перемещена или удалена.
                this.sTREETSTableAdapter.Fill(this.taxiDataSet.STREETS);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.REGION". При необходимости она может быть перемещена или удалена.
                this.rEGIONTableAdapter.Fill(this.taxiDataSet.REGION);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.GET_DRIVERS". При необходимости она может быть перемещена или удалена.
                this.gET_DRIVERSTableAdapter.Fill(this.taxiDataSet.GET_DRIVERS);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.STATUS_ZAYAVKI". При необходимости она может быть перемещена или удалена.
                this.sTATUS_ZAYAVKITableAdapter.Fill(this.taxiDataSet.STATUS_ZAYAVKI);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.TARIF". При необходимости она может быть перемещена или удалена.
                //this.tARIFTableAdapter.Fill(this.taxiDataSet.TARIF);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.EMPLOYEE". При необходимости она может быть перемещена или удалена.
                this.eMPLOYEETableAdapter.FillByDriversOnly(this.taxiDataSet.EMPLOYEE);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.ZAYAVKA". При необходимости она может быть перемещена или удалена.
                this.zAYAVKATableAdapter.Fill(this.taxiDataSet.ZAYAVKA);
                //this.zAYAVKABindingSource.Filter = "TIME_CREATE LIMIT 10;";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста авторизуйтесь. \r\n" + ex.Message);
            }
            checkBox1.Checked = true;

            colsNames.AutoCompleteMode = AutoCompleteMode.SuggestAppend;            //Автозаполнение
            colsNames.AutoCompleteSource = AutoCompleteSource.CustomSource;

            /*
            DataTable comboBoxItems = new DataTable();
            comboBoxItems.Columns.Add("Display");
            comboBoxItems.Columns.Add("Value");
            foreach (DataGridViewColumn rowArray in RequestList.Columns)            //Добавление имен столбцов со значениями в выпадающий список
            {
                System.String s = "";
                if (!rowArray.Visible || rowArray.Index == columnChange || rowArray.Index == columnEnding || !ValueType.Equals(s, rowArray.ValueType))
                    continue;

                DataRow itemRow = comboBoxItems.NewRow();
                itemRow["Display"] = rowArray.HeaderText;
                itemRow["Value"] = rowArray.DataPropertyName;
                comboBoxItems.Rows.Add(itemRow);
                colsNames.Items.Insert(1, rowArray.HeaderText);
            }
            colsNames.DisplayMember = "Display";
            colsNames.ValueMember = "Value";
            colsNames.DataSource = comboBoxItems;
            */

            IsLoaded = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void RefreshGrid()
        {
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);
            this.zAYAVKATableAdapter.Fill(this.taxiDataSet.ZAYAVKA);
        }

        private void taxiDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        #region Перехват нажатий на контролы грида
        private void RequestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RowNum = e.RowIndex;
            ColNum = e.ColumnIndex;
            if (e.ColumnIndex == columnChange)     //нажато "изменить"
            {
                int kol = e.RowIndex;
                try
                {
                    //Далее идет открытие формы "Создание заявки" с заданными полями
                    int driver_id = 0;
                    string str = RequestList.Rows[kol].Cells[2].Value.ToString();
                    if (RequestList.Rows[kol].Cells[2].Value.ToString() != "")
                    {
                        driver_id = Convert.ToInt32(RequestList.Rows[kol].Cells[2].Value);
                    }
                    else
                    {
                        driver_id = 2;
                    }
                    CreateRequest newMdiChild = new CreateRequest(
                        Convert.ToInt32(RequestList.Rows[kol].Cells[0].Value),
                        driver_id,
                        Convert.ToInt32(RequestList.Rows[kol].Cells[5].Value),
                        RequestList.Rows[kol].Cells[7].Value.ToString(),
                        RequestList.Rows[kol].Cells[8].Value.ToString(),
                        RequestList.Rows[kol].Cells[9].Value.ToString(),
                        RequestList.Rows[kol].Cells[10].Value.ToString(),
                        RequestList.Rows[kol].Cells[11].Value.ToString(),
                        RequestList.Rows[kol].Cells[12].Value.ToString(),
                        RequestList.Rows[kol].Cells[13].Value.ToString(),
                        RequestList.Rows[kol].Cells[6].Value.ToString());
                    newMdiChild.ShowDialog();
                    RefreshGrid();


                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }


            if (e.ColumnIndex == columnEnding)     //нажато "Выполнить"
            {
                try
                {
                    var result = MessageBox.Show("Заявка выполнена?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        RequestList.Rows[RowNum].Cells[columnStatus].Value = 3;
                        this.Validate();
                        this.zAYAVKABindingSource.EndEdit();
                        RefreshGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ended failed: " + ex.Message);
                }
            }
        }
        #endregion

        private void CreateRequest_Click(object sender, EventArgs e)
        {
        }


        private void getRequestToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.taxiDataSet.HasChanges())
                try
                {
                    this.Validate();
                    this.zAYAVKABindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.taxiDataSet);
                    this.zAYAVKATableAdapter.Fill(this.taxiDataSet.ZAYAVKA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save error: \r\n" + ex.Message);
                }
        }

        private static void _dt_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            MessageBox.Show("oops");

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*Обновить датагрид

            this.tableAdapterManager.UpdateAll(this.taxiDataSet);
            this.zAYAVKATableAdapter.Fill(this.taxiDataSet.ZAYAVKA);*/
        }

        #region Фильтрация
        /// <summary>
        /// Фильтрация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (RequestList.DataSource == zAYAVKABindingSource)
            {
                checkBox1.Checked = false;
                zAYAVKABindingSource.Filter = "[TIME_CREATE] >= '" + dateTimePicker1.Value.ToShortDateString() + "' AND [TIME_CREATE] <= '" + dateTimePicker2.Value.ToShortDateString() + "'";
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (RequestList.DataSource == zAYAVKABindingSource)
            {
                checkBox1.Checked = false;
                zAYAVKABindingSource.Filter = "[TIME_CREATE] >= '" + dateTimePicker1.Value.ToShortDateString() + "' AND [TIME_CREATE] <= '" + dateTimePicker2.Value.ToShortDateString() + "'";
            }
        }

        private void filterRows_TextChanged(object sender, EventArgs e)
        {
            try
            {
                zAYAVKABindingSource.Filter = "[" + colsNames.SelectedValue + "] LIKE'" + filterRows.Text + "%'";
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        #endregion

        private void RequestList_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void colsNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //////////////////////////old
        //Изменение статуса заявки
        private void sTATUSZAYAVKIBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (this.IsLoaded && RequestList.Rows[RowNum].Cells[columnStatus].Value.ToString() == "2")
            {
                try
                {
                    RequestList.Rows[RowNum].Cells[columnStatus].Value = LastStatus;
                    throw new System.ArgumentException("Невозможно поменять статус, так как водитель не был назначен");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка №23: " + ex.Message);
                }
            }
            if (this.IsLoaded && RequestList.Rows[RowNum].Cells[columnDriver].Value == null) //&& sTATUSDataGridViewTextBoxColumn.Items[RowNum] == ""
            {
                Drivers formDrv = new Drivers(true);
                formDrv.ShowDialog();
                //выбранное значение комбобокса = номеру водителя, полученного из формы
                //iDDRIVERDataGridViewTextBoxColumn.DataGridView.Rows[RowNum].Cells[2].Value = formDrv.ReturnDriverId;
                try
                {
                    //////////////////////////////////////////
                    //выбранное значение комбобокса = номеру водителя, полученного из формы
                    RequestList.Rows[RowNum].Cells[2].Value = formDrv.ReturnDriverId;
                    iDDRIVERDataGridViewTextBoxColumn.Items[RowNum] = formDrv.ReturnDriverId.ToString();

                    if (formDrv.ReturnDriverId > 0)
                    {
                        iDDRIVERDataGridViewTextBoxColumn.DataGridView.Rows[RowNum].Cells[2].Value = formDrv.ReturnDriverId;
                        //iDDRIVERDataGridViewTextBoxColumn.Items[RowNum] = formDrv.ReturnDriverId.ToString();
                    }
                    else
                    {

                        iDDRIVERDataGridViewTextBoxColumn.Items[RowNum] = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RequestList_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //Сохранение изменений
            /*
            if (this.taxiDataSet.HasChanges())
                try
                {
                    this.Validate();
                    this.zAYAVKABindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.taxiDataSet);
                    this.zAYAVKATableAdapter.Fill(this.taxiDataSet.ZAYAVKA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save error: \r\n" + ex.Message);
                }
            */
            if (IsLoaded && this.taxiDataSet.HasChanges())          //При переходе со строки сохранение
                try
                {
                    this.zAYAVKATableAdapter.Update(this.taxiDataSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save error: \r\n" + ex.Message);
                }
        }


        //Перехват клавиш
        private void RequestList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)        //Нажат Enter
            {
                CreateRequest form = new CreateRequest();
                ShowChildForm(form);
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)        //Нажат Ctrl + R
            {
                RefreshGrid();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                PreviousFilter = this.zAYAVKABindingSource.Filter;
                this.zAYAVKABindingSource.Filter = "[STATUS] < '" + 3 + "'";
            }
            else
            {
                this.zAYAVKABindingSource.Filter = PreviousFilter;
            }
        }

        private void умолчанияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Operator_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*Обновить датагрид*/
            try
            {
                this.tableAdapterManager.UpdateAll(this.taxiDataSet);
                this.zAYAVKATableAdapter.Fill(this.taxiDataSet.ZAYAVKA);
                RequestList.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления: " + ex.Message);
            }
        }

        private void toolStripRefresh_Click(object sender, EventArgs e)
        {
            //Обновить датагрид
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);
            this.zAYAVKATableAdapter.Fill(this.taxiDataSet.ZAYAVKA);
            //zAYAVKABindingSource.Filter = "";
            //checkBox1.Checked = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {

                iDDRIVERDataGridViewTextBoxColumn.DataGridView.Rows[RowNum].Cells[columnStatus].Value = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filterbutton_Click(object sender, EventArgs e)
        {
            // Фильтрация
            //Convert.ToInt32(RequestList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            /*

            CustomFilter filter = new CustomFilter(
                new FilterPair("ID_DRIVER", Convert.ToInt32(driverfilter.Text).ToString())
                );
            this.zAYAVKABindingSource.Filter = filter.createFilter();
            */
        }

        #region Открытие форм
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        void ShowChildForm(Form form)
        {
            form.MdiParent = this.ParentForm;
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CreateRequest newMdiChild = new CreateRequest();
            ShowChildForm(newMdiChild);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Drivers form = new Drivers();
            ShowChildForm(form);
        }

        private void улицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Streets form = new Streets();
            ShowChildForm(form);
        }

        private void тарифыToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Tarifs form = new Tarifs();
            ShowChildForm(form);
        }

        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drivers form = new Drivers();
            ShowChildForm(form);
        }
        #endregion

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportConfig form = new ReportConfig();
            //ShowChildForm(form);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            zAYAVKABindingSource.Filter = "";
        }
    }
}
