using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alan_Hesaplama
{
    internal class HacimHesapla
    {
        public static void SilindirHesapla(double Sayi, double Sayi2)
        {
            double Hacim = Sayi * Sayi * Sayi2 * 3.14;
            MessageBox.Show("Silindirin hacmi " + Convert.ToDouble(Hacim) + "");
        }

        public static void UcgenPrizmaHesapla(double Sayi, double Sayi2)
        {
            double Hacim = Sayi * Sayi2;
            MessageBox.Show("Üçgen prizmanın hacmi " + Convert.ToDouble(Hacim) + "");
        }

        public static void KüpHesapla(double Sayi)
        {
            double Hacim = Sayi * Sayi * Sayi;
            MessageBox.Show("Küpün hacmi " + Convert.ToDouble(Hacim) + "");
        }

        public static void DikdortgenPrizmaHesapla(double Sayi, double Sayi2)
        {
            double Hacim = Sayi * Sayi * Sayi2;
            MessageBox.Show("Dikdörtgen Prizmanın hacmi " + Convert.ToDouble(Hacim) + "");
        }
    }
}
