/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**			      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**		         NESNEYE DAYALI PROGRAMLAMA DERSİ
**		        	2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: Fuad Garibli
**				ÖĞRENCİ NUMARASI.......: G201210558
**              DERSİN ALINDIĞI GRUP...: 2.öğretim C
****************************************************************************/

using System;

namespace soru1
{
    class Program
    {
        protected void kale_yaz()//kalelelerin yerleştirileceği tahtayı oluşturan fonksiyon
        {
            for (int i = 1; i < 73; i++)
            {
                for(int j=0;j<8;j++)
                {
                    Console.Write("0 ");//0'lardan oluşan 9 tane 8x8lik matris yazdırılır
                }
                Console.WriteLine();
                if (i % 8 == 0 && i!=0) { Console.WriteLine("==============="); }
            }
        }
        protected void yazdir(int x, int y, string c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
        protected void kale_olustur(int[] kale_konum)//kale koordinatlarının oluşturulduğu ve kontrol edildiği fonksiyon 
        {
            int kontrol = 0;
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                do
                {
                    kontrol = 0;
                    kale_konum[i] = random.Next(0, 8);

                    for (int j = 0; j < 8; j++)
                    {
                        if (kale_konum[i] == kale_konum[j])
                        {
                            kontrol++;
                        }
                    }
                } while (kontrol > 1);//kalelerin bir birini yeme durumu kontrol edilir
            }
        }
        protected void kale_yerlestir(int[] kale_x, int[] kale_y)//konumlara göre kalelerin yerleştirildiği fonksiyon
        {
            Program program = new Program();
            int satir = 0,satir_kntrl=0,sayac=0;
            while (satir != 8)
            {
                if(sayac!=8)//her adımda tek tek kaleler yerleştirilir
                {
                    program.yazdir(2 * kale_x[satir], kale_y[kale_x[satir]] + satir_kntrl, "K");
                    program.yazdir(22, 3 + satir_kntrl, (satir+1)+".Adım");
                    satir++;
                    sayac++;
                    if (sayac == 8) { satir = 0; }
                    satir_kntrl = satir_kntrl + 9;
                }
                if(sayac==8)//adımlar bittikten sonra kalelerin hepsinin yerleştirildiği hali yazdırılır
                {
                    program.yazdir(2 * kale_x[satir], kale_y[kale_x[satir]]+satir_kntrl, "K");
                    satir++;
                }
            }
            program.yazdir(0, 82,"");
        }

        static void Main(string[] args)
        {
            int[] kale_y = new int[8] { 9, 9, 9, 9, 9, 9, 9, 9 };
            int[] kale_x = new int[8];
            Program p = new Program();

            p.kale_olustur(kale_x);
            p.kale_olustur(kale_y);
            p.kale_yaz();
            p.kale_yerlestir(kale_x, kale_y);
            Console.ReadLine();
        }
    }
}
