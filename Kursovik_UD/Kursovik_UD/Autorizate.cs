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
    public partial class Autorizate : Form
    {
        public string UserID = "";
        public string Password = "";
        public string Role = "";


        public Autorizate()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserID = textBox1.Text;
            Password = textBox2.Text;
            Role = comboBox1.Text;
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
