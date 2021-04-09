using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       
        
       public void musteriEkleme()
        {
            Musteri musteri = new Musteri();

            musteri.musteriAd = "Emrullah";
            musteri.musteriSoyad = "Yoldaş";
            musteri.musteriPara = 50;

            Musteri musteri2 = new Musteri();

            musteri.musteriAd = "Musa";
            musteri.musteriSoyad = "İnan";
            musteri.musteriPara = 100;

            Musteri[] musteriler = new Musteri[] { musteri,musteri2};

            foreach (var musterilerhepsi in musteriler)

            {
                Console.WriteLine("eklenen müsşeriler:"+musterilerhepsi.musteriAd+ " "+musterilerhepsi.musteriSoyad+" "+musterilerhepsi.musteriPara );
            }

        }



    }
}
