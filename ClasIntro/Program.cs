class ClasIntro
{
    static void Main(string[] args)
    {
        string adi = "Enes";
        int yas = 22;

        Kurs kurs1=new Kurs();
        kurs1.KursAdi = "c#";
        kurs1.izlenmeOranı = 68;
        kurs1.egitmen = "engin";
        Console.WriteLine(kurs1.KursAdi + kurs1.egitmen);
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOranı { get; set; }
         

    }
}