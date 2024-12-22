// 1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

for (var i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

Console.WriteLine("*******************************************************************************************");

// 2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

for (var i = 2; i < 20; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("*******************************************************************************************");


// 3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.


for (var i = 2; i < 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("*******************************************************************************************");

// 4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

var sum = 0;

for (var i = 51; i < 150; i++)
{
    sum += i;
}


Console.WriteLine(sum);


Console.WriteLine("*******************************************************************************************");

// 5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

var sumEven = 0;
var sumOdd = 0;

for (var i = 2; i < 120; i++)
{
    if (i % 2 == 0)
    {
        sumEven += i;
    }
    else
    {
        sumOdd += i;
    }
}

Console.WriteLine($"Çift sayıların toplamı: {sumEven}");
Console.WriteLine($"Tek sayıların toplamı: {sumOdd}");