Console.WriteLine("*********Matematik Oyununa Hoş Geldiniz*********");
Console.Write("Kullanıcı Adınızı Giriniz : ");
string userName = Console.ReadLine();
Random myk = new Random();
int sayi1, sayi2, islemNo, sonuc, puan = 0, kullaniciCevabi, yanlis = 5, temp = 0, sayac = 0;
string cevap = string.Empty;
bool kontrol = false;
string seviyeGecisBilgisi = "Tebrikler Bir Üst Seviyeye Geçtiniz";
string yanlisBilgisi = "Kalan Hakkınız : ";
int[] puanlar = new int[0];
string basari = "Tebrikler Kendi Rekorunuzu Kırdınız...";
string tekrar = string.Empty;

Console.WriteLine($"{userName}, HOŞGELDİNİZ.");

do
{
    Console.WriteLine("Şu Anda 1. Seviyedesiniz");
    do
    {
        sayi1 = myk.Next(-99, 100);
        sayi2 = myk.Next(-99, 100);
        islemNo = myk.Next(1, 3);
        if (islemNo == 1)
        {
            Console.WriteLine($"({sayi1})+({sayi2})=?");
            Console.Write("Cevap : ");
            cevap = Console.ReadLine();
            sonuc = Myk.Toplama(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine("Oyundan Çıkılıyor");
                break;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (sonuc == kullaniciCevabi)
                    {
                        Console.WriteLine("Tebrikler Cevabınız Doğru");
                        puan += 5;
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm Cevabınız Hatalıdır");
                        yanlis--;
                        Console.WriteLine(yanlisBilgisi + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                }
            }
        }

        else if (islemNo == 2)
        {
            Console.WriteLine($"({sayi1})-({sayi2})=?");
            Console.Write("Cevap : ");
            cevap = Console.ReadLine();
            sonuc = Myk.Cikarma(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine("Oyundan Çıkılıyor");
                break;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (sonuc == kullaniciCevabi)
                    {
                        Console.WriteLine("Tebrikler Cevabınız Doğru");
                        puan += 5;
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm Cevabınız Hatalıdır");
                        yanlis--;
                        Console.WriteLine(yanlisBilgisi + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                }
            }
        }
    } while ((cevap != "exit" || cevap != "EXIT") && (puan < 30) && (yanlis >= 1));

    if (cevap != "exit" && cevap != "EXIT")
    {
        Console.WriteLine(seviyeGecisBilgisi);
        Console.WriteLine("2. Seviyedesiniz...");
    }

    while (puan >= 30 && puan < 80 && yanlis >= 1)
    {
        sayi1 = myk.Next(-999, 1000);
        sayi2 = myk.Next(-999, 1000);
        islemNo = myk.Next(1, 5);
        if (islemNo == 1)
        {
            Console.WriteLine($"({sayi1})+({sayi2})=?");
            Console.Write("Cevap : ");
            cevap = Console.ReadLine();
            sonuc = Myk.Toplama(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine("Oyundan Çıkılıyor");
                break;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (sonuc == kullaniciCevabi)
                    {
                        Console.WriteLine("Tebrikler Cevabınız Doğru");
                        puan += 10;
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm Cevabınız Hatalıdır");
                        yanlis--;
                        Console.WriteLine(yanlisBilgisi + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                }
            }
        }

        else if (islemNo == 2)
        {
            Console.WriteLine($"({sayi1})-({sayi2})=?");
            Console.Write("Cevap : ");
            cevap = Console.ReadLine();
            sonuc = Myk.Cikarma(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine("Oyundan Çıkılıyor");
                break;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (sonuc == kullaniciCevabi)
                    {
                        Console.WriteLine("Tebrikler Cevabınız Doğru");
                        puan += 10;
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm Cevabınız Hatalıdır");
                        yanlis--;
                        Console.WriteLine(yanlisBilgisi + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                }
            }
        }

        else if (islemNo == 3)
        {
            Console.WriteLine($"({sayi1})x({sayi2})=?");
            Console.Write("Cevap : ");
            cevap = Console.ReadLine();
            sonuc = Myk.Carpma(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine("Oyundan Çıkılıyor");
                break;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (sonuc == kullaniciCevabi)
                    {
                        Console.WriteLine("Tebrikler Cevabınız Doğru");
                        puan += 10;
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm Cevabınız Hatalıdır");
                        yanlis--;
                        Console.WriteLine(yanlisBilgisi + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                }
            }
        }

        else if (islemNo == 4)
        {
            Console.WriteLine($"({sayi1})/({sayi2})=?");
            Console.Write("Cevap : ");
            cevap = Console.ReadLine();
            sonuc = Myk.Bolme(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine("Oyundan Çıkılıyor");
                break;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (sonuc == kullaniciCevabi)
                    {
                        Console.WriteLine("Tebrikler Cevabınız Doğru");
                        puan += 10;
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm Cevabınız Hatalıdır");
                        yanlis--;
                        Console.WriteLine(yanlisBilgisi + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                }
            }
        }
    }

    if (cevap != "exit" && cevap != "EXIT")
    {
        Console.WriteLine(seviyeGecisBilgisi);
        Console.WriteLine("3. Seviyedesiniz...");
    }

    while (puan >= 80 && yanlis >= 1)
    {
        sayi1 = myk.Next(-9999, 10000);
        sayi2 = myk.Next(-9999, 10000);
        islemNo = myk.Next(1, 6);
        if (islemNo == 1)
        {
            Console.WriteLine($"({sayi1})+({sayi2})=?");
            Console.Write("Cevap : ");
            cevap = Console.ReadLine();
            sonuc = Myk.Toplama(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine("Oyundan Çıkılıyor");
                break;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (sonuc == kullaniciCevabi)
                    {
                        Console.WriteLine("Tebrikler Cevabınız Doğru");
                        puan += 20;
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm Cevabınız Hatalıdır");
                        yanlis--;
                        Console.WriteLine(yanlisBilgisi + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                }
            }
        }

        else if (islemNo == 2)
        {
            Console.WriteLine($"({sayi1})-({sayi2})=?");
            Console.Write("Cevap : ");
            cevap = Console.ReadLine();
            sonuc = Myk.Cikarma(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine("Oyundan Çıkılıyor");
                break;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (sonuc == kullaniciCevabi)
                    {
                        Console.WriteLine("Tebrikler Cevabınız Doğru");
                        puan += 20;
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm Cevabınız Hatalıdır");
                        yanlis--;
                        Console.WriteLine(yanlisBilgisi + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                }
            }
        }

        else if (islemNo == 3)
        {
            Console.WriteLine($"({sayi1})x({sayi2})=?");
            Console.Write("Cevap : ");
            cevap = Console.ReadLine();
            sonuc = Myk.Carpma(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine("Oyundan Çıkılıyor");
                break;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (sonuc == kullaniciCevabi)
                    {
                        Console.WriteLine("Tebrikler Cevabınız Doğru");
                        puan += 20;
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm Cevabınız Hatalıdır");
                        yanlis--;
                        Console.WriteLine(yanlisBilgisi + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                }
            }
        }

        else if (islemNo == 4)
        {
            Console.WriteLine($"({sayi1})/({sayi2})=?");
            Console.Write("Cevap : ");
            cevap = Console.ReadLine();
            sonuc = Myk.Bolme(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine("Oyundan Çıkılıyor");
                break;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (sonuc == kullaniciCevabi)
                    {
                        Console.WriteLine("Tebrikler Cevabınız Doğru");
                        puan += 20;
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm Cevabınız Hatalıdır");
                        yanlis--;
                        Console.WriteLine(yanlisBilgisi + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                }
            }
        }

        else if (islemNo == 5)
        {
            Console.WriteLine($"({sayi1})=? mod({sayi2})");
            Console.Write("Cevap : ");
            cevap = Console.ReadLine();
            sonuc = Myk.Mod(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine("Oyundan Çıkılıyor");
                break;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (sonuc == kullaniciCevabi)
                    {
                        Console.WriteLine("Tebrikler Cevabınız Doğru");
                        puan += 20;
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm Cevabınız Hatalıdır");
                        yanlis--;
                        Console.WriteLine(yanlisBilgisi + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                }
            }
        }
    }

    Console.WriteLine(userName + " Puanınız : " + puan);
    Array.Resize(ref puanlar, puanlar.Length + 1);
    puanlar[puanlar.Length - 1] = puan;

    if (puan > temp)
    {
        temp = puan;
        Console.WriteLine(basari);
    }


    if (yanlis == 0)
    {
        Console.WriteLine("Tekrar Oynamak İstermisiniz : (E/H)");
        tekrar = Console.ReadLine();
    }

    yanlis = 5;
    puan = 0;
    sayac++;

} while (tekrar == "e" || tekrar == "E");

if (tekrar == "h" || tekrar == "H")
{
    Array.Sort(puanlar);
    Array.Reverse(puanlar);
    Console.WriteLine("***** Tekrar Görüşmek Üzere *****");
    Console.WriteLine("Toplam Oyun Sayınız : " + sayac + " En Yüksek Puanınız : " + puanlar[0]);
    Console.WriteLine("Uygulama Kapanıyor...");
}
else if (cevap == "exit" || cevap == "EXIT")
{
    Console.WriteLine("Uygulama Kapanıyor...");
}
else
{
    Console.WriteLine("Geçersiz Giriş Yaptınız...");
    Console.WriteLine("Uygulama Kapanıyor...");
}

Console.ReadKey();

class Myk
{
    public static int Toplama(int x, int y)
    {
        return x + y;
    }

    public static int Cikarma(int x, int y)
    {
        return x - y;
    }

    public static int Carpma(int x, int y)
    {
        return x * y;
    }

    public static int Bolme(int x, int y)
    {
        return x / y;
    }

    public static int Mod(int x, int y)
    {
        return x % y;
    }
}
