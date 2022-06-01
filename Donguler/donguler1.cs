class donguler1

{
    static void Main(string[] args)
    {
        string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
        string kurs2 = "Programlamaya Başlangıç için Temel kurs";
        string kurs3 = "java";

        string[] kurslar = new string[] { kurs1, kurs2, kurs3 };

        Console.WriteLine(kurslar[2]);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(kurslar[i]);

        }

        Console.WriteLine("FOR BİTTİ ");
        foreach (string kurs in kurslar)
        {
            Console.Write(kurs);
        }
    }
}