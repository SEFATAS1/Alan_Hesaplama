using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alan_Hesaplama
{
    internal class Gorunum
    {
        public static void ComboboxDegistir(ComboBox comboBox1, ComboBox comboBox2)
        {
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Daire");
                comboBox2.Items.Add("Üçgen");
                comboBox2.Items.Add("Kare");
                comboBox2.Items.Add("Dikdörtgen");
            }   
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Silindir");
                comboBox2.Items.Add("Üçgen Prizma");
                comboBox2.Items.Add("Küp");
                comboBox2.Items.Add("Dikdörtgen Prizma");
            }
        }

        public static void DaireCevreHesapla(Label label, Label label1, Label label2, TextBox textBox, TextBox textBox1, TextBox textBox2)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label.Visible = true;
            label.Text = "Dairenin yarıçapını giriniz:";
            textBox.Visible = true;                           
        }

        public static void UcgenCevreHesapla(Label label, TextBox textBox, Label label1, TextBox textBox1, Label label2, TextBox textBox2)
        {                
            label.Visible = true;
            label.Text = "1. kenarı giriniz:";
            textBox.Visible = true;
            label1.Visible = true;
            label1.Text = "2. kenarı giriniz:";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "3. kenarı giriniz:";
            textBox2.Visible = true;
        }

        public static void KareCevreHesapla(Label label, TextBox textBox, Label label1, Label label2, TextBox textBox1, TextBox textBox2)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label.Visible = true;
            label.Text = "kenarı uzunluğunu giriniz:";
            textBox.Visible = true;                
        }

        public static void DikdortgenCevreHesapla(Label label, TextBox textBox, Label label1, TextBox textBox1, Label label2, TextBox textBox2)
        {
            label2.Visible = false;
            textBox2.Visible = false;
            label.Visible = true;
            label.Text = "Uzun kenarı giriniz:";
            textBox.Visible = true;
            label1.Visible = true;
            label1.Text = "Kısa kenarı giriniz:";
            textBox1.Visible = true;                          
        }

        public static void DaireAlanHesapla(Label label, Label label1, Label label2, TextBox textBox, TextBox textBox1, TextBox textBox2)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label.Visible = true;
            label.Text = "Dairenin yarıçapını giriniz:";
            textBox.Visible = true;  
        }

        public static void UcgenAlanHesapla(Label label, TextBox textBox, Label label1, TextBox textBox1, Label label2, TextBox textBox2)
        {
            label2.Visible = false;
            textBox2.Visible = false;
            label.Visible = true;
            label.Text = "Yükseliği giriniz:";
            textBox.Visible = true;
            label1.Visible = true;
            label1.Text = "Taban uzunluğunu giriniz:";
            textBox1.Visible = true;  
        }

        public static void KareAlanHesapla(Label label, TextBox textBox, Label label1, TextBox textBox1, Label label2, TextBox textBox2)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label.Visible = true;
            label.Text = "Kenar uzunluğunu giriniz:";
            textBox.Visible = true;           
        }

        public static void DikdortgenAlanHesapla(Label label, TextBox textBox, Label label1, TextBox textBox1, Label label2, TextBox textBox2)
        {
            label2.Visible = false;
            textBox2.Visible = false;
            label.Visible = true;
            label.Text = "Uzun kenarı giriniz:";
            textBox.Visible = true;
            label1.Visible = true;
            label1.Text = "Kısa kenarı giriniz:";
            textBox1.Visible = true;
        }
       
        public static void SilindirHacimHesapla(Label label, TextBox textBox, Label label1, TextBox textBox1, Label label2, TextBox textBox2)
        {
            label2.Visible = false;
            textBox2.Visible = false;
            label.Visible = true;
            label.Text = "Dairenin yarıçapını giriniz:";
            textBox.Visible = true;
            label1.Visible = true;
            label1.Text = "Silindirin yüksekliğini giriniz:";
            textBox1.Visible = true;
        }

        public static void UcgenPrizmaHacimHesapla(Label label, TextBox textBox, Label label1, TextBox textBox1, Label label2, TextBox textBox2)
        {
            label2.Visible = false;
            textBox2.Visible = false;
            label.Visible = true;
            label.Text = "Taban alanı giriniz:";
            textBox.Visible = true;
            label1.Visible = true;
            label1.Text = "Prizmanın yüksekliğini giriniz:";
            textBox1.Visible = true;
        }

        public static void KupHacimHesapla(Label label, TextBox textBox, Label label1, TextBox textBox1, Label label2, TextBox textBox2)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label.Visible = true;
            label.Text = "Kenar uzunluğu giriniz:";
            textBox.Visible = true;
        }

        public static void DikdortgenPrizmaHacimHesapla(Label label, TextBox textBox, Label label1, TextBox textBox1, Label label2, TextBox textBox2)
        {
            label2.Visible = false;
            textBox2.Visible = false;
            label.Visible = true;
            label.Text = "Kısa kenar uzunluğu giriniz:";
            textBox.Visible = true;
            label1.Visible = true;
            label1.Text = "Uzun kenar uzunluğunu girinz:";
            textBox1.Visible = true;
        }
    }
}
