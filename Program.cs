//Q1
Console.WriteLine("Merhaba");
Console.WriteLine("Nasılsın?");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen nasılsın?");

//Q2
using System;

class Program
{
    static void Main()
    {
        string metin = "Merhaba, dünya!";
        int sayi = 32;

        Console.WriteLine(metin);
        Console.WriteLine(sayi);
    }
}

//Q3
using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int rastgeleSayi = rnd.Next();
        Console.WriteLine(rastgeleSayi);
    }
}

//Q4
using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int rastgeleSayi = rnd.Next();
        Console.WriteLine(rastgeleSayi % 3);
    }
}


//Q5
using System;

class Program
{
    static void Main()
    {
        Console.Write("Yaşınızı girin: ");
        int yas = Convert.ToInt32(Console.ReadLine());

        if (yas > 18)
            Console.WriteLine("+");
        else
            Console.WriteLine("-");
    }
}

//Q6
for (int i = 0; i < 10; i++)
{
	Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
}

//Q7
Console.Write("Ad 1: ");
string ad1 = Console.ReadLine();

Console.Write("Ad 2: ");
string ad2 = Console.ReadLine();

Console.WriteLine($"Değişimden önce : {ad1} ve {ad2}");
string yedek = ad1;
ad1 = ad2;
ad2 = yedek;

Console.WriteLine($"Değişimden sonra: {ad1} ve {ad2}");

//Q8
using System;

class Program
{
    static void Main()
    {
        BenDegerDondurmem();
    }

    static void BenDegerDondurmem()
    {
        Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
    }
}


//Q9
using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        int toplam = Topla(sayi1, sayi2);
        Console.WriteLine($"Toplam: {toplam}");
    }

    static int Topla(int a, int b)
    {
        return a + b;
    }
}

//Q10
using System;

class Program
{
    static void Main()
    {
        Console.Write("Lütfen true ya da false girin: ");
        bool deger = Convert.ToBoolean(Console.ReadLine());

        string sonuc = DegerDondur(deger);
        Console.WriteLine(sonuc);
    }

    static string DegerDondur(bool deger)
    {
        return deger ? "True seçildi." : "False seçildi.";
    }
}

//Q11
using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci kişinin yaşını girin: ");
        int yas1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci kişinin yaşını girin: ");
        int yas2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Üçüncü kişinin yaşını girin: ");
        int yas3 = Convert.ToInt32(Console.ReadLine());

        int enYasli = EnYasliBul(yas1, yas2, yas3);
        Console.WriteLine($"En yaşlı kişi: {enYasli}");
    }

    static int EnYasliBul(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }
}

//Q12
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> sayilar = new List<int>();
        Console.WriteLine("Sayıları girin (çıkmak için 'q' yazın):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "q") break;

            if (int.TryParse(input, out int sayi))
                sayilar.Add(sayi);
            else
                Console.WriteLine("Geçersiz sayı, tekrar deneyin.");
        }

        int enBuyuk = EnBuyukBul(sayilar);
        Console.WriteLine($"En büyük sayı: {enBuyuk}");
    }

    static int EnBuyukBul(List<int> sayilar)
    {
        int max = sayilar[0];
        foreach (int sayi in sayilar)
        {
            if (sayi > max)
                max = sayi;
        }
        return max;
    }
}

//Q13
using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci ismi girin: ");
        string isim1 = Console.ReadLine();
        Console.Write("İkinci ismi girin: ");
        string isim2 = Console.ReadLine();

        (isim1, isim2) = (isim2, isim1);
        Console.WriteLine($"Değiştirilmiş isimler: {isim1}, {isim2}");
    }
}

//Q14
Console.Write("Bir sayı: ");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CiftMi(sayi) ? "Çift" : "Tek");

//Q15
using System;

class Program
{
    static void Main()
    {
        Console.Write("Hızı girin (km/s): ");
        double hiz = Convert.ToDouble(Console.ReadLine());
        Console.Write("Zamanı girin (saat): ");
        double zaman = Convert.ToDouble(Console.ReadLine());

        double yol = HesaplaYol(hiz, zaman);
        Console.WriteLine($"Gidilen yol: {yol} km");
    }

    static double HesaplaYol(double hiz, double zaman)
    {
        return hiz * zaman;
    }
}

//Q16
using System;

class Program
{
    static void Main()
    {
        Console.Write("Dairenin yarıçapını girin: ");
        double yaricap = Convert.ToDouble(Console.ReadLine());

        double alan = DaireAlaniHesapla(yaricap);
        Console.WriteLine($"Dairenin alanı: {alan}");
    }

    static double DaireAlaniHesapla(double yaricap)
    {
        return Math.PI * Math.Pow(yaricap, 2);
    }
}
//Q17
string cumle = "Zaman bir GeRi SayIm";

Console.WriteLine(cumle.ToUpper());
Console.WriteLine(cumle.ToLower());

//Q18
string metin = "    Selamlar   ";
metin = metin.Trim();
Console.WriteLine(metin);
