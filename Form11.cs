﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form11 : Form
    {
        Form2 f2;
        public Form11()
        {
            InitializeComponent();
        }
        public Form11(Form2 f2)
        {
            this.f2 = f2;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form12 newForm = new Form12(this);
            newForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int delet = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delet);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            f2.comboBox1.Items.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                 f2.comboBox1.Items.Add(row.Cells[0].Value.ToString());
            }
            Close();
        }
    }
}
