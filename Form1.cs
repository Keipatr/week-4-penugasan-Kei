using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace week_4_penugasan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        public static string[] dataNama = new string[11];
        public static string[] dataAlamat = new string[11];
        public static string[] dataTelp = new string[11];
        public static int i = 0;
        public static int itung = 0;

        private void txtBoxTelp(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                dataNama[i] = textBoxNama.Text;
                dataAlamat[i] = textBoxAlamat.Text;
                dataTelp[i] = textBoxTelp.Text;
                i++;
                textBoxTelp.Clear();
                textBoxAlamat.Clear();
                textBoxNama.Clear();
                itung++;
            }
            else
            {
                MessageBox.Show("Data telah penuh!");
            }
        }

        private void buttonLihatData_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            this.Hide();
            myForm.ShowDialog();       
        }
    }
}