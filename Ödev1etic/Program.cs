using System;
using Ödev1etic;
//Bir Ürün listesi oluşturup farklı döngülerle ekrana yazdırma programı
class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product();

        product1.Id = 1;
        product1.UrunAdi = "Telefon";
        product1.UrunAciklamasi = "İphone7 32 GB Hafızalı Telefon";
        

        Product product2 = new Product();
        product2.Id = 2;
        product2.UrunAdi = "Bilgisayar";
        product2.UrunAciklamasi = "MSI GF75 8GB RAM 256GB SSD İNTEL İ7 TAŞINABİLİR BİLGİSAYAR ";


        Product product3 = new Product();
        product3.Id = 3;
        product3.UrunAdi = "Mouse";
        product3.UrunAciklamasi = "RGB ÖZELLİKLİ MOUSE ";

        // 3 ürünümüz olduğu için ürünlerimizi bir liste içinde tuttuk,liste ismimiz ise ürünlerdir.
        Product [] urunler = new Product[]  {product1, product2, product3};
        //Ürünlerimizi for döngüsü ile yazdırdık
        for (int i = 0; i < urunler.Length; i++)
        {
            Console.WriteLine(urunler[i].Id + "\n" + urunler[i].UrunAdi + "\n" + urunler[i].UrunAciklamasi + "\n");
            Console.WriteLine("------------------------------");
        }

        //Listelerde Genellelikle foreach döngüsü kullanıldıgından ürünlerimizi foreach döngüsü kullanarak listele
        foreach (Product urunlistesi in urunler)
        {
            Console.WriteLine(urunlistesi.Id + "\n" +urunlistesi.UrunAdi+ "\n" + urunlistesi.UrunAciklamasi);
            Console.WriteLine("--------------------------");

        }



    }
}
