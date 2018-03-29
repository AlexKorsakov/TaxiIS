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
    public partial class CreateRequest : Form
    {
        bool PickerChanged = false;             //Определяет какую дату писать
        bool Updating = false;
        bool Cancelling = false;

        int ID;
        int Driver;
        int Passangers;
        string TownFrom;
        string TownTo;
        string StreetFrom;
        string StreetTo;
        string HouseFrom;
        string HouseTo;
        string Date;
        string Description;


        public CreateRequest()
        {
            InitializeComponent();
            //taxiDataSet.ZAYAVKA.ID_OPERATORColumn.AllowDBNull = true;             //Этим займется триггер
            taxiDataSet.ZAYAVKA.TIME_CREATEColumn.AllowDBNull = true;               //Этим займется триггер
            button3.Visible = false;
            button1.Size = new Size(this.Width - 44, button1.Height);
        }

        public CreateRequest(int id, int driver, int passangers, string town_from, string street_from, string house_from,
            string town_to, string street_to, string house_to, string date, string description)
        {
            InitializeComponent();

            ID = id;
            Driver = driver;
            Passangers = passangers;
            TownFrom = town_from;
            TownTo = town_to;
            StreetFrom = street_from;
            StreetTo = street_to;
            HouseFrom = house_from;
            HouseTo = house_to;
            Date = date;
            Description = description;
            Updating = true;
            checkBox1.Checked = false;

            this.Text = "Изменить заявку";
        }

        public void BindData()
        {

            try
            {
                if (Driver != 0)
                    comboBox1.SelectedValue = Driver;
                numericUpDown1.Value = Passangers;
                comboBox3.SelectedValue = TownFrom;
                comboBox5.SelectedValue = TownTo;
                comboBox4.SelectedValue = StreetFrom;
                comboBox6.SelectedValue = StreetTo;
                textBox1.Text = HouseFrom;
                textBox2.Text = HouseTo;
                dateTimePicker1.Value = Convert.ToDateTime(Date);
                richTextBox1.Text = Description;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Какие-то поля введены неверно: " + ex.Message);
            }
        }

        private void CreateRequest_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.TARIF". При необходимости она может быть перемещена или удалена.
            this.tARIFTableAdapter.Fill(this.taxiDataSet.TARIF);
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.STREETS". При необходимости она может быть перемещена или удалена.
                this.sTREETSTableAdapter.FillBy(this.taxiDataSet.STREETS);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.REGION". При необходимости она может быть перемещена или удалена.
                this.rEGIONTableAdapter.Fill(this.taxiDataSet.REGION);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.EMPLOYEE". При необходимости она может быть перемещена или удалена.
                this.eMPLOYEETableAdapter.FillByDriversOnly(this.taxiDataSet.EMPLOYEE);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.TARIF". При необходимости она может быть перемещена или удалена.
                //this.tARIFTableAdapter.Fill(this.taxiDataSet.TARIF);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.ZAYAVKA". При необходимости она может быть перемещена или удалена.
                this.zAYAVKATableAdapter.Fill(this.taxiDataSet.ZAYAVKA);

                //this.lIKE_TOWNTableAdapter.Fill(this.taxiDataSet.LIKE_TOWN, save_out_street);
                dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
                if (Updating)
                    BindData();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Form load is failed: " + ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Drivers formDrv = new Drivers(true);
            formDrv.ShowDialog();
            //выбранное значение комбобокса = номеру водителя, полученного из формы
            comboBox1.SelectedValue = formDrv.ReturnDriverId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Updating)
                {
                    //Запись в базу
                    FbCommand command = new FbCommand();
                    command.Connection = zAYAVKATableAdapter.Connection;
                    command.Connection.Open();
                    command.CommandText = "select next value for gen_zayavka_id from rdb$database";


                    FbCommandBuilder fbcommandbuild = new FbCommandBuilder(zAYAVKATableAdapter.Adapter);        //????

                    DataRow t2 = taxiDataSet.Tables["ZAYAVKA"].NewRow();
                    t2["ID"] = -1;               //Заполняется триггером
                    if (comboBox1.SelectedIndex != 0)
                        t2["ID_DRIVER"] = comboBox1.SelectedValue;
                    else
                        t2["ID_DRIVER"] = 2;
                    t2["ID_OPERATOR"] = 1;      //Заполняется триггером
                    t2["DESCRIPTION"] = richTextBox1.Text;
                    t2["PASSANGERS"] = numericUpDown1.Value;
                    t2["CITY_FROM"] = comboBox3.SelectedValue;
                    t2["STREET_FROM"] = comboBox4.SelectedValue;
                    t2["HOUSE_FROM"] = textBox1.Text;
                    t2["CITY_TO"] = comboBox5.SelectedValue;
                    t2["STREET_TO"] = comboBox6.SelectedValue;
                    t2["HOUSE_TO"] = textBox2.Text;
                    if (PickerChanged)
                    {
                        t2["TIME_CREATE"] = dateTimePicker1.Value.ToString();
                    }
                    if (Cancelling)
                        t2["STATUS"] = 4;

                    command.Connection.Close();
                    //t2.Table.Columns[1]
                    taxiDataSet.Tables["ZAYAVKA"].Rows.Add(t2);
                    zAYAVKATableAdapter.Adapter.Update(taxiDataSet, "ZAYAVKA");
                    this.zAYAVKATableAdapter.Fill(this.taxiDataSet.ZAYAVKA);
                    Cancelling = false;

                    MessageBox.Show("Успешно!");
                }
                else
                {
                    FbCommand myCommand = new FbCommand();
                    myCommand.Connection = zAYAVKATableAdapter.Connection;
                    myCommand.CommandText =
                    "UPDATE ZAYAVKA SET ID_DRIVER = @NEW_ID_DRIVER, DESCRIPTION = @NEW_DESCRIPTION"
                    + ", PASSANGERS=@NEW_PASSANGERS, CITY_FROM=@NEW_CITY_FROM, STREET_FROM=@NEW_STREET_FROM, HOUSE_FROM=@NEW_HOUSE_FROM"
                    + ", CITY_TO=@NEW_CITY_TO, STREET_TO=@NEW_STREET_TO, HOUSE_TO=@NEW_HOUSE_TO";
                    myCommand.Connection.Open();

                    myCommand.Parameters.Add("@ID_ROW", ID);
                    myCommand.Parameters.Add("@NEW_ID_DRIVER", comboBox1.SelectedValue);
                    myCommand.Parameters.Add("@NEW_DESCRIPTION", richTextBox1.Text);
                    myCommand.Parameters.Add("@NEW_PASSANGERS", numericUpDown1.Value);
                    myCommand.Parameters.Add("@NEW_CITY_FROM", comboBox3.SelectedValue);
                    myCommand.Parameters.Add("@NEW_STREET_FROM", comboBox4.SelectedValue);
                    myCommand.Parameters.Add("@NEW_HOUSE_FROM", textBox1.Text);
                    myCommand.Parameters.Add("@NEW_CITY_TO", comboBox5.SelectedValue);
                    myCommand.Parameters.Add("@NEW_STREET_TO", comboBox6.SelectedValue);
                    myCommand.Parameters.Add("@NEW_HOUSE_TO", textBox2.Text);
                    if (!checkBox1.Checked)
                    {
                        myCommand.CommandText += ", TIME_CREATE=@NEW_TIME_CREATE";
                        myCommand.Parameters.Add("@NEW_TIME_CREATE", dateTimePicker1.Value.ToString());
                    }
                    myCommand.CommandText += " WHERE ID = @ID_ROW";

                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();
                    myCommand.Dispose();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Insert failed: " + ex.Message);
            }
            //Обновить данные в датагриде
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                dateTimePicker1.Visible = false;
            else
                dateTimePicker1.Visible = true;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            PickerChanged = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sTREETSTableAdapter.FillBy(this.taxiDataSet.STREETS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void CreateRequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Escape)        //Нажат Esc
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Updating = true;
            //Cancelling = true;
            CancelRequest();
        }

        void CancelRequest()
        {
            FbCommand myCommand = new FbCommand();
            myCommand.Connection = zAYAVKATableAdapter.Connection;
            myCommand.CommandText =
            "UPDATE ZAYAVKA SET STATUS = @NEW_STATUS WHERE ID = @ID_ROW";

            myCommand.Parameters.Add("@ID_ROW", ID);
            myCommand.Parameters.Add("@NEW_STATUS", comboBox1.SelectedValue);

            myCommand.Connection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();
            myCommand.Dispose();
        }
    }
}
