// 1- Geriye Değer Döndürmeyen Bir void metot


SarkiAdi();

void SarkiAdi()
{
    Console.WriteLine("Gözlerin bir yıldız gibi parlıyor, Geceyi aydınlatan bir ay ışığı");
}

// Geriye Tamsayı Döndüren Bir metot

var kalan = RastgeleSayi();
Console.WriteLine(kalan);

int RastgeleSayi()
{
    var rnd = new Random();
    var sayi = rnd.Next(1, 100);
    return sayi % 2;
}


// Parametre Alan ve Geriye Değer Döndüren Bir Metot

var carpim = ParametreliMethod(5, 10);
Console.WriteLine(carpim);

int ParametreliMethod(int sayi1, int sayi2)
{
    return sayi1 * sayi2;
}


// Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

FullName("Oguzhan", "Uguz");

void FullName(string firstName, string lastName)
{
    Console.WriteLine($"Hosgeldiniz {firstName} {lastName}");
}