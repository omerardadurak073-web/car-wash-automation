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
    public partial class Form1 : Form
    {
        public static List<string> plaka = new List<string>();
        public static List<string> tur = new List<string>();
        public static List<string> yikanma = new List<string>();
        public static List<string> tarih = new List<string>();

        public static void Dosyakayıt()
        {
            StreamWriter sw = new StreamWriter("otopark.txt");
                for(int i=0; i < plaka.Count; i++)
                {
                    sw.WriteLine(plaka[i] + "," + tur[i] + "," + yikanma[i] + "," + tarih[i]);
                }
            sw.Close();
        }
        public static void Dosyayukle()
        {
            if (File.Exists("otopark.txt"))
            {
                plaka.Clear();
                tur.Clear();
                yikanma.Clear();
                tarih.Clear();
            
            
            StreamReader sr = new StreamReader("otopark.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
                {
                    string[] parca = s.Split(',');

                    if (parca.Length == 4)
                    {
                        plaka.Add(parca[0]);
                        tur.Add(parca[1]);
                        yikanma.Add(parca[2]);
                        tarih.Add(parca[3]);
                    }
                }
            sr.Close();
        }
    }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim()== "" || textBox2.Text.Trim()== "")
            {
                MessageBox.Show("Kullanıcı adı veya şisfre boş bırakılamaz.");
            }
            else { 
            if (textBox1.Text == "abc" && textBox2.Text == "123") // gorevlının kullanıcı adının abc ve sıfreısının 123 oldugunu varsayalım
            {
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş.");
            }
            
        }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dosyayukle();
        }
    }
}
