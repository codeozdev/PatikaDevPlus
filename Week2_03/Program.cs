/*
Bu pratikte aynı sorunun cevabını hem while hem de do-while ile kodlamanız ve örnek girdilerde ikisi arasındaki farkı irdelemeniz bekleniyor.

   Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.

   ( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )

   Örnek inputlar : 10 ve -5

   Uygulama testi sonrası while ve do-while arasındaki farkı yorum satırı olarak kodunuzun altına ekleyiniz.
 */


// WHILE

Console.Write("Lutfen bir sayi giriniz: ");
var limit = Convert.ToInt32(Console.ReadLine());

var counter = 0;
while (counter < limit)
{
    Console.WriteLine($"{counter + 1} - Ben bir Patika'lıyım");
    counter++;
}


Console.WriteLine("****************************************************");


// DO-WHILE

Console.Write("Lutfen bir sayi giriniz: ");
var newLimit = Convert.ToInt32(Console.ReadLine());

var newCounter = 0;
do
{
    Console.WriteLine($"{newCounter + 1} - Ben bir Patika'lıyım");
    newCounter++;
} while (newCounter < newLimit);


// NOT: Eksi bir sayı girildiğinde while döngüsü hiç çalışmazken, do-while döngüsü bir kere çalışır ve ekrana ilk değeri yazdırır.