using System;
namespace _nstance_field_property
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Söz Dizimi:
                class SinifAdi
                {
                    [Erisim Belirleyici] [Veri Tipi] OzellikAdi;
                    [Erisim Belirleyici] [Geri Donus Tipi] MetotAdi([Parametre Listesi])
                    {
                        METOT KOMUTLARI
                    }
                }

                Erisim Belirleyicileri:
                * Public
                * Private
                * Internal
                * Protected
            */

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayse";
            calisan1.Soyad = "Kara";
            calisan1.No = 2154513;
            calisan1.Departman = "Insan Kaynaklari";
            calisan1.CalisanBilgileri();

            Console.WriteLine("*********");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 5546546;
            calisan2.Departman = "Satin Alma";
            calisan2.CalisanBilgileri();
        }

        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;
            public void CalisanBilgileri()
            {
                Console.WriteLine("Calisan Adi: {0}", Ad);
                Console.WriteLine("Calisan Soyad: {0}", Soyad);
                Console.WriteLine("Calisan No: {0}", No);
                Console.WriteLine("Calisan Departmani: {0}", Departman);
            }
        }
    }
}