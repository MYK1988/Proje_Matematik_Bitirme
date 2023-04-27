Console.WriteLine("*********Matematik Oyununa Hoş Geldiniz*********");
Console.Write("Kullanıcı Adınızı Giriniz : ");
string userName = Console.ReadLine();
Console.WriteLine($"{userName}, Hoşgeldin. Herhangi bir anda 'exit' yazarak çıkış yapabilirsin.");
int islemNo = 0, sayi1 = 0, sayi2 = 0, kullaniciCevabi = 0, sonuc, puan = 0, yanlis = 5,temp=0,sayac=0;
string cevap = string.Empty;
bool kontrol = false;
bool flag = false;
int[] puanlar=new int[0];
string basari = "Tebrikler Kendi Rekorunu Kırdın...";
string cikis = "Oyundan Çıkılıyor";
string dogruCevap = "Tebrikler Cevabın Doğru, Puanın : ";
string yanlisCevap = "Üzgünüm Cevabın Hatalı. Kalan Hakkın : ";
string hata = "Hatalı Giriş Yaptınız";


do
{

    // 1.Seviye
    do
    {
        Console.WriteLine("1. Seviyedesin");
        sayi1 = Sinifli.SayiUretimi.IkiBasamakliSayiUret(sayi1);
        sayi2 = Sinifli.SayiUretimi.IkiBasamakliSayiUret(sayi2);
        islemNo = Sinifli.SeviyeNo.BirinciSeviye(islemNo);
        if (islemNo == 1)
        {
            Console.WriteLine($"({sayi1})+({sayi2})= ?");
            Console.Write("Cevabınız : ");
            cevap = Console.ReadLine();
            sonuc = Sinifli.MatematikselIslemler.Toplama(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine(cikis);
                flag = true;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (kullaniciCevabi == sonuc)
                    {
                        puan += 5;
                        Console.WriteLine($"{dogruCevap} {puan}");
                    }
                    else
                    {
                        yanlis--;
                        Console.WriteLine($"{yanlisCevap} {yanlis}");
                    }
                }
                else
                {
                    Console.WriteLine(hata);
                }


            }
        }

        else if (islemNo == 2)
        {
            Console.WriteLine($"({sayi1})-({sayi2})= ?");
            Console.Write("Cevabınız : ");
            cevap = Console.ReadLine();
            sonuc = Sinifli.MatematikselIslemler.Cikarma(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine(cikis);
                flag = true;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (kullaniciCevabi == sonuc)
                    {
                        puan += 5;
                        Console.WriteLine($"{dogruCevap} {puan}");
                    }
                    else
                    {
                        yanlis--;
                        Console.WriteLine($"{yanlisCevap} {yanlis}");
                    }
                }
                
                else
                {
                Console.WriteLine(hata);
            }


            }
        }

    } while (puan < 30 && yanlis >= 1 && !flag);

    //2. Seviye
    while (!flag && puan >= 30 && puan < 80 && yanlis >= 1)
    {
        Console.WriteLine("2. Seviyedesin");
        sayi1 = Sinifli.SayiUretimi.UcBasamakliSayiUret(sayi1);
        sayi2 = Sinifli.SayiUretimi.UcBasamakliSayiUret(sayi2);
        islemNo = Sinifli.SeviyeNo.IkinciSeviye(islemNo);
        if (islemNo == 1)
        {
            Console.WriteLine($"({sayi1})+({sayi2})= ?");
            Console.Write("Cevabınız : ");
            cevap = Console.ReadLine();
            sonuc = Sinifli.MatematikselIslemler.Toplama(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine(cikis);
                flag = true;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (kullaniciCevabi == sonuc)
                    {
                        puan += 5;
                        Console.WriteLine($"{dogruCevap} {puan}");
                    }
                    else
                    {
                        yanlis--;
                        Console.WriteLine($"{yanlisCevap} {yanlis}");
                    }
                }
                else
                {
                    Console.WriteLine(hata);
                }
            }
        }

        else if (islemNo == 2)
        {
            Console.WriteLine($"({sayi1})-({sayi2})= ?");
            Console.Write("Cevabınız : ");
            cevap = Console.ReadLine();
            sonuc = Sinifli.MatematikselIslemler.Cikarma(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine(cikis);
                flag = true;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (kullaniciCevabi == sonuc)
                    {
                        puan += 5;
                        Console.WriteLine($"{dogruCevap} {puan}");
                    }
                    else
                    {
                        yanlis--;
                        Console.WriteLine($"{yanlisCevap} {yanlis}");
                    }
                }
                else
                {
                    Console.WriteLine(hata);
                }
            }
        }

        else if (islemNo == 3)
        {
            Console.WriteLine($"({sayi1})x({sayi2})= ?");
            Console.Write("Cevabınız : ");
            cevap = Console.ReadLine();
            sonuc = Sinifli.MatematikselIslemler.Carpma(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine(cikis);
                flag = true;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (kullaniciCevabi == sonuc)
                    {
                        puan += 5;
                        Console.WriteLine($"{dogruCevap} {puan}");
                    }
                    else
                    {
                        yanlis--;
                        Console.WriteLine($"{yanlisCevap} {yanlis}");
                    }
                }
                else
                {
                    Console.WriteLine(hata);
                }
            }
        }

        else if (islemNo == 4)
        {
            Console.WriteLine($"({sayi1})/({sayi2})= ?");
            Console.Write("Cevabınız : ");
            cevap = Console.ReadLine();
            sonuc = Sinifli.MatematikselIslemler.Bolme(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine(cikis);
                flag = true;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (kullaniciCevabi == sonuc)
                    {
                        puan += 5;
                        Console.WriteLine($"{dogruCevap} {puan}");
                    }
                    else
                    {
                        yanlis--;
                        Console.WriteLine($"{yanlisCevap} {yanlis}");
                    }
                }
                else
                {
                    Console.WriteLine(hata);
                }
            }
        }

    }

    //3. Seviye

    while (!flag && puan >= 80 && yanlis >= 1)
    {
        Console.WriteLine("3. Seviyedesin");
        sayi1 = Sinifli.SayiUretimi.DortBasamakliSayiUret(sayi1);
        sayi2 = Sinifli.SayiUretimi.DortBasamakliSayiUret(sayi2);
        islemNo = Sinifli.SeviyeNo.UcuncuSeviye(islemNo);

        if (islemNo == 1)
        {
            Console.WriteLine($"({sayi1})+({sayi2})= ?");
            Console.Write("Cevabınız : ");
            cevap = Console.ReadLine();
            sonuc = Sinifli.MatematikselIslemler.Toplama(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine(cikis);
                flag = true;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (kullaniciCevabi == sonuc)
                    {
                        puan += 5;
                        Console.WriteLine($"{dogruCevap} {puan}");
                    }
                    else
                    {
                        yanlis--;
                        Console.WriteLine($"{yanlisCevap} {yanlis}");
                    }
                }
                else
                {
                    Console.WriteLine(hata);
                }
            }
        }

        else if (islemNo == 2)
        {
            Console.WriteLine($"({sayi1})-({sayi2})= ?");
            Console.Write("Cevabınız : ");
            cevap = Console.ReadLine();
            sonuc = Sinifli.MatematikselIslemler.Cikarma(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine(cikis);
                flag = true;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (kullaniciCevabi == sonuc)
                    {
                        puan += 5;
                        Console.WriteLine($"{dogruCevap} {puan}");
                    }
                    else
                    {
                        yanlis--;
                        Console.WriteLine($"{yanlisCevap} {yanlis}");
                    }
                }
                else
                {
                    Console.WriteLine(hata);
                }
            }
        }

        else if (islemNo == 3)
        {
            Console.WriteLine($"({sayi1})x({sayi2})= ?");
            Console.Write("Cevabınız : ");
            cevap = Console.ReadLine();
            sonuc = Sinifli.MatematikselIslemler.Carpma(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine(cikis);
                flag = true;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (kullaniciCevabi == sonuc)
                    {
                        puan += 5;
                        Console.WriteLine($"{dogruCevap} {puan}");
                    }
                    else
                    {
                        yanlis--;
                        Console.WriteLine($"{yanlisCevap} {yanlis}");
                    }
                }
                else
                {
                    Console.WriteLine(hata);
                }
            }
        }

        else if (islemNo == 4)
        {
            Console.WriteLine($"({sayi1})/({sayi2})= ?");
            Console.Write("Cevabınız : ");
            cevap = Console.ReadLine();
            sonuc = Sinifli.MatematikselIslemler.Bolme(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine(cikis);
                flag = true;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (kullaniciCevabi == sonuc)
                    {
                        puan += 5;
                        Console.WriteLine($"{dogruCevap} {puan}");
                    }
                    else
                    {
                        yanlis--;
                        Console.WriteLine($"{yanlisCevap} {yanlis}");
                    }
                }
                else
                {
                    Console.WriteLine(hata);
                }
            }
        }

        else if (islemNo == 5)
        {
            Console.WriteLine($"({sayi1}) = ? Mod({sayi2})");
            Console.Write("Cevabınız : ");
            cevap = Console.ReadLine();
            sonuc = Sinifli.MatematikselIslemler.Mod(sayi1, sayi2);
            if (cevap == "exit" || cevap == "EXIT")
            {
                Console.WriteLine(cikis);
                flag = true;
            }
            else
            {
                kontrol = int.TryParse(cevap, out kullaniciCevabi);
                if (kontrol)
                {
                    if (kullaniciCevabi == sonuc)
                    {
                        puan += 5;
                        Console.WriteLine($"{dogruCevap} {puan}");
                    }
                    else
                    {
                        yanlis--;
                        Console.WriteLine($"{yanlisCevap} {yanlis}");
                    }
                }
                else
                {
                    Console.WriteLine(hata);
                }
            }
        }

    }

    Console.WriteLine(userName + " Puanın : " + puan);
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
        cevap = Console.ReadLine();
    }

    yanlis = 5;
    puan = 0;
    sayac++;

} while (cevap=="e"||cevap=="E");

do
{
    if (cevap == "h" || cevap == "H")
    {
        Array.Sort(puanlar);
        Console.WriteLine("Toplam Oyun Sayın : " + sayac + " En Yüksek Puanın : " + puanlar[puanlar.Length - 1]);
        Console.WriteLine("Uygulama Kapanıyor...");
        break;
    }
    else
    {
        Console.WriteLine("Hatalı Giriş Yaptınız");
        break;
    }
} while (cevap != "e" || cevap != "E");




//while (cevap!="e" || cevap != "E") 
//{
//    if (cevap == "h" || cevap == "H")
//    {
//        Array.Sort(puanlar);
//        Console.WriteLine("Toplam Oyun Sayın : " + sayac + " En Yüksek Puanın : " + puanlar[puanlar.Length - 1]);
//        Console.WriteLine("Uygulama Kapanıyor...");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Hatalı Giriş Yaptınız");
//        break;
//    }

//}







Console.ReadKey();