// 1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

var ok = 1;
while (ok <= 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    ok++;
}


Console.WriteLine("*******************************************************************************************");

// 2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

var i = 2;

while (i < 20)
{
    Console.WriteLine(i);
    i++;
}

Console.WriteLine("*******************************************************************************************");

// 3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

var cift = 2;
while (cift < 20)
{
    if (cift % 2 == 0)
    {
        Console.WriteLine(cift);
    }

    cift++;
}

Console.WriteLine("*******************************************************************************************");

// 4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

var toplam = 0;
var sayi = 51;
while (sayi < 150)
{
    toplam += sayi;
    sayi++;
}

Console.WriteLine(toplam);


Console.WriteLine("*******************************************************************************************");

// 5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

var tekToplam = 0;
var ciftToplam = 0;
var sayi2 = 2;

while (sayi2 < 120)
{
    if (sayi2 % 2 == 0)
    {
        ciftToplam += sayi2;
    }
    else
    {
        tekToplam += sayi2;
    }

    sayi2++;
}

Console.WriteLine("Tek Sayıların Toplamı: " + tekToplam);
Console.WriteLine("Çift Sayıların Toplamı: " + ciftToplam);