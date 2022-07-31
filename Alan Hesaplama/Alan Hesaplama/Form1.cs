using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alan_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                Gorunum.ComboboxDegistir(comboBox1, comboBox2);               
            }
            else
            {
                Gorunum.ComboboxDegistir(comboBox1, comboBox2);                
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    Gorunum.DaireCevreHesapla(label3, label4, label6, textBox1, textBox2, textBox3);
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    Gorunum.UcgenCevreHesapla(label3, textBox1, label4, textBox2, label6, textBox3);
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    Gorunum.KareCevreHesapla(label3, textBox1, label4, label6, textBox2, textBox3);
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    Gorunum.DikdortgenCevreHesapla(label3, textBox1, label4, textBox2, label6, textBox3);
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    Gorunum.DaireAlanHesapla(label3, label4, label6, textBox1, textBox2, textBox3);
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    Gorunum.UcgenAlanHesapla(label3, textBox1, label4, textBox2, label6, textBox3);
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    Gorunum.KareAlanHesapla(label3, textBox1, label4, textBox2, label6, textBox3);
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    Gorunum.DikdortgenAlanHesapla(label3, textBox1, label4, textBox2, label6, textBox3);
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    Gorunum.SilindirHacimHesapla(label3, textBox1, label4, textBox2, label6, textBox3);
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    Gorunum.UcgenPrizmaHacimHesapla(label3, textBox1, label4, textBox2, label6, textBox3);
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    Gorunum.KupHacimHesapla(label3, textBox1, label4, textBox2, label6, textBox3);
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    Gorunum.DikdortgenPrizmaHacimHesapla(label3, textBox1, label4, textBox2, label6, textBox3);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Sayi = Convert.ToDouble(textBox1.Text);
            double Sayi2;
            double Sayi3;

            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                CevreHesapla.DaireHesapla(Sayi);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                Sayi2 = Convert.ToDouble(textBox2.Text);
                Sayi3 = Convert.ToDouble(textBox3.Text);
                CevreHesapla.UcgenHesapla(Sayi, Sayi2, Sayi3);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                CevreHesapla.KareHesapla(Sayi);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3)
            {
                Sayi2 = Convert.ToDouble(textBox2.Text);
                CevreHesapla.DikdortgenHesapla(Sayi, Sayi2);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                AlanHesapla.DaireHesapla(Sayi);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
            {
                Sayi2 = Convert.ToDouble(textBox2.Text);
                AlanHesapla.UcgenHesapla(Sayi, Sayi2);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                AlanHesapla.KareHesapla(Sayi); 
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3)
            {
                Sayi2 = Convert.ToDouble(textBox2.Text);
                AlanHesapla.DikdortgenHesapla(Sayi, Sayi2);
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                Sayi2 = Convert.ToDouble(textBox2.Text);
                HacimHesapla.SilindirHesapla(Sayi, Sayi2);
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                Sayi2 = Convert.ToDouble(textBox2.Text);
                HacimHesapla.UcgenPrizmaHesapla(Sayi, Sayi2);
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 2)
            {
                HacimHesapla.KüpHesapla(Sayi);
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 3)
            {
                Sayi2 = Convert.ToDouble(textBox2.Text);
                HacimHesapla.DikdortgenPrizmaHesapla(Sayi, Sayi2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        
    }
}
