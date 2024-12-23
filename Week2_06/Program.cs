

// 1 - Aşağıdaki çıktıyı yazan bir program.

Console.WriteLine("Merhaba\nNasilsin?\nIyiyim\nSen nasilsin?");

// 2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
string metin;
int sayi;

metin = "Merhaba";
sayi = 5;
Console.WriteLine($"Metin: {metin}");
Console.WriteLine($"Sayi: {sayi}");

// 3 - Rastgele bir sayı üretip , ekrana yazdırınız.
var rnd = new Random();
var number = rnd.Next(1, 100);
Console.WriteLine($"3- {number}");

// 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
var rnd1 = new Random();
var number1 = rnd1.Next(1, 100);
Console.WriteLine($"4- {number1 % 3}");


// 5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
Console.Write("Yasinizi giriniz: ");
var yas = Convert.ToInt32(Console.ReadLine());
if (yas > 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}

// 6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
for (var i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}

// 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
// X

// 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}

BenDegerDondurmem();

// 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

int Topla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}

Console.WriteLine(Topla(5, 10));

// 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
Console.Write("Lutfen true veya false bir deger giriniz: ");
var deger1 = Convert.ToBoolean(Console.ReadLine());

string TrueFalse(bool deger1)
{
    if (deger1)
    {
        return "True";
    }
    else
    {
        return "False";
    }
}

Console.WriteLine(TrueFalse(deger1));

//  11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

int EnYasli(int yas1, int yas2, int yas3)
{
    if (yas1 > yas2 && yas1 > yas3)
    {
        return yas1;
    }
    else if (yas2 > yas1 && yas2 > yas3)
    {
        return yas2;
    }
    else
    {
        return yas3;
    }
}

Console.WriteLine(EnYasli(25, 30, 35));

// 12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

int EnBuyuk(params int[] sayilar)
{
    var enBuyuk = sayilar[0];
    foreach (var i in sayilar)
    {
        if (i > enBuyuk)
        {
            enBuyuk = i;
        }
    }
    return enBuyuk;
}

Console.WriteLine(EnBuyuk(5, 10, 15, 20, 25, 30, 35, 40, 45, 50));



// 13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

Console.Write("Ilk isim ");
var isim1 = Console.ReadLine();
Console.Write("Ikinci isim ");
var isim2 = Console.ReadLine();

IsimleriDegistir(ref isim1, ref isim2);
Console.WriteLine($"Ilk isim {isim1}");
Console.WriteLine($"Ikinci isim {isim2}");

void IsimleriDegistir(ref string isim1, ref string isim2)
{
    (isim1, isim2) = (isim2, isim1);
}



// 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

Console.Write("Bir sayi giriniz: ");
var number12 = Convert.ToInt32(Console.ReadLine());

bool TekMiCiftMi(int number12)
{
    return number12 % 2 == 0;
}

Console.WriteLine(TekMiCiftMi(number12));



// 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

Console.Write("Hizi giriniz: ");
var hiz = Convert.ToInt32(Console.ReadLine());

Console.Write("Zamani giriniz: ");
var zaman = Convert.ToInt32(Console.ReadLine());

int GidilenYol(int hiz, int zaman)
{
    return hiz * zaman;
}

Console.WriteLine(GidilenYol(hiz, zaman));



// 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

Console.Write("Dairenin yaricapini giriniz: ");
double yaricap = Convert.ToDouble(Console.ReadLine());

double alan = DaireAlaniHesapla(yaricap);

Console.WriteLine($"Yarıçapı {yaricap} olan dairenin alanı: {alan}");

static double DaireAlaniHesapla(double yaricap)
{
    const double pi = Math.PI;
    return pi * yaricap * yaricap;
}



// 17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string cumle = "Zaman bir GeRi SayIm";

Console.WriteLine(cumle.ToUpper());
Console.WriteLine(cumle.ToLower());

// 18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string metinc = "    Selamlar   ";

metinc = metinc.Trim();
Console.WriteLine(metinc);