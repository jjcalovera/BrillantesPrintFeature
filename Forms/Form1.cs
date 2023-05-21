using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrillantesPrintFeature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn clmBtnRemove = new DataGridViewButtonColumn();
            clmBtnRemove.HeaderText = "Action";
            clmBtnRemove.Name = "clmBtnRemove";
            clmBtnRemove.Text = "Remove";
            clmBtnRemove.UseColumnTextForButtonValue = true;
            this.dataGridView1.Columns.Add(clmBtnRemove);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
