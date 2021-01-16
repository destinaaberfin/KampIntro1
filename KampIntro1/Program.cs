using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip güvenliği
            //Do not repeat
            //değer tutucu, alias 

            string kategoriEtiketi = "Kategoriler";
            int ogrencisayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

       

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine("kategoriEtiketi");
        }
    }
}
