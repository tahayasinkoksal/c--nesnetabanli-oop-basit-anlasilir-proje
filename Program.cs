using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yilsonu
{
    //OOP icin Otomobil sinifimi olusturdum.
    class Otomobil
    {
        public string marka;
        public string model;
        public int yil;
        public string renk;
        public int fiyat;

        //Sinifimla ayni sisimde yapilandiricisini yazdim.
        public Otomobil(string marka, string model, int yil, string renk, int fiyat)
        {
            this.marka = marka;
            this.model = model;
            this.yil = yil;
            this.renk = renk;
            this.fiyat = fiyat;
        }

        public void BilgileriYazdir()  //Bilgileri yazdirma metodunu olusturdum.
        {
            Console.WriteLine("Marka: " + this.marka + "    Model:" + this.model + "    Uretim Yili:" + this.yil + "    Renk:" +  this.renk + "    Fiyat:" + this.fiyat + " TL");

        }
        //Fiyatta degisiklik yapabilmek icin fiyat verisini alip degisim için metodlarim
        public int getFiyat() { return this.fiyat; }
        public void setFiyat(int fiyat) { this.fiyat = fiyat; }

    }



    class Program
    {
        static void Main(string[] args)
        {
            //Otomobilleri tutacagim listemi olusturdum
            List<Otomobil> otomobilliste = new List<Otomobil>();

            //Degiskenlerim
            int zam;
            int indirim;
            int secim;
            int secim2;
            string marka;
            string model;
            int yil;
            string renk;
            int fiyat;
            
            //sonsuz dongumu baslattim
            while (true) 
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("1.Otomobil Ekle");
                Console.WriteLine("2.Otomobil Sil");
                Console.WriteLine("3.Otomobil Listele");
                Console.WriteLine("4.Zam Uygula");
                Console.WriteLine("5.Indirim Uygula");
                Console.WriteLine("0.Cikis");

               
                Console.WriteLine("-----------------------------------------------------");
                Console.Write("Seciminiz:");
                secim = Convert.ToInt32(Console.ReadLine());
               
                //Otomobil ekleme
                if (secim == 1) 
                {
                  
                    
                    Console.Write("Marka:");
                    marka = Console.ReadLine();
                    Console.Write("Model:");
                    model = Console.ReadLine();
                    Console.Write("Yil:");
                    yil =  Convert.ToInt32(Console.ReadLine());
                    Console.Write("Renk:");
                    renk = Console.ReadLine();
                    Console.Write("Fiyat:");
                    fiyat = Convert.ToInt32(Console.ReadLine());

                  

                    Otomobil o1 = new Otomobil(marka,model,yil,renk,fiyat);
                    otomobilliste.Add(o1);
                    Console.WriteLine("Otomobil eklendi...");
                
                }

                //Otomobil sil
                if (secim == 2) {

                    OtomobilSil(otomobilliste);

                                     
                
                }
                //otomobil listeleme
                if (secim == 3) 
                {
                    
                    while(true)
                    {
                        
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("1.Markaya Gore Ara");
                    Console.WriteLine("2.Uretim Yilina Gore Ara");
                    Console.WriteLine("3.Fiyatina Gore Ara");
                    Console.WriteLine("4.Tum Otomobilleri Listele");
                    Console.WriteLine("0.Ana Menuye Don");


                    Console.WriteLine("-----------------------------------------------------");
                    Console.Write("Seciminiz:");
                    secim2 = Convert.ToInt32(Console.ReadLine());

                        //Markaya gore
                    if (secim2 == 1)
                    {
                        Console.Write("Marka giriniz:");
                        marka = Console.ReadLine();
                        OtomobilMarkaListele(otomobilliste, marka);
                        Console.WriteLine("-----------------------------------------------------");
                    }
                        //Yila gore
                    if (secim2 == 2) 
                    { 
                        Console.Write("Uretim yili giriniz:");
                        yil = Convert.ToInt32(Console.ReadLine());
                        OtomobilYilaGoreListele(otomobilliste, yil);
                        Console.WriteLine("-----------------------------------------------------");
                    }
                        //Fiyata gore
                    if (secim2 == 3) 
                    {
                        int alt,ust;
                        Console.Write("Fiyat alt sinirini giriniz:");
                        alt = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Fiyat ust sinirini giriniz:");
                        ust = Convert.ToInt32(Console.ReadLine());
                        OtomobilFiyataGoreListele(otomobilliste,alt,ust);
                        Console.WriteLine("-----------------------------------------------------");
                    
                    }
                    //tum otomobilleri listele
                    if (secim2 == 4) { OtomobilListele(otomobilliste); }
                        //bir ust menuye donme
                    if (secim2 == 0) { break; }
                        //hatali secim
                    else if (secim2 != 1 && secim2 != 2 && secim2 != 3 && secim2 != 4 && secim2 != 0) 
                         { Console.WriteLine("Hatali giris"); }
                    
                    }
                }
                //zam uygulama
                if (secim == 4) 
                {
                    Console.Write("Zam orani giriniz:");
                    zam = Convert.ToInt32(Console.ReadLine());
                    OtomobilZamYap(otomobilliste, zam);
                    Console.WriteLine("-----------------------------------------------------");
                }
                //indirim uygulama
                if (secim == 5)
                {
                    Console.Write("Indirim orani giriniz:");
                    indirim = Convert.ToInt32(Console.ReadLine());
                    OtomobilIndirimYap(otomobilliste, indirim);
                   
                    Console.WriteLine("-----------------------------------------------------");
                }
                //cikis yapma
                if (secim == 0) { break; }
                //hatali secim
                if (secim != 1 && secim != 2 && secim != 3 && secim != 4 && secim != 5  && secim != 0) { Console.WriteLine("Hatali giris"); }
                
            }

            Console.WriteLine();
        }

        //METODLARIM

        public static void OtomobilListele(List<Otomobil> otomobil)
        {
            Console.WriteLine("-----------------------Otomobiller-------------------");
            for (int i = 0; i < otomobil.Count; i++)
            {

                otomobil[i].BilgileriYazdir();

            }

        }
        public static void OtomobilMarkaListele(List<Otomobil> otomobil,string marka)
        {
            Console.WriteLine("-----------------------Otomobiller-------------------");
            for (int i = 0; i < otomobil.Count; i++)
            {
                if (otomobil[i].marka == marka)
                {
                    otomobil[i].BilgileriYazdir();
                }
            }

        }
        public static void OtomobilYilaGoreListele(List<Otomobil> otomobil, int yil)
        {
            Console.WriteLine("-----------------------Otomobiller-------------------");
            
            for (int i = 0; i < otomobil.Count; i++)
            {
                if (otomobil[i].yil >= yil)
                {
                    otomobil[i].BilgileriYazdir();
                }

            }


        }
        public static void OtomobilFiyataGoreListele(List<Otomobil> otomobil, int a, int b)
        {
            Console.WriteLine("-----------------------Otomobiller-------------------");

            for (int i = 0; i < otomobil.Count; i++)
            {
                if (otomobil[i].fiyat > a && otomobil[i].fiyat < b)
                {
                    otomobil[i].BilgileriYazdir();
                }
            }
        }
        public static void OtomobilSil(List<Otomobil> otomobil)
        {
            
            Console.WriteLine("-----------------------Otomobiller-------------------");
            for (int i = 0; i < otomobil.Count; i++)
            {
                Console.Write((i+1)+".");
                otomobil[i].BilgileriYazdir();
                
            }
            int sira;
            Console.Write("Silmek istediginiz otomobilin sira numarasini giriniz (Ana menuye donmek icin 0 giriniz):");
            sira = Convert.ToInt32(Console.ReadLine());





            if (sira > otomobil.Count) { Console.WriteLine("Hatali giris"); OtomobilSil(otomobil); }
            if (sira > 0 && (sira <= (otomobil.Count)))
            {
                otomobil.RemoveAt((sira - 1));
                Console.WriteLine("Otomobil silindi...");
                OtomobilSil(otomobil); 
            }
           


        }

        public static void OtomobilZamYap(List<Otomobil> otomobil, int zamorani)
        {
            if (zamorani > 1 && zamorani < 20)
            {

                for (int i = 0; i < otomobil.Count; i++)
                {
                    otomobil[i].setFiyat((otomobil[i].getFiyat()) * (100 + zamorani) / 100);


                }
                Console.WriteLine("Tum otomobillere %{0} oraninda zam uygulandi.", zamorani);
            }
            else { Console.WriteLine("Zam orani % 1 ile % 20 arasinda olmalidir. Islem iptal edildi"); }
        }
        public static void OtomobilIndirimYap(List<Otomobil> otomobil, int indirimorani)
        {
            if (indirimorani > 5 && indirimorani < 30)
            {

                for (int i = 0; i < otomobil.Count; i++)
                {
                    otomobil[i].setFiyat((otomobil[i].getFiyat()) * (100 - indirimorani) / 100);


                }
                Console.WriteLine("Tum otomobillere %{0} oraninda indirim uygulandi.", indirimorani);
            }
            else { Console.WriteLine("Indirim orani % 5 ile % 30 arasinda olmalidir. Islem iptal edildi"); }
        }
    }

}
