using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.MusteriAd = "Erkan";
            musteri1.MusteriSoyad = "Demircioğlu";
            musteri1.Yas = 39;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAd = "Mehtap";
            musteri2.MusteriSoyad = "Sağır";
            musteri2.Yas = 25;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAd = "Hale";
            musteri3.MusteriSoyad = "Belgin";
            musteri3.Yas = 35;

            Musteri musteri4 = new Musteri();
            musteri4.MusteriAd = "Ahmet";
            musteri4.MusteriSoyad = "Dağ";
            musteri4.Yas = 29;

            Musteri musteri5 = new Musteri();
            musteri5.MusteriAd = "Hasan";
            musteri5.MusteriSoyad = "Gün";
            musteri5.Yas = 24;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Listele(musteriler);

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);

            int[] musteriYas = new int[musteriler.Length];

            for (int i = 0; i < musteriler.Length; i++)
            {
                musteriYas[i] = musteriler[i].Yas;
            }
            
            var result = musteriManager.Ortalama(musteriYas);
            Console.WriteLine("Müşteri yaş ortalaması : " + result);
            Console.ReadLine();
        }
    }
}
