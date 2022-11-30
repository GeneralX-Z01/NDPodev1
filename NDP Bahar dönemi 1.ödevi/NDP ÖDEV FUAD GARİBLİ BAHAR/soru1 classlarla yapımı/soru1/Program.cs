/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: Fuad Garibli
**				ÖĞRENCİ NUMARASI.......: G201210558
**              DERSİN ALINDIĞI GRUP...: 2.öğretim C grubu
****************************************************************************/

using System;

namespace soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kale_y = new int[8] { 9, 9, 9, 9, 9, 9, 9, 9 };
            int[] kale_x = new int[8];
            Satranc p = new Satranc();

            p.kale_olustur(kale_x);
            p.kale_olustur(kale_y);
            p.kale_yaz();
            p.kale_yerlestir(kale_x, kale_y);
            Console.ReadLine();
        }
    }
}
