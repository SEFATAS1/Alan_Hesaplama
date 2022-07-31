using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alan_Hesaplama
{
    internal class CevreHesapla
    {
        public static void DaireHesapla(double Sayi)
        {
            double Cevre = Sayi * 2 * 3.14;
            MessageBox.Show("Dairenin çevresi "  + Convert.ToString(Cevre) + " Uzunluğundadır.");
        }

        public static void UcgenHesapla(double Sayi, double Sayi2, double Sayi3)
        {
            double Cevre = Sayi + Sayi2 + Sayi3;
            MessageBox.Show("Üçgenin çevresi " + Convert.ToString(Cevre) + " Uzunluğundadır.");
        }

        public static void KareHesapla(double Sayi)
        {
            double Cevre = Sayi * 4;
            MessageBox.Show("Karenin çevresi " + Convert.ToString(Cevre) + " Uzunluğundadır.");
        }  

        public static void DikdortgenHesapla(double Sayi, double Sayi2)
        {
            double Cevre = (Sayi * 2) + (Sayi2 * 2);
            MessageBox.Show("Dikdörtgenin çevresi " + Convert.ToString(Cevre) + " Uzunluğundadır.");
        }
    }
}
