using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int i))
            {
                MessageBox.Show("Errore: Inserire un numero valido.");
                label3.Text = "Errore";
                button2.BackColor = Color.Green;
            }
            else
            {
                if (i % 2 == 0)
                {
                    label3.Text = "Pari";
                    button2.BackColor = Color.Red;
                }
                else
                {
                    label3.Text = "Dispari";
                    button2.BackColor = Color.Azure;
                }
            }
        }
    }
}
