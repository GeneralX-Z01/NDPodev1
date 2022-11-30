/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**		  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**			   BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**		       NESNEYE DAYALI PROGRAMLAMA DERSİ
**				   2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: ÖDEV 1, SORU 2.
**				ÖĞRENCİ ADI............: FUAD GARIBLI
**				ÖĞRENCİ NUMARASI.......: G201210558
**              DERSİN ALINDIĞI GRUP...: 2.ÖĞRETİM 
**
****************************************************************************/
using System;
using System.Collections.Generic;

namespace Fuad_Garibli_HW
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("                          ***** Menü *****                              ");
            Console.WriteLine("string bir değişkende, string deyeri substring kullanmadan ara.........1");
            Console.WriteLine(" ");
            Console.WriteLine("string bir değişkende, string deyeri substring kullanarak ara..........2");
            Console.WriteLine(" ");
            Console.WriteLine("Alfabenin karakterlerini bir stringde ara, kaç kere geliyorsa çiz......3");
            Console.WriteLine(" ");
            Console.Write("seçiminiz (1-3)..:");
            int menuAYE = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*************************************************************************");


            if (menuAYE == 1)
            {
                //kullanıcıdan string ve aranacak kelimeyi girmesini istiyoruz.
                Console.Write("Stringi giriniz :");// kullanıcıdan cümleyi alırız
                string sentence = Console.ReadLine();
                Console.Write("Aranacak kelime :"); // kullanıcıdan aranacak kelimeyi alırız
                string word = Console.ReadLine();

                int a = 0;
                while ((sentence.ToLower().IndexOf(word.ToLower(), a) + 1) != 0)
                {
                    Console.WriteLine(word + " indis: " + sentence.ToLower().IndexOf(word.ToLower(), a));//bulunan kelimenin bilgileri yazılır
                    a = sentence.ToLower().IndexOf(word.ToLower(), a) + 1;//index of komutunun her seferinde kaldığı indexten devam etmesi sağlanır
                }
            }
            else if (menuAYE == 2)
            {
                // kullanıcıdan stringi ve aranacak kelimeyi alıyoruz
                Console.Write("String giriniz :");
                string sentence = Console.ReadLine();
                Console.Write("Aranacak kelime :");
                string word = Console.ReadLine();
                int a = 0;
                string subdansonra;
                for (int i = 0; i < sentence.Length; i++)
                {
                    subdansonra = sentence.Substring(a);//girilen deger her seferinde bulunan en son kelime indexinden sonrasını alsın
                    if (subdansonra.ToLower().IndexOf(word.ToLower()) == -1)
                    {
                        break; //bulunacak kelime kalmadığı zaman döngü bitsin
                    } 
                    Console.WriteLine(word + " indis: " + sentence.ToLower().IndexOf(word.ToLower(), a));
                    a = a + subdansonra.ToLower().IndexOf(word.ToLower()) + 1;
                }

            }
            else if (menuAYE == 3)
            {
                int[] count = new int[29];
                char[] alfabeelemanlari = new char[29] { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
                Console.WriteLine("Metni giriniz:");
                string newsatir = "1";
                List<string> result = new List<string> { };
                while (!string.IsNullOrEmpty(newsatir))//satırbaşı yaparak yeni stringler almak için kullanıyoruz
                {
                    newsatir = Console.ReadLine();
                    result.Add(newsatir);
                }
                foreach (string s1 in result)
                {
                    newsatir = newsatir + s1; //tüm satırlar aynı hizada tek bir string yapılır
                }
                string metin = newsatir.ToUpper();
                char[] aranacak = metin.ToCharArray();
                for (int i = 0; i < alfabeelemanlari.Length; i++)
                {
                    for (int j = 0; j < aranacak.Length; j++)
                    {
                        if (alfabeelemanlari[i] == aranacak[j])
                        {
                            count[i]++; //her harften kaç tane olduğu bulunur
                        }
                    }
                    Console.Write(alfabeelemanlari[i] + ",    sayısı: " + count[i]);
                    /* for (int k = 0; k < count[i]; k++)
                     {
                         Console.Write(" *"); //yıldız bastırılır
                     } */
                    Console.WriteLine();
                }
            }

            else
            {
                Console.WriteLine("Seçilen işlem bulunamadı.Lütfen tekrar deneyin.");
            }
        }
    }
}
