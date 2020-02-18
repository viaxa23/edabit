using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dolgozat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string szo = textBox1.Text;
            int sorszam = Int32.Parse(textBox2.Text);

            if (sorszam >= szo.Length || sorszam <= 0)
            {
                textBox3.Text = "Nincs ilyen sorszámú karakter";
            }
            else if (sorszam == 1)
            {
                string elso = szo.Substring(0, 1).ToUpper();
                string masodik = szo.Substring(1);
                string kimenet = elso + masodik;
                textBox3.Text = kimenet;
            }
            else if (sorszam == szo.Length)
            {
                string elso = szo.Substring(0, szo.Length - 1);
                string masodik = szo.Substring(szo.Length - 1).ToUpper();
                string kimenet = elso + masodik;
                textBox3.Text = kimenet;
            }
            else if (sorszam > 1 && sorszam < szo.Length)
            {
                string elso = szo.Substring(0, sorszam -1);
                string masodik = szo.Substring(sorszam - 1, 1).ToUpper();
                string harmadik = szo.Substring(sorszam);
                string kimenet = elso + masodik + harmadik;
                textBox3.Text = kimenet;
            }
        }
    }
}
