using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string girilen = textBox1.Text;
            string cevapp = "42";
            if (girilen == cevapp)
            {
                label2.BackColor = Color.Green;
                label2.Text = "Doğru";
                Application.DoEvents();
                Thread.Sleep(400); //Butonumuzun renginin değiştirildiğini görebilmek için ekranda bekletiyoruz.
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();

            }
            else
            {
                label2.BackColor = Color.Red;
                label2.Text = "Yanlış Cevap. Yeniden Dene!";
            }
        }
    }
    }

