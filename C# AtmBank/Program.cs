using System;

class Program
{
    static void Main(string[] args)
    {
        int bakiye = 1000; // Başlangıç bakiyesi
        while (true)
        {
            
        Console.WriteLine("Dilini seç / Chouse your language. (TR-EN)");
        string language = Convert.ToString(Console.ReadLine());
        Console.Clear();
        if (language == "TR" || language == "tr")
        {

            while (true) // Sonsuz döngü
        {
            // Menü
            Console.WriteLine("\n=== İşlem Menüsü ===");
            Console.WriteLine("1. Bakiye Sorgulama");
            Console.WriteLine("2. Para Çekme");
            Console.WriteLine("3. Para Yatırma");
            Console.WriteLine("4. Bakiye Ekleme");
            Console.WriteLine("5. Hesap Silme");
            Console.WriteLine("6. Çıkış");

            // Kullanıcıdan seçim al (Enter basılması gerekiyor)
            string secim = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(secim) || secim.Length != 1) // Geçersiz giriş kontrolü
            {
                Console.WriteLine("Geçersiz giriş! Lütfen yalnızca bir harf yazıp Enter'a basın.");
                continue;
            }

            switch (secim)
            {
                case "1":
                    // Bakiye Sorgulama
                    Console.WriteLine($"\nMevcut bakiyeniz: {bakiye} TL");
                    break;

                case "2":
                    // Para Çekme
                    Console.Write("Çekmek istediğiniz tutarı girin: ");
                    string cekTutar = Console.ReadLine();

                    if (int.TryParse(cekTutar, out int cekilecekTutar) && cekilecekTutar > 0)
                    {
                        if (cekilecekTutar <= bakiye)
                        {
                            bakiye -= cekilecekTutar;
                            Console.WriteLine($"{cekilecekTutar} TL hesabınızdan çekildi. Yeni bakiyeniz: {bakiye} TL");
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz bakiye! Bu kadar para çekemezsiniz.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir tutar giriniz.");
                    }
                    break;

                case "3":
                    // Para Yatırma
                    Console.Write("Yatırmak istediğiniz tutarı girin: ");
                    string yatirTutar = Console.ReadLine();

                    if (int.TryParse(yatirTutar, out int yatirilacakTutar) && yatirilacakTutar > 0)
                    {
                        bakiye += yatirilacakTutar;
                        Console.WriteLine($"{yatirilacakTutar} TL hesabınıza yatırıldı. Yeni bakiyeniz: {bakiye} TL");
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir tutar giriniz.");
                    }
                    break;

                case "4":
                    // Bakiye Ekleme
                    Console.Write("Eklemek istediğiniz tutarı girin: ");
                    string ekleTutar = Console.ReadLine();

                    if (int.TryParse(ekleTutar, out int eklenecekTutar) && eklenecekTutar > 0)
                    {
                        bakiye += eklenecekTutar;
                        Console.WriteLine($"{eklenecekTutar} TL bakiyenize eklendi. Yeni bakiyeniz: {bakiye} TL");
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir tutar giriniz.");
                    }
                    break;

                case "5":
                    // Hesap Silme
                    Console.WriteLine("\nHesabınızı silmek istediğinizden emin misiniz? (Evet: 'E', Hayır: 'H')");
                    string silOnay = Console.ReadLine().ToUpper(); // Kullanıcıdan onay al

                    if (silOnay == "E")
                    {
                        bakiye = 0; // Hesap sıfırlanır
                        Console.WriteLine("Hesabınız başarıyla silindi. Artık hesabınızda bakiye bulunmamaktadır.");
                    }
                    else if (silOnay == "H")
                    {
                        Console.WriteLine("Hesap silme işlemi iptal edilmiştir.");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz yanıt! Hesap silme işlemi iptal edilmiştir.");
                    }
                    break;

                case "6":
                    // Çıkış
                    Console.WriteLine("Çıkış yapılıyor. İyi günler!");
                    return; // Programdan çık

                default:
                    Console.WriteLine("Geçersiz seçim! Lütfen a-f arasında bir harf yazıp Enter'a basın.");
                    break;
            }

            // Her işlemden sonra devam etmek için bekle
            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
            Console.Clear();
        }
        }
        if(language == "EN" || language == "en")
            {
                while (true)
            {
                // Menu
                Console.WriteLine("\n=== Operation Menu ===");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. Deposit Money");
                Console.WriteLine("4. Add Balance");
                Console.WriteLine("5. Delete Account");
                Console.WriteLine("6. Exit");

                // Get user selection (Enter key is required)
                string secim = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(secim) || secim.Length != 1) // Invalid input check
                {
                    Console.WriteLine("Invalid input! Please type only one character and press Enter.");
                    continue;
                }

                switch (secim)
                {
                    case "1":
                        // Check Balance
                        Console.WriteLine($"\nYour current balance is: {bakiye} TL");
                        break;

                    case "2":
                        // Withdraw Money
                        Console.Write("Enter the amount you want to withdraw: ");
                        string cekTutar = Console.ReadLine();

                        if (int.TryParse(cekTutar, out int cekilecekTutar) && cekilecekTutar > 0)
                        {
                            if (cekilecekTutar <= bakiye)
                            {
                                bakiye -= cekilecekTutar;
                                Console.WriteLine($"{cekilecekTutar} TL has been withdrawn. Your new balance is: {bakiye} TL");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance! You cannot withdraw that amount.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid amount.");
                        }
                        break;

                    case "3":
                        // Deposit Money
                        Console.Write("Enter the amount you want to deposit: ");
                        string yatirTutar = Console.ReadLine();

                        if (int.TryParse(yatirTutar, out int yatirilacakTutar) && yatirilacakTutar > 0)
                        {
                            bakiye += yatirilacakTutar;
                            Console.WriteLine($"{yatirilacakTutar} TL has been deposited. Your new balance is: {bakiye} TL");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid amount.");
                        }
                        break;

                    case "4":
                        // Add Balance
                        Console.Write("Enter the amount you want to add: ");
                        string ekleTutar = Console.ReadLine();

                        if (int.TryParse(ekleTutar, out int eklenecekTutar) && eklenecekTutar > 0)
                        {
                            bakiye += eklenecekTutar;
                            Console.WriteLine($"{eklenecekTutar} TL has been added to your balance. Your new balance is: {bakiye} TL");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid amount.");
                        }
                        break;

                    case "5":
                        // Delete Account
                        Console.WriteLine("\nAre you sure you want to delete your account? (Yes: 'E', No: 'H')");
                        string silOnay = Console.ReadLine().ToUpper(); // Get confirmation from user

                        if (silOnay == "E")
                        {
                            bakiye = 0; // Account balance is reset
                            Console.WriteLine("Your account has been successfully deleted. There is no balance left in your account.");
                        }
                        else if (silOnay == "H")
                        {
                            Console.WriteLine("Account deletion has been cancelled.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid response! Account deletion has been cancelled.");
                        }
                        break;

                    case "6":
                        // Exit
                        Console.WriteLine("Exiting... Have a nice day!");
                        return; // Exit program

                    default:
                        Console.WriteLine("Invalid selection! Please enter a number between 1 and 6.");
                        break;
                }

                // Wait after each operation
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            }
        else
        {
            Console.WriteLine("Worng Chouse / Geçersiz Tuşlama.");
            Console.Clear();
        }
    }
    }
}
