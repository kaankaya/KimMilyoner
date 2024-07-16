using System;
namespace exercise
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Doğru cevapları hafızada tutmak için değişkenimiz
            int correct_answer = 0;
            //karşılama mesajı
            Console.WriteLine("Kim Milyoner Olmak İster ' e Hoşgeldin !");
            //kullanıcıdan isim bilgisini alıyoruz
            Console.Write("Yarışmaya Katılmak için Adınızı Giriniz: ");
            string name = Console.ReadLine().Trim().ToUpper();
            //Soru 1 
            Console.WriteLine("Kızınca Tüküren Hayvan Hangisidir? (Cevabınızı: a yada b olarak belirtiniz) ");
            Console.WriteLine("A)Lama \nB)Deve");
            //Trim methodu ile boşlukları kaldırıyoruz.ToLower ile girilen yazıyı küçültüyoruz
            string answer_one = Console.ReadLine().Trim().ToLower();
            if (answer_one == "a")
            {
                Console.WriteLine("Doğru Cevap");
                //eğer kullanıcı doğru cevap verirse doğru cevap değişkenini 1 arttırıyoruz
                correct_answer++;
            }
            else
            {
                Console.WriteLine("Yanlış Cevap");
            }//End İf
            //Soru 2 
            Console.WriteLine("Dünya'ya en yakın gezegen hangisidir ? (Cevabınızı: a yada b olarak belirtiniz) ");
            Console.WriteLine("A)Venüs \nB)Mars");
            string answer_two = Console.ReadLine().Trim().ToLower();
            if (answer_two == "a")
            {
                Console.WriteLine("Doğru Cevap");
                correct_answer++;
             
            }
            else
            {
                Console.WriteLine("Yanlış Cevap");
            }//End İf
            //eğer baştan 2 doğru cevabı var ise 3.Soruyu kullanıcıya göstermeden ödülü veriyoruz 
            if (correct_answer == 2)
            {
                Console.WriteLine($"Tebrikler {name} 2 Soruya Doğru cevap vererek Büyük Ödülü Kazandınız");
            }
            else
            {
                //Eğer 2 doğru cevabı yok ise kullanıcıya son soruyu sorup ona göre eleme işlemini yapıyoruz
                Console.WriteLine(" 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? (Cevabınızı: a yada b olarak belirtiniz) ");
                Console.WriteLine("A)7 \nB)12");
                string answer_tree = Console.ReadLine().Trim().ToLower();
                if (answer_tree == "a")
                {
                    Console.WriteLine($"Tebrikler {name} Büyük Ödülü Kazandınız");
                    correct_answer++;
                }
                else
                {
                    Console.WriteLine($"Üzgünüm {name}  Elendiniz");
                }//end if
            }//End İf

        }
    }
}