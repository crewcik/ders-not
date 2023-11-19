using System;

class Crew
{
    static void Main()
    {
        string[,] crew =
        {
    {"1", "Ali", "20", "50", "60", "80", "70", "90"},
    {"2", "Ayşe", "50", "60", "70", "80", "20", "50" },
    {"3", "Tarık", "40", "50", "60", "80", "70", "90" },
    {"4", "Kerem", "40", "50", "60", "50", "40", "80" },
    {"5", "İbrahim", "50", "60", "70", "80", "90", "90" },
    {"6", "Ahmet", "50", "40", "60", "70", "80", "50" },
    {"7", "Fatma", "40", "50", "60", "80", "70", "80" },
    {"8", "Selma", "50", "60", "40", "50", "60", "80" },
    {"9", "Hüseyin", "60", "80", "70", "80", "50", "60" },
    {"10", "Yiğit", "70", "95", "98", "76", "100", "100" },
};

        string[] dersler =
        {
            "Matematik",
            "Türk Dili",
            "İngilizce",
            "Grafik",
            "Programlama",
            "Tarih"
        };

        Console.Write("Öğrenci no: ");
        string girilen_deger = Console.ReadLine();

        Console.WriteLine("Ders belirtin: ");
        string girilen_ders = Console.ReadLine();
        for (int i = 0; i < crew.GetLength(0); i++)
        {
            for (int j = 0; j < dersler.Length; j++)
            {
                if (girilen_deger == crew[i, 0] && girilen_ders == dersler[j])
                {
                    Console.WriteLine("Öğrenci: " + crew[i, 1] + "\nGirilen Ders: " + dersler[j] + "\nVize Notu: " + crew[i, j + 2]);
                    Console.ReadKey();
                }
            }
        }
    }
}
