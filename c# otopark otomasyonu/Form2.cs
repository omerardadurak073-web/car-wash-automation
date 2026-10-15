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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
    public void guncel()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Form1.plaka.Count; i++)
            {
                dataGridView1.Rows.Add(Form1.plaka[i], Form1.tur[i], Form1.yikanma[i], Form1.tarih[i]);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            guncel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

            guncel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int secim = dataGridView1.SelectedRows[0].Index;

                Form1.plaka.RemoveAt(secim);
                Form1.tur.RemoveAt(secim);
                Form1.yikanma.RemoveAt(secim);
                Form1.tarih.RemoveAt(secim);

                Form1.Dosyakayıt();

                guncel();

                MessageBox.Show("Araç çıkışı yapıldı.");
                
            }
            else
            {
                MessageBox.Show("Çıkış yapılacak aracı tablodan seçin.");
            }
           
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            Form1.Dosyayukle();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Form1.plaka.Count; i++)
            {
                dataGridView1.Rows.Add(Form1.plaka[i], Form1.tur[i], Form1.yikanma[i], Form1.tarih[i]);
            }
        }
    }
}
