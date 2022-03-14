using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_4_penugasan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int i = 0;
           
        private void buttonKembali_Click(object sender, EventArgs e)
        {            
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();            
        }

        private void buttonNextData_Click(object sender, EventArgs e)
        {
            if (i < Form1.itung-1)
            {
                i++;
                textBoxNama.Text = Form1.dataNama[i];
                textBoxAlamat.Text = Form1.dataAlamat[i];
                textBoxTelp.Text = Form1.dataTelp[i];
            }
            else
            {
                MessageBox.Show("Data sudah data Terakhir");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.itung == 0)
            {
                textBoxNama.Text = "<data kosong>";
                textBoxAlamat.Text = "<data kosong>";
                textBoxTelp.Text = "<data kosong>";
            }
            else
            {
                textBoxNama.Text = Form1.dataNama[0];
                textBoxAlamat.Text = Form1.dataAlamat[0];
                textBoxTelp.Text = Form1.dataTelp[0];
            }
        }
        private void buttonPrevData_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                textBoxNama.Text = Form1.dataNama[i];
                textBoxAlamat.Text = Form1.dataAlamat[i];
                textBoxTelp.Text = Form1.dataTelp[i];
            }
            else
            {
                MessageBox.Show("Data sudah data pertama");
            }
        }
    }
}
