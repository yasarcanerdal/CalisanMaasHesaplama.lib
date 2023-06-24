using CalisanMaasHesaplama.Lib;

namespace CalisanMaasHesapla.App
{
    class Program
    {
        static void Main()
        {
            //BasePersonel base1 = new BasePersonel();

            //base1.Adi = "Yaşar Can";
            //base1.Soyadi = "Erdal";
            //base1.SicilNumarasi = -123456789;
            //base1.AylikÜcret = 20000;
            //base1.İzin = -5;

            //BasePersonel base1 = new BasePersonel("Yaşar Can", "Erdal", -123456789, 20000, -5);

            //Console.WriteLine(base1.BasePersonelBilgileriniGetir());

            BasePersonel kadrolu1 = new KadroluPersonel(1234, "yasar can", "erdal", 10000, 6);
            Console.WriteLine(kadrolu1.AdSoyadGetir()+"\n" + "Maas : "+ kadrolu1.AylikGetir()+"\n".ToString());
            
            BasePersonel kadrolu2 = new KadroluPersonel(1234, "emre", "kaya", 15000, 2);
            Console.WriteLine(kadrolu2.AdSoyadGetir() + "\n" + "Maas : " + kadrolu2.AylikGetir()+"\n".ToString());

            BasePersonel sözlesmeli1 = new SözlesmeliPersonel(1234, "tahir", "köse", 700, 6);
            Console.WriteLine(sözlesmeli1.AdSoyadGetir() + "\n" + "Maas : " + sözlesmeli1.AylikGetir()+"\n".ToString());

            BasePersonel sözlesmeli2 = new SözlesmeliPersonel(1234, "kaan", "erdal", 700, 2);
            Console.WriteLine(sözlesmeli2.AdSoyadGetir() + "\n" + "Maas : " + sözlesmeli2.AylikGetir()+"\n".ToString());

            BasePersonel stajyer1 = new StajyerPersonel(1234, "samet", "ince", 500, 2);
            Console.WriteLine(stajyer1.AdSoyadGetir() + "\n" + "Maas : " + stajyer1.AylikGetir()+"\n".ToString());

            BasePersonel stajyer2 = new StajyerPersonel(1234, "ömer", "erdem", 500, 6);
            Console.WriteLine(stajyer2.AdSoyadGetir() + "\n" + "Maas : " + stajyer2.AylikGetir()+"\n".ToString());






        }
    }
}
