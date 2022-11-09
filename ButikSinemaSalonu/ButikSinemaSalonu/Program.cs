using System;

namespace ButikSinemaSalonu
{
    internal class Program
    {

        static Sinema Snm;
        static void Main(string[] args)
        {
            Uygulama();
        }

        static void Uygulama()
        {
            Giris();
            Menu();

            while (true)
            {

                Console.WriteLine();
                string secim = SecimAl();
                Console.WriteLine();

                switch (secim)
                {

                    case "1":
                        BiletSatis();
                        break;
                    case "2":
                        BiletIade();
                        break;
                    case "3":
                        DurumBilgisi();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                }            
            }        
        }

        static void Giris()
        {

            Console.WriteLine("--------Butik Sinema Salonu--------");
            Console.Write("Film Adı:");
            string filmadi = Console.ReadLine();
            Console.Write("Kapasite: ");
            int kap = int.Parse(Console.ReadLine());
            Console.Write("Tam Bilet Fiyatı: ");
            float tam = float.Parse(Console.ReadLine());
            Console.Write("Yarım Bilet Fiyatı: ");
            float yarim = float.Parse(Console.ReadLine());

            Snm = new Sinema(filmadi, kap, tam, yarim);


        }

        static void Menu()
        {

            Console.WriteLine();
            Console.WriteLine("1 - Bilet Sat(S)");
            Console.WriteLine("2 - Bilet İade(R)");
            Console.WriteLine("3 - Durum Bilgisi(D)");
            Console.WriteLine("4 - Çıkış(X)");
        
        }

        static string SecimAl()
        {

            int sayac = 0;

            string karakterler = "1234SRDX";

            while (true)
            {

                sayac++;
                Console.Write("Seçiminiz: ");
                string giris = Console.ReadLine().ToUpper();

                if (giris.Length == 1 && karakterler.IndexOf(giris) > -1)
                {

                    return giris;

                }
                else if (sayac == 10)
                {

                    Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program Sonlandırıldı...");
                    Environment.Exit(0);
                
                }

                Console.WriteLine("Hatalı Giriş Yapıldı... Tekrar Deneyin...");

            }
        
        }

        static void BiletSatis()
        {

            Console.WriteLine("Bilet Sat: ");
            int tam = SayiAl("Tam Bilet Adedini Giriniz: ");
            int yarim = SayiAl("Yarım Bilet Adedini Giriniz: ");

            Snm.BiletSatis(tam, yarim);

        }

        static void BiletIade()
        {

            Console.WriteLine("Bilet İade: ");
            int tam = SayiAl("Kaç Tane Tam Bilet İade Edeceksiniz: ");
            int yarim = SayiAl("Kaç Tane Yarım Bilet İade Edeceksiniz: ");

            Snm.BiletIade(tam, yarim);
        
        }

        static void DurumBilgisi()
        {

            Console.WriteLine("Durum Bilgisi: ");
            Console.WriteLine("Film Adı: " + Snm.FilmAdi);
            Console.WriteLine("Kapasite: " + Snm.Kapasite);
            Console.WriteLine("Tam Bilet Fiyatı: " + Snm.TamBiletFiyati);
            Console.WriteLine("Yarım Bilet Fiyatı: " + Snm.YarimBiletFiyati);
            Console.WriteLine("Tam Bilet Adedi: " + Snm.ToplamTamBiletAdedi);
            Console.WriteLine("Yarım Bilet Adedi: " + Snm.ToplamYarimBiletAdedi);
            Console.WriteLine("Ciro: " + Snm.Ciro);

            Console.WriteLine("Boş Koltuk Adedi: " + Snm.BosKoltukAdediGetir());
        
        
        }

        static int SayiAl(string mesaj)
        {

            int sayi;

            while (true)
            {

                Console.Write(mesaj); //Tam Bilet Adedini Giriniz: 
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out sayi))
                {

                    return sayi;

                }
                else 
                {

                    Console.WriteLine("Hatalı giriş yapıldı...");
                
                }
            
            }
        
        }

























        static string CustomSubString(string veri, int baslangicIndex, int karakterSayisi)
        {
            string cikti = "";

            if ((baslangicIndex + karakterSayisi) <= veri.Length)
            {

                for (int i = baslangicIndex; i < (baslangicIndex + karakterSayisi); i++)
                {
                    cikti += veri[i];
                }

            }
            else 
            {

                Console.WriteLine("Böyle yapacaksan hiç girmeyelim bu işe...");
            
            }
            
            return cikti;
        
        }

        static int CustomPow(uint taban, uint us)
        {

            int sonuc = 1;
           
                for (int i = 0; i < us; i++)
                {
                    sonuc *= (int)taban;
                }

            return sonuc;
                
        }


    }
}
