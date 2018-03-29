using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using SpeechLib;


namespace Kursovik_UD
{
    public partial class Main : Form
    {
        Operator newMdiChild;
        private static bool AutorizateStatus = false;
        private static string UserStatus = "";

        public Main()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Autorizate autorizate = new Autorizate();
            autorizate.ShowDialog();

            FbConnectionStringBuilder sb = new FbConnectionStringBuilder(Properties.Settings.Default.TaxiConnectionString);
            sb.UserID = autorizate.UserID;
            sb.Password = autorizate.Password;
            sb.Role = Convert.ToString(autorizate.Role);
            Properties.Settings.Default["TaxiConnectionString"] = sb.ConnectionString;          //Замена параметров в connectionstring
            FbConnection test = new FbConnection(sb.ToString());

            try
            {
                //string role = "operator";       //UTF8 -> win1251
                if (sb.Role == "admins")        ///-----
                {
                    test.Open();
                    test.Close();
                    Admin medic = new Admin();      //Окрытие интерфейса admin
                    ShowChildForm(medic, this);
                    AutorizateStatus = true;
                    UserStatus = "admin";
                }
                else if (sb.Role == "operator")        ///-----
                {
                    test.Open();
                    test.Close();
                    newMdiChild = new Operator();      //Окрытие интерфейса оператора
                    ShowChildForm(newMdiChild, this);
                    AutorizateStatus = true;
                    UserStatus = "operator";
                }
                else if (sb.Role == "medic")
                {
                    test.Open();
                    test.Close();
                    Medic newMdiChild = new Medic();      //Окрытие интерфейса медика
                    ShowChildForm(newMdiChild, this);
                    AutorizateStatus = true;
                    UserStatus = "medic";
                }
                else if (sb.Role == "technic")
                {
                    test.Open();
                    test.Close();
                    Technic newMdiChild = new Technic();
                    ShowChildForm(newMdiChild, this);
                    AutorizateStatus = true;
                    UserStatus = "technic";
                }
            }
            catch (Exception ex)
            {
                SpVoiceClass voice = new SpVoiceClass();
                string str = "Перелогиньтесь";
                voice.Speak(str, SpeechVoiceSpeakFlags.SVSFlagsAsync);
                MessageBox.Show(str + ". " + ex.Message);
            }

        }
        static void ShowChildForm(Form form, Form currentForm)
        {
            form.MdiParent = currentForm;
            form.Show();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                do
                {
                    MdiChildren[0].Close();
                }
                while (MdiChildren.Count() > 0);
            }
            catch (Exception ex)
            {

            }
            FbConnectionStringBuilder sb = new FbConnectionStringBuilder(Properties.Settings.Default.TaxiConnectionString);
            sb.UserID = "";
            sb.Password = "";
            sb.Role = "";
            Properties.Settings.Default["TaxiConnectionString"] = sb.ConnectionString;          //Стереть логин, пароль, роль
            Main_Load(sender, e);
        }

        private void открытьИнтерфейсОператораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((newMdiChild == null || newMdiChild.IsDisposed) && UserStatus == "operator")      //Проверка на закрытие формы
            {
                newMdiChild = new Operator();      //Окрытие интерфейса оператора
                ShowChildForm(newMdiChild, this);
            }
        }

        private void интерфейсМедикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserStatus == "medic")
            {
                Medic medic = new Medic();      //Окрытие интерфейса медика
                ShowChildForm(medic, this);
            }
        }

        private void интерфейсТехникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserStatus == "technic")
            {
                Technic technic = new Technic();
                ShowChildForm(technic, this);
            }
        }

        private void интерфейсАдминистратораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserStatus == "admin")
            {
                Admin form = new Admin();
                ShowChildForm(form, this);
            }
        }
    }
}
