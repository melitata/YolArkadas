using System;
using System.ComponentModel.Design;
namespace YolArkadası
{
    class Program
    {
        static void Main(string[] args)

        {

        YolArkadası:
            Console.WriteLine("Hemen bir tatil planlayalım:)");


            {
            baslangıc:
                Console.WriteLine("Hangi lokasyona gitmek istersiniz?");
                Console.WriteLine("Bodrum Marmaris Çeşme");

                Console.WriteLine("Gitmek istediğiniz tatil seçeneğini seçiniz lütfen:");
                string lokasyon = Console.ReadLine().ToLower();

                int paket;
                switch (lokasyon)
                {

                    case "Bodrum":
                        Console.WriteLine("Bodrum lokasyonunu tercih ettiniz.");
                        paket = 4000;
                        break;
                    case "Marmaris":
                        Console.WriteLine("Marmaris lokasyonunu tercih ettiniz.");
                        paket = 3000;
                        break;
                    case "Çeşme":
                        Console.WriteLine("Çeşme lokasyonunu tercih ettiğiniz için teşekkürler.");
                        paket = 5000;
                        break;


                }
            kisisayisi:
                string kisisayisi;
                Console.WriteLine("Kaç kişi olmayı planlıyorsunuz?");
                kisisayisi = Console.ReadLine();
                int.TryParse(kisisayisi, out int sayiNegatif);

                if (sayiNegatif < 0)
                {
                    Console.WriteLine($"Kişi sayısı 0'dan küçük olamaz.Tekrar giriş yapınız.");
                    goto kisisayisi;
                }
                if (int.TryParse(kisisayisi, out int sayi))
                {
                    Console.WriteLine($" {sayi} kişilik {lokasyon} tatil planı ile devam ediyoruz o halde");
                }
                else
                {
                    Console.WriteLine("Geçersiz bir değer girdiniz.Lütfen tekrar deneyiniz");
                    goto kisisayisi;
                }
            ulasım:
                Console.WriteLine("Hangi ulaşım yöntemini tercih edersiniz?");
                Console.WriteLine("1) Hava Yolu");
                Console.WriteLine("2) Kara Yolu");
                Console.WriteLine("   Karayolu kişi başı ulaşım tutarı gidiş-dönüş 2000 TL");
                Console.WriteLine("   Havayolu kişi başı ulaşım tutarı gidiş-dönüş 5000 TL");
                string ulasımYontemı = Console.ReadLine();
                int ulasımFiyat;

                switch (ulasımYontemı)

                {
                    case "1":
                        Console.WriteLine("Havayolunu tercih ettiniz");
                        ulasımFiyat = 5000;
                        break;
                    case "2":
                        Console.WriteLine("Karayolunu tercih ettiniz");
                        ulasımFiyat = 2000;
                        break;
                }
                
                  int totalPrice = sayi * paket + sayi * ulasımFiyat;
                    Console.WriteLine($" Tatil planınızı neredeyse tamamladık. {lokasyon} için {sayi} kişilik tatil planınız hazır.");
                    Console.WriteLine($" Toplam tatil ücretiniz: {totalPrice} TL' dir.");

                    Console.WriteLine($" Başka bir tatil planı yapmak ister misiniz? (Evet/Hayır)");
                    string cevap = Console.ReadLine().ToLower();

                    switch (cevap)
                    {
                        case "evet":
                            Console.WriteLine("Karayolu ile ulaşım yapmayı tercih ettiniz.");
                            goto ulasım;
                            break;
                        default:
                            Console.WriteLine("Başka tatil planlarında görüşmek üzere.");
                            break;
                    }
                    Console.ReadKey();
                
                 










            }
        }
    }
}
