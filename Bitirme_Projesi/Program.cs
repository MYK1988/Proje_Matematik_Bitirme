Console.WriteLine("*********Matematik Oyununa Hoş Geldiniz*********");
Console.Write("Kullanıcı Adınızı Giriniz : ");
string userName = Console.ReadLine();
Random myk = new Random();
int sayi1, sayi2, puan = 0, yanlis = 5, sayac = 0, sonuc = 0, kullaniciSonuc, temp = 0;
string cevap = "";
string cevap2 = "";
string basari = "Tebrikler Kendi Rekorunuzu Kırdınız...";
int[] puanlar = new int[0];
bool kontrol = false, flag = false;

do
{
    Console.WriteLine("***** 1. Seviyedesiniz *****");
    do
    {
        sayi1 = myk.Next(-99, 100);
        sayi2 = myk.Next(-99, 100);
        Console.WriteLine("Aşağıdaki sayıların sonucunu yazınız :");
        int birinciSeviye = myk.Next(1, 3);
        if (birinciSeviye == 1)
        {
            Console.WriteLine($"({sayi1}) + ({sayi2}) = ? ");
            sonuc = sayi1 + sayi2;
            Console.Write("Cevabınız : ");
            cevap2 = Console.ReadLine();
            if (cevap2 == "exit" || cevap2 == "EXIT")
            {
                flag = true;
            }

            else
            {
                kontrol = int.TryParse(cevap2, out kullaniciSonuc);
                if (kontrol)
                {
                    if (sonuc == kullaniciSonuc)
                    {
                        Console.WriteLine("***** Tebrikler Cevabınız Doğrudur. *****");
                        puan += 5;
                    }
                    else
                    {
                        Console.WriteLine("***** Üzgünüm Cevabınız Hatalıdır. *****");
                        yanlis--;
                        Console.WriteLine("Kalan Hakkınız : " + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Karakter Girişi Yapıldı");
                }
            }
        }
        else
        {
            Console.WriteLine($"({sayi1}) - ({sayi2}) = ? ");
            sonuc = sayi1 - sayi2;
            Console.Write("Cevabınız : ");
            cevap2 = Console.ReadLine();
            if (cevap2 == "exit" || cevap2 == "EXIT")
            {
                break;
            }

            else
            {
                kontrol = int.TryParse(cevap2, out kullaniciSonuc);
                if (kontrol)
                {
                    if (sonuc == kullaniciSonuc)
                    {
                        Console.WriteLine("***** Tebrikler Cevabınız Doğrudur. *****");
                        puan += 5;
                    }
                    else
                    {
                        Console.WriteLine("***** Üzgünüm Cevabınız Hatalıdır. *****");
                        yanlis--;
                        Console.WriteLine("Kalan Hakkınız : " + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Karakter Girişi Yapıldı");
                }
            }
        }

    } while (!flag && (puan < 30 && yanlis >= 1));

    if (puan >= 30)
    {
        Console.WriteLine("***** TEBRİKLER SEVİYE ATLADINIZ *****");
        Console.WriteLine("***** 2. Seviyedesiniz *****");
    }

    while (!flag && (puan < 80 && puan >= 30 && yanlis >= 1))
    {
        sayi1 = myk.Next(-999, 1000);
        sayi2 = myk.Next(-999, 1000);
        Console.WriteLine("Aşağıdaki sayıların sonucunu yazınız :");
        int ikinciSeviye = myk.Next(1, 5);
        if (ikinciSeviye == 1)
        {
            Console.WriteLine($"({sayi1}) + ({sayi2}) = ? ");
            sonuc = sayi1 + sayi2;
            Console.Write("Cevabınız : ");
            cevap2 = Console.ReadLine();
            if (cevap2 == "exit" || cevap2 == "EXIT")
            {
                break;
            }

            else
            {
                kontrol = int.TryParse(cevap2, out kullaniciSonuc);
                if (kontrol)
                {
                    if (sonuc == kullaniciSonuc)
                    {
                        Console.WriteLine("***** Tebrikler Cevabınız Doğrudur. *****");
                        puan += 10;
                    }
                    else
                    {
                        Console.WriteLine("***** Üzgünüm Cevabınız Hatalıdır. *****");
                        yanlis--;
                        Console.WriteLine("Kalan Hakkınız : " + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Karakter Girişi Yapıldı");
                }
            }
        }
        else if (ikinciSeviye == 2)
        {
            Console.WriteLine($"({sayi1}) - ({sayi2}) = ? ");
            sonuc = sayi1 - sayi2;
            Console.Write("Cevabınız : ");
            cevap2 = Console.ReadLine();
            if (cevap2 == "exit" || cevap2 == "EXIT")
            {
                break;
            }

            else
            {
                kontrol = int.TryParse(cevap2, out kullaniciSonuc);
                if (kontrol)
                {
                    if (sonuc == kullaniciSonuc)
                    {
                        Console.WriteLine("***** Tebrikler Cevabınız Doğrudur. *****");
                        puan += 10;
                    }
                    else
                    {
                        Console.WriteLine("***** Üzgünüm Cevabınız Hatalıdır. *****");
                        yanlis--;
                        Console.WriteLine("Kalan Hakkınız : " + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Karakter Girişi Yapıldı");
                }
            }
        }
        else if (ikinciSeviye == 3)
        {
            Console.WriteLine($"({sayi1}) x ({sayi2}) = ? ");
            sonuc = sayi1 * sayi2;
            Console.Write("Cevabınız : ");
            cevap2 = Console.ReadLine();
            if (cevap2 == "exit" || cevap2 == "EXIT")
            {
                break;
            }

            else
            {
                kontrol = int.TryParse(cevap2, out kullaniciSonuc);
                if (kontrol)
                {
                    if (sonuc == kullaniciSonuc)
                    {
                        Console.WriteLine("***** Tebrikler Cevabınız Doğrudur. *****");
                        puan += 10;
                    }
                    else
                    {
                        Console.WriteLine("***** Üzgünüm Cevabınız Hatalıdır. *****");
                        yanlis--;
                        Console.WriteLine("Kalan Hakkınız : " + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Karakter Girişi Yapıldı");
                }
            }
        }
        else if (ikinciSeviye == 4)
        {
            Console.WriteLine($"({sayi1}) / ({sayi2}) = ? ");
            sonuc = sayi1 / sayi2;

            Console.Write("Cevabınız : ");
            cevap2 = Console.ReadLine();
            if (cevap2 == "exit" || cevap2 == "EXIT")
            {
                break;
            }

            else
            {
                kontrol = int.TryParse(cevap2, out kullaniciSonuc);
                if (kontrol)
                {
                    if (sonuc == kullaniciSonuc)
                    {
                        Console.WriteLine("***** Tebrikler Cevabınız Doğrudur. *****");
                        puan += 10;
                    }
                    else
                    {
                        Console.WriteLine("***** Üzgünüm Cevabınız Hatalıdır. *****");
                        yanlis--;
                        Console.WriteLine("Kalan Hakkınız : " + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Karakter Girişi Yapıldı");
                }
            }
        }
    }

    if (puan >= 80)
    {
        Console.WriteLine("***** TEBRİKLER SEVİYE ATLADINIZ *****");
        Console.WriteLine("***** 3. Seviyedesiniz *****");
        Console.WriteLine("Aşağıdaki sayıların sonucunu yazınız :");
    }

    while (!flag && (puan >= 80 && yanlis >= 1))
    {
        sayi1 = myk.Next(-9999, 10000);
        sayi2 = myk.Next(-9999, 10000);
        int ucuncuSeviye = myk.Next(1, 6);
        if (ucuncuSeviye == 1)
        {
            Console.WriteLine($"({sayi1}) + ({sayi2}) = ? ");
            sonuc = sayi1 + sayi2;
            Console.Write("Cevabınız : ");
            cevap2 = Console.ReadLine();
            if (cevap2 == "exit" || cevap2 == "EXIT")
            {
                break;
            }

            else
            {
                kontrol = int.TryParse(cevap2, out kullaniciSonuc);
                if (kontrol)
                {
                    if (sonuc == kullaniciSonuc)
                    {
                        Console.WriteLine("***** Tebrikler Cevabınız Doğrudur. *****");
                        puan += 20;
                    }
                    else
                    {
                        Console.WriteLine("***** Üzgünüm Cevabınız Hatalıdır. *****");
                        yanlis--;
                        Console.WriteLine("Kalan Hakkınız : " + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Karakter Girişi Yapıldı");
                }
            }
        }
        else if (ucuncuSeviye == 2)
        {
            Console.WriteLine($"({sayi1}) - ({sayi2}) = ? ");
            sonuc = sayi1 - sayi2;
            Console.Write("Cevabınız : ");
            cevap2 = Console.ReadLine();
            if (cevap2 == "exit" || cevap2 == "EXIT")
            {
                break;
            }

            else
            {
                kontrol = int.TryParse(cevap2, out kullaniciSonuc);
                if (kontrol)
                {
                    if (sonuc == kullaniciSonuc)
                    {
                        Console.WriteLine("***** Tebrikler Cevabınız Doğrudur. *****");
                        puan += 20;
                    }
                    else
                    {
                        Console.WriteLine("***** Üzgünüm Cevabınız Hatalıdır. *****");
                        yanlis--;
                        Console.WriteLine("Kalan Hakkınız : " + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Karakter Girişi Yapıldı");
                }
            }
        }
        else if (ucuncuSeviye == 3)
        {
            Console.WriteLine($"({sayi1}) x ({sayi2}) = ? ");
            sonuc = sayi1 * sayi2;
            Console.Write("Cevabınız : ");
            cevap2 = Console.ReadLine();
            if (cevap2 == "exit" || cevap2 == "EXIT")
            {
                break;
            }

            else
            {
                kontrol = int.TryParse(cevap2, out kullaniciSonuc);
                if (kontrol)
                {
                    if (sonuc == kullaniciSonuc)
                    {
                        Console.WriteLine("***** Tebrikler Cevabınız Doğrudur. *****");
                        puan += 20;
                    }
                    else
                    {
                        Console.WriteLine("***** Üzgünüm Cevabınız Hatalıdır. *****");
                        yanlis--;
                        Console.WriteLine("Kalan Hakkınız : " + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Karakter Girişi Yapıldı");
                }
            }
        }
        else if (ucuncuSeviye == 4)
        {
            Console.WriteLine($"({sayi1}) / ({sayi2}) = ? ");
            sonuc = sayi1 / sayi2;

            Console.Write("Cevabınız : ");
            cevap2 = Console.ReadLine();
            if (cevap2 == "exit" || cevap2 == "EXIT")
            {
                break;
            }

            else
            {
                kontrol = int.TryParse(cevap2, out kullaniciSonuc);
                if (kontrol)
                {
                    if (sonuc == kullaniciSonuc)
                    {
                        Console.WriteLine("***** Tebrikler Cevabınız Doğrudur. *****");
                        puan += 20;
                    }
                    else
                    {
                        Console.WriteLine("***** Üzgünüm Cevabınız Hatalıdır. *****");
                        yanlis--;
                        Console.WriteLine("Kalan Hakkınız : " + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Karakter Girişi Yapıldı");
                }
            }
        }
        else if (ucuncuSeviye == 5)
        {
            Console.WriteLine($"({sayi1})=?Mod({sayi2})");
            sonuc = sayi1 % sayi2;

            Console.Write("Cevabınız : ");
            cevap2 = Console.ReadLine();
            if (cevap2 == "exit" || cevap2 == "EXIT")
            {
                break;
            }

            else
            {
                kontrol = int.TryParse(cevap2, out kullaniciSonuc);
                if (kontrol)
                {
                    if (sonuc == kullaniciSonuc)
                    {
                        Console.WriteLine("***** Tebrikler Cevabınız Doğrudur. *****");
                        puan += 20;
                    }
                    else
                    {
                        Console.WriteLine("***** Üzgünüm Cevabınız Hatalıdır. *****");
                        yanlis--;
                        Console.WriteLine("Kalan Hakkınız : " + yanlis);
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Karakter Girişi Yapıldı");
                }
            }
        }
    }

    Console.WriteLine(userName + " puanınız : " + puan);
    Array.Resize(ref puanlar, puanlar.Length + 1);
    puanlar[puanlar.Length - 1] = puan;
    if (puan > temp)
    {
        temp = puan;
        Console.WriteLine(basari);
    }

    if (yanlis == 0)
    {

        Console.WriteLine("********** Tekrar Oynamak İstermisiniz? E/H **********");
        cevap = Console.ReadLine();
    }

    yanlis = 5;
    puan = 0;
    sayac++;

} while (cevap == "e" || cevap == "E");

if (cevap == "h" || cevap == "H")
{
    Array.Sort(puanlar);
    Array.Reverse(puanlar);
    Console.WriteLine("***** Tekrar Görüşmek Üzere *****");
    Console.WriteLine("Toplam Oyun Sayınız : " + sayac + " En Yüksek Puanınız : " + puanlar[0]);
    Console.WriteLine("Uygulama Kapanıyor...");
}
else if (cevap2 == "exit" || cevap2 == "EXIT")
{
    Console.WriteLine("Uygulama Kapanıyor...");
}
else
{
    Console.WriteLine("Geçersiz Giriş Yaptınız...");
    Console.WriteLine("Uygulama Kapanıyor...");
}
Console.ReadKey();