//DONT REPEAT YOURSELF
using Metotlar;

class Program
{
    static void Main(string[] args)
    {

        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya Elması";
        urun1.StokAdedi = 12;



        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 80;
        urun2.Aciklama = "Diyarbakır karpuzu";
        urun2.StokAdedi = 10;

        Urun[] urunler = new Urun[] { urun1, urun2, };

        foreach (Urun urun in urunler)
        {

            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine(urun.StokAdedi);
            Console.WriteLine("-------------------");
        }
        Console.WriteLine("----------Metotlar-----------");
        //encapsulation
        //instance - örnek
        SepetMenager sepetMenager = new SepetMenager();

        sepetMenager.Ekle(urun1);
        sepetMenager.Ekle(urun2);
        sepetMenager.Ekle2("Armut", "yeşil armut", 12,10);
        sepetMenager.Ekle2("Elme", "yeşil Elma", 12,9);
        sepetMenager.Ekle2("karpuz", "diyarbakır karpuzu", 12,8);
    }

}


