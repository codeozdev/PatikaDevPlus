// Pratik - Yol Arkadaşı : Tatil uygulaması


while (true)
{
    Console.Write("Lütfen gitmek istediğiniz lokasyonu giriniz (Bodrum, Marmaris, Çeşme): ");
    var lokasyon = Console.ReadLine();

    while (lokasyon != "bodrum" && lokasyon != "marmaris" && lokasyon != "çeşme")
    {
        Console.WriteLine(
            "Hatalı lokasyon girdiniz. Lütfen geçerli lokasyonlardan birini giriniz: Bodrum, Marmaris, Çeşme");
        lokasyon = Console.ReadLine()?.ToLower();
    }

    Console.Write("Kaç kişi için tatil planlamak istiyorsunuz? ");
    var kisiSayisi = Convert.ToInt32(Console.ReadLine());


    var lokasyonBilgisi = lokasyon switch // C# 8.0
    {
        "bodrum" => "Bodrum'da deniz keyfi yapabilir, gece hayatına katılabilirsiniz.",
        "marmaris" => "Marmaris'te doğa yürüyüşleri ve tekne turları yapılabilir.",
        "çeşme" => "Çeşme'de plaj keyfi yapabilir, Alaçatı'da gezintiye çıkabilirsiniz.",
        _ => "Geçersiz lokasyon."
    };
    Console.WriteLine($"Gitmek istediğiniz lokasyon: {lokasyon.ToUpper()}, {lokasyonBilgisi} \n");

    Console.WriteLine("Lütfen ulaşım aracınızı seçiniz: ");
    Console.WriteLine("1 - Kara yolu (Kişi başı 1500 TL)");
    Console.WriteLine("2 - Hava yolu (Kişi başı 4000 TL) \n");

    var ulasimSecimi = Console.ReadLine();
    while (ulasimSecimi != "1" && ulasimSecimi != "2")
    {
        Console.WriteLine("Hatalı seçim yaptınız. Lütfen 1 veya 2 giriniz.");
        ulasimSecimi = Console.ReadLine();
    }


    var paketFiyati = lokasyon switch
    {
        "bodrum" => 4000,
        "marmaris" => 3000,
        "çeşme" => 5000,
        _ => 0
    };

    var ulasimFiyati = ulasimSecimi == "1" ? 1500 : 4000;
    var toplamFiyat = (paketFiyati + ulasimFiyati) * kisiSayisi;

    Console.WriteLine($"{kisiSayisi} kişi ile toplam fiyat (Tatil + Ulaşım): {toplamFiyat:N0} TL \n");


    Console.WriteLine("Başka bir tatil planlamak ister misiniz? (Evet = 1/Hayır = 2)");
    var devam = Console.ReadLine();

    if (devam == "2")
    {
        Console.WriteLine("İyi günler dileriz!");
        break;
    }
}