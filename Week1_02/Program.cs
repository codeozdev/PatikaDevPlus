/*
 Kullanıcıya T.C Kimlik Numarasını, adını, soyadını , telefon numarasını, yaşını, ilk aldığı ürünün fiyatını, ikinci aldığını ürünün fiyatını soran ve bu değerleri kullanıcıdan sırasıyla alan bir uygulama kodlayınız. Uygulama girilen ürün fiyatına göre aşağıdaki gibi bir mesaj yayınlasın.
 */


Console.WriteLine("Lütfen aşağıdaki bilgileri doldurunuz: ");
Console.Write("T.C Kimlik Numaranız: ");
var tc = Console.ReadLine();

Console.Write("Adınız: ");
var name = Console.ReadLine();

Console.Write("Soyadınız: ");
var surname = Console.ReadLine();

Console.Write("Telefon Numaranız: ");
var phone = Console.ReadLine();

Console.Write("Yaşınız: ");
var age = Convert.ToInt32(Console.ReadLine());

Console.Write("İlk aldığınız ürünün fiyatı: ");
var firstProductPrice = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci aldığınız ürünün fiyatı: ");
var secondProductPrice = Convert.ToDouble(Console.ReadLine());

var totalPrice = firstProductPrice + secondProductPrice;

Console.WriteLine("**************************************************");
Console.WriteLine($"{tc} kimlik numaralı {name} {surname} isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine($"{phone} telefon numarasına bildirim gönderilmiştir.");
Console.WriteLine($"Toplamda {totalPrice} TL tutarında alışveriş yapılmıştır.");