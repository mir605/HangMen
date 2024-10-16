namespace HangMen
    
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) önce kelimeleri depoluyoruz
            // 2) sonra random bir kelime seçiyoruz
            // 3) kelimenin uzunluğu kadar _ yazdırıyoruz
            // 4) kullanıcıdan harf tahmini alıyoruz
            // 5) alınan tahmin seçilen kelimenin harflerinden biri ile aynı ise doğru tahmin edilen harf görünür hale gelir
            // 6) harf yanlışsa tahmin hakkı eksilir
            // 7) 6 kere yanlış yaparsa oyun kaybedilir

           


                string[] Words = new string[] { "apple", "samsung", "huawei" }; // 1
                Random random = new Random();
                string randomWord = Words[random.Next(0, Words.Length)]; // 2

                char[] charachter = new char[randomWord.Length];
                for (int i = 0; i < charachter.Length; i++)
                {
                    charachter[i] = '_'; // 3
                }

                int guess = 0;

                Console.WriteLine("Hoşgeldin! Aşağıdaki gizli kelimeyi bul.");
                Console.WriteLine($"Bu kelimemiz {randomWord.Length} harfli.");

                while (guess < 6 && new string(charachter) != randomWord)
                {
                    Console.WriteLine(new string(charachter)); // Güncel durumu göster
                    Console.WriteLine("Lütfen bir harf tahmini yapınız:");//4

                    char forecast;
                    // Geçerli harf girişi kontrolü
                    while (!char.TryParse(Console.ReadLine(), out forecast) || !char.IsLetter(forecast))
                    {
                        Console.WriteLine("Geçersiz giriş. Lütfen bir harf giriniz:");
                    }

                    bool correctGuess = false;

                    for (int i = 0; i < randomWord.Length; i++)
                    {
                        if (forecast == randomWord[i])
                        {
                            charachter[i] = forecast; //5
                            correctGuess = true;
                        }
                    }

                    if (!correctGuess)
                    {
                        guess++;
                        Console.WriteLine($"Yanlış tahminde bulundunuz! {6 - guess} hakkınız kaldı.");//6
                    }
                }

                if (new string(charachter) == randomWord)
                {
                    Console.WriteLine($"Tebrikler! Kelimeyi buldunuz: {randomWord}");
                }
                else
                {
                    Console.WriteLine($"Kaybettiniz! Gizli kelime: {randomWord}");//7
                }
            }
        }

    }




   
