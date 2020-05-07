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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string girilen = textBox1.Text;
            string cevapp = "50";
            if (girilen == cevapp)
            {
                label2.BackColor = Color.Green;
                label2.Text = "Tebrikler Çok İyisin";
                Application.DoEvents();
                Thread.Sleep(400); //Butonumuzun renginin değiştirildiğini görebilmek için ekranda bekletiyoruz.
                this.Hide();
                

            }
            else
            {
                label2.BackColor = Color.Red;
                label2.Text = "Yanlış Cevap. Yeniden Dene!";
            }
        }
    }
}
