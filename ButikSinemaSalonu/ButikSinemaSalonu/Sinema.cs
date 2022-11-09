using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButikSinemaSalonu
{
    class Sinema
    {
        public string FilmAdi { get; set; }

        public int Kapasite { get; set; }

        public float TamBiletFiyati { get; }

        public float YarimBiletFiyati { get; }

        public int ToplamTamBiletAdedi { get; private set; }

        public int ToplamYarimBiletAdedi { get; private set; }

        public float Ciro
        {
            get
            {
                float ciro = ((float)this.ToplamTamBiletAdedi * this.TamBiletFiyati) + ((float)this.ToplamYarimBiletAdedi * this.YarimBiletFiyati);

                return ciro;
            }
        }



        public Sinema(string filmAdi, int kapasite, float tamBiletFiyati, float yarimBiletFiyati)
        {
            this.FilmAdi = filmAdi;
            this.Kapasite = kapasite;
            this.TamBiletFiyati = tamBiletFiyati;
            this.YarimBiletFiyati = yarimBiletFiyati;
        }

        public void BiletSatis(int tambiletadedi, int yarimbiletadedi)
        {

            if (BosKoltukAdediGetir() >= tambiletadedi + yarimbiletadedi)
            {

                this.ToplamTamBiletAdedi += tambiletadedi;
                this.ToplamYarimBiletAdedi += yarimbiletadedi;
                Console.WriteLine("İşleminiz Gerçekleştirildi...");

            }
            else
            {

                Console.WriteLine("Yeterli boş koltuk yok. Satılabilecek bilet adedi: " + BosKoltukAdediGetir());


            }

        }

        public void BiletIade(int tambiletadedi, int yarimbiletadedi)
        {

            if (tambiletadedi <= this.ToplamTamBiletAdedi && yarimbiletadedi <= this.ToplamYarimBiletAdedi)
            {

                this.ToplamTamBiletAdedi -= tambiletadedi;
                this.ToplamYarimBiletAdedi -= yarimbiletadedi;
                Console.WriteLine("İşlem Gerçekleştirildi...");

            }
            else
            {

                Console.WriteLine("İade edilecek bilet miktarını aştınız...");

            }

        }

        public int BosKoltukAdediGetir()
        {

            return this.Kapasite - this.ToplamYarimBiletAdedi - this.ToplamTamBiletAdedi;

        }


    }
}
