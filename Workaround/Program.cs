using Business.Concrete;
using Entities.Concrete;
using System;


namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            SelamVer("Büşra");
            SelamVer("Ayşegül");
            SelamVer("Şeyma");
            SelamVer();

            int sonuc = Topla(3);

            //Diziler / Arrays

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Ayşe";
            ogrenciler[1] = "Fatma";
            ogrenciler[2] = "Ramazan";


            ogrenciler = new string[4];

            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Büşra";
            person1.LastName = "Dertli";
            person1.DateOfBirthYear = 2003;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {

            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }
    }
}