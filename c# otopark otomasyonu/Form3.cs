using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Plaka boş bırakılamaz.");

            }
            else
            {
                try
                {
                    Form1.plaka.Add(textBox1.Text);
                    Form1.tur.Add(comboBox1.Text);
                    Form1.tarih.Add(dateTimePicker1.Value.ToShortDateString());
                    if (checkBox1.Checked == true)
                        Form1.yikanma.Add("Yıkama yapılacak");
                    else
                        Form1.yikanma.Add("Yıkama yapılmayacak");
                    Form1.Dosyakayıt();
                    MessageBox.Show("Kayıt Yapıldı.");
                    Close();
                }
                catch (Exception h)
                {
                    MessageBox.Show("Hata: " + h.Message);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            comboBox1.Items.Add("Benzin");
            comboBox1.Items.Add("Dizel");
            comboBox1.Items.Add("LPG");
            comboBox1.Items.Add("Elektrik");
            comboBox1.Items.Add("Hibrit");

            comboBox1.SelectedIndex = 0;
        }
    }
}
