/* 
Pratik - Kim Milyoner Olmak İster ?
   
   Bir bilgi yarışması yapıyoruz!
   
   2 cevap şıklı 3 adet sorumuz var ! ( Aşağıdaki sorular örnektir, kendi sorularınızla programı editleyebilirsiniz.)
   
   1 -> Kızınca tüküren hayvan hangisidir ?
   
   a) Lama b) Deve 
   
   2 -> Dünya'ya en yakın gezegen hangisidir ? 
   
   a) Venüs b) Mars 
   
   3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? 
   
   a) 7 b) 12 
   
   Yarışmacı 3 sorudan 2'sini doğru cevaplar  ise 1 Milyon TL'lik büyük ödülü kazanacak!
   
   Bu uygulamada kullanıcının doğru cevaplarını saymak için bir değişkene ihtiyacımız olduğunu unutmayın !
   
   Akış -> Kullanıcıya birinci soruyu soruyoruz ve cevabı alıyoruz. ( A ya da B şeklinde - Büyük küçük harf duyarlılığı olmasın!) , Ardından cevabın doğruluk durumuna göre bir mesaj ile kullanıcıya durumu bildiriyoruz. 
   
   İlk 2 soruya cevap veren kullanıcının büyük ödülü kazanma ihtimali ortadan kalktığı için 3. soruyu sormuyoruz.
   
   Final neticesinde kullanıcıya büyük ödülü kazanıp kazanmadığını bir konsol mesajıyla bildiriyoruz.

*/


var score = 0;

Console.WriteLine("\n1 -> Dünyanın en yüksek dağı neresidir?");
Console.WriteLine("a) Everest b) K2");
Console.Write("Cevabınız: ");
var asnwer = Console.ReadLine()?.Trim().ToLower();

if (asnwer == "a")
{
    Console.WriteLine("Tebrikler, doğru cevap!");
    score++;
}
else
{
    Console.WriteLine("Üzgünüm, yanlış cevap!");
}


if (score == 0)
{
    Console.WriteLine("Maalesef, büyük ödülü kazanamadınız.");
}
else
{
    Console.WriteLine("Tebrikler ikinci soruya geçiyoruz...");
}

// 2. Soru
Console.WriteLine("\n2 -> Dünyanın en kalabalık şehri hangisidir?");
Console.WriteLine("a) Tokyo");
Console.WriteLine("b) Ankara");
Console.Write("Cevabınız: ");
var asnwer2 = Console.ReadLine()?.Trim().ToLower();

if (asnwer == "a")
{
    Console.WriteLine("Tebrikler, doğru cevap!");
    score++;
}
else
{
    Console.WriteLine("Üzgünüm, yanlış cevap!");
}


if (score < 2)
{
    Console.WriteLine("\nÜzgünüz, ikinci soruyu bilemediğiniz için yarışma sona erdi.");
    return;
}


Console.WriteLine("\n3 -> Türkiyenin en büyük gölü neresidir?");
Console.WriteLine("a) Burdur");
Console.WriteLine("b) Van");
Console.Write("Cevabınız: ");
var asnwer3 = Console.ReadLine()?.Trim().ToLower();

if (asnwer3 == "b")
{
    Console.WriteLine("Doğru cevap!");
    score++;
}
else
{
    Console.WriteLine("Yanlış cevap!");
}

// Sonuç
if (score == 3)
{
    Console.WriteLine("\nTebrikler, büyük ödülü kazandınız! 🏆 1 Milyon TL!");
}
else
{
    Console.WriteLine("\nÜzgünüz, büyük ödülü kazanamadınız.");
}