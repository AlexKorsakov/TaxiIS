﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursovik_UD
{
    public partial class Streets : Form
    {
        public Streets()
        {
            InitializeComponent();
        }

        private void Streets_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.STREETS". При необходимости она может быть перемещена или удалена.
            this.sTREETSTableAdapter.Fill(this.taxiDataSet.STREETS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.TARIF". При необходимости она может быть перемещена или удалена.
            this.tARIFTableAdapter.Fill(this.taxiDataSet.TARIF);

        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.sTREETSTableAdapter.Update(this.taxiDataSet);
        }
    }
}
