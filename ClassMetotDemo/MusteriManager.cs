using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd+" "+musteri.MusteriSoyad+" --- "+musteri.Yas +" /Müşteri Eklendi!" );
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " --- " + musteri.Yas + " /Müşteri Silindi!");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAd+" "+musteri.MusteriSoyad+" / "+musteri.Yas);
            }
        }

        public double Ortalama(params int [] ortalama)
        {
            return ortalama.Average();
        }
    }
}
