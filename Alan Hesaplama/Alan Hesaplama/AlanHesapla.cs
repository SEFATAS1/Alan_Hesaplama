using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alan_Hesaplama
{
    public class AlanHesapla
    {
        public static void DaireHesapla (double Double)
        {
            double Alan = ((Double * Double) * 3.14);
            MessageBox.Show("Dairenin alanı " + Convert.ToString(Alan) + "");
        }

        public static void UcgenHesapla(double Sayi, double Sayi2)
        {
            double Alan = ((Sayi * Sayi2) / 2 );
            MessageBox.Show("Üçgenin alanı " + Convert.ToString(Alan) + "");
        }

        public static void KareHesapla(double Sayi)
        {
            double Alan = (Sayi * Sayi);
            MessageBox.Show("Karenin alanı " + Convert.ToString(Alan) + "");
        }

        public static void DikdortgenHesapla(double Sayi, double Sayi2)
        {
            double Alan = (Sayi * Sayi2);
            MessageBox.Show("Dikdörtgenin alanı " + Convert.ToString(Alan) + "");
        }

    }
}
