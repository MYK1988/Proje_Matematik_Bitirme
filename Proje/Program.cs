/* Pratik Matematik Uygulaması
Matematiksel işlemlerle pratik yapmayı sağlayan bir uygulama geliştireceksiniz.
Kullanıcılar karşılarına gelen işlemlerin cevaplarını girecekler. 
Verdikleri cevap doğru olduğunda puan kazanacaklar. Puanları arttıkça seviyeleri ilerleyecek ve karşılarına çıkan işlemler seviyelere göre değişecek.
• Uygulama kullanıcıdan ilk önce kullanıcı adını isteyecektir. ---->>>  OK
• Uygulamada geçerli matematik işlemleri toplama, çıkarma, çarpma, bölme ve mod almadır. ---->>>  OK
• Uygulamada iki sayı ve bunların tabi olacağı işlem kullanıcıya gösterilecek ve cevap girmesi beklenecektir. ---->>>  OK
• İlk seviyede sadece toplama ve çıkarma işlemleri sorulacaktır. İşlemde yer alan sayılar en fazla iki basamaklı olmalıdır. Verdikleri her doğru cevap için 5 puan kazanacaklardır.
• Kullanıcının puanı 30 olduğunda ikinci seviyeye geçecektir. İkinci seviyede toplama, çıkarma, çarpma ve bölme sorulacaktır. İşlemde yer alan sayılar en fazla üç basamaklı olmalıdır. Verdikleri her doğru cevap için 10 puan kazanacaklardır.
• Kullanıcının puanı 80 olduğunda üçüncü seviyeye geçecektir. Üçüncü seviyede tüm işlemler sorulabilir. İşlemde yer alan sayılar en fazla 4 basamaklı olmalıdır. Verdikleri her doğru cevap için 20 puan kazanacaklardır.
• Seviye geçişlerinde kullanıcı bilgilendirilmelidir.
• Kullanıcı herhangi bir anda “exit” dediğinde uygulama kapanmalıdır.
• Kullanıcının 5 yanlış cevap verme hakkı vardır. Bu hakkını doldurduğunda uygulama kullanıcıyı bilgilendirip puanını göstermelidir. Ayrıca tekrar oynamak isteyip istemediğini sormalıdır.
• Kullanıcı tekrar oynadıkça, her oyun bitişi sonunda o ana kadar aldığı en yüksek puan gösterilmelidir. Eğer son oyunda kazandığı puan en yüksekse rekor bilgisi kullanıcıya verilmelidir
 */

using System.Threading.Channels;

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
        Console.WriteLine("Aşağıdaki işlemin sonucunu yazınız :");
        int birinciSeviye = myk.Next(1, 3);
        if (birinciSeviye == 1)
        {
            Console.WriteLine($"({sayi1}) + ({sayi2}) = ? ");
            //sonuc = sayi1 + sayi2;
            sonuc=Myk.Toplama(sayi1, sayi2);
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

class Islemler
{


}

class SayiUretimi
{
    public static int IkiBasamakliSayiÜret(int x)
    {
        Random random = new Random();
        x = random.Next(-99, 100);
        return x;
    }
}



























//Console.WriteLine("*********Matematik Oyununa Hoş Geldiniz*********");
//Console.Write("Kullanıcı Adınızı Giriniz : ");
//string userName = Console.ReadLine();
//Random myk = new Random();
//int sayi1, sayi2, islemNo, sonuc,puan=0;

//do
//{
//    Console.WriteLine("***** 1. Seviyedesiniz *****");
//    while (puan < 30) ;
//    {
//        sayi1 = myk.Next(-99, 100);
//        sayi2 = myk.Next(-99, 100);
//        int birinciSeviye = myk.Next(1, 3);
//        if (birinciSeviye == 1)
//        {
//            Islemler.Toplama(sayi1, sayi2);



//        }
//        else if (birinciSeviye == 2)
//        {
//            Islemler.Fark(sayi1, sayi2);
//        }
//    }

//} while (true);









///*
//string cevap =Console.ReadLine();
//if (cevap == "exit")
//{
//    Console.WriteLine("1");
//}
//else
//{
//    bool kontrol= int.TryParse(cevap, out int sayi);
//    Console.WriteLine(sayi);
//}
//Console.WriteLine("Aşağıdaki sayıların sonucunu ya da çıkış için 'exit' yazınız");

//*/


//class Islemler
//{
//    public static void Toplama(int sayi1,int sayi2)
//    {
//        Console.WriteLine($"({sayi1}) + ({sayi2}) = ? ");
//    }
//    public static void Fark(int sayi1,int sayi2)
//    {
//        Console.WriteLine($"({sayi1}) - ({sayi2}) = ? ");
//    }

//    public static void Carpma(int sayi1, int sayi2)
//    {
//        Console.WriteLine($"({sayi1}) x ({sayi2}) = ? ");
//    }

//    public static void Bolme(int sayi1, int sayi2)
//    {
//        Console.WriteLine($"({sayi1}) / ({sayi2}) = ? ");
//    }
//    public static void Mod(int sayi1, int sayi2)
//    {
//        Console.WriteLine($"({sayi1})= ? mod({sayi2})");
//    }
//}

