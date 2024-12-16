/*
 
 Bu pratik uygulamasında sizlerden konsol ekranı yardımıyla kullanıcıdan bir sayı değeri almanızı, bu değerin 10'a eşit mi , 10'dan küçük mü, 10'dan büyük mü olduğu durumları kontrol ederek kullanıcıya bir bilgilendirme mesajı yazmanız isteniyor.
   
   Ardından 2. bir kontrol yapısıyla girilen sayının çift mi yoksa tek mi olduğunu ekrana yazdırınız.
 
 */


Console.Write("Lütfen bir sayı giriniz: ");
var number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Bu sayı çifttir.");
}
else
{
    Console.WriteLine("Bu sayı tektir");
}

if (number == 10)
{
    Console.WriteLine("Girilen sayı 10'a eşittir.");
}
else if (number < 10)
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
}
else
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
}