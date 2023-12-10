using System;

class Program
{
    static void Main()
    {
        double toplam = 0;

        while (true)
        {
            Console.Write("Bir sayı girin (Çıkış için 83): ");
            string girilenSayi = Console.ReadLine();

            // Kullanıcı 83 girdiyse döngüden çık
            if (girilenSayi == "83")
                break;//döngüyü sonlandır.

            // Sayıyı double'a çevirme işlemi
            if (double.TryParse(girilenSayi, out double sayi))
            {
                toplam += sayi;
            }
            else
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen tekrar deneyin.");
            }
        }

        Console.WriteLine($"Toplam Sonuç: {toplam}");
    }
}
