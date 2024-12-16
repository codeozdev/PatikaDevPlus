/*
Bir Manav Uygulaması Geliştiriyoruz.
   
   Rüya manavında fiyatlar çok uygun!
   
   Elma = 2 TL
   
   Armut = 3 TL
   
   Çilek = 2 TL
   
   Muz = 3 TL
   
   Diğer bütün meyveler = 4 TL
   
   Kullanıcımıza konsol ekranında hangi meyveyi satın almak istediğini soruyoruz. Aldığımız cevaba göre ilgili meyvenin fiyatını ekrana yazdırıyoruz. 
   
   Araştıralım -> Büyük küçük harf duyarlılığını ortadan kaldırabiliriz. bunun için string metotları olan ToUpper / ToLower kullanabiliriz. Yapay zekadan yardım alabilirsiniz! 
 */



Console.WriteLine("Ruya Manava Hosgeldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Cilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diger butun meyveler = 4 TL");
Console.Write("Lutfen satin almak istediginiz meyveyi yaziniz: ");
var meyve = Console.ReadLine()?.ToLower();

switch (meyve)
{
    case "elma":
        Console.WriteLine("Elma fiyati: 2 TL");
        break;
    case "armut":
        Console.WriteLine("Armut fiyati: 3 TL");
        break;
    case "cilek":
        Console.WriteLine("Cilek fiyati: 2 TL");
        break;
    case "muz":
        Console.WriteLine("Muz fiyati: 3 TL");
        break;
    default:
        Console.WriteLine("Diger butun meyveler fiyati: 4 TL");
        break;
}


Console.WriteLine("************************************************");

if (meyve == "elma")
{
    Console.WriteLine("Elma fiyati: 2 TL");
}
else if (meyve == "armut")
{
    Console.WriteLine("Armut fiyati: 3 TL");
}
else if (meyve == "cilek")
{
    Console.WriteLine("Cilek fiyati: 2 TL");
}
else if (meyve == "muz")
{
    Console.WriteLine("Muz fiyati: 3 TL");
}
else
{
    Console.WriteLine("Diger butun meyveler fiyati: 4 TL");
}


// Bu uygulamada switch case yapisini kullanmak daha mantikli olacaktir cunku kullanicinin istedigi meyve sartini buldugu anda program calismayi durduracaktir.