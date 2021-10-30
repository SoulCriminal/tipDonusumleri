using System;

namespace tipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implicit Conversion (Bilinçsiz Dönüşüm");
            byte a= 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d:"+d);

            long h = d;
            Console.WriteLine("h: "+h);

            float i = h;
            Console.WriteLine("i: "+i);

            string ad = "hakki";
            char k = 'a';
            object g = ad+k+i;
            Console.WriteLine("g: "+g);

            //Explicit Conversion (Bilinçli DÖnüşüm)

            Console.WriteLine("\n Explicit Conversion\n");

            int s1 = 4;
            byte s2 = (byte)s1;
            Console.WriteLine("s2: "+s2);

            float s3 = 10.3f;
            byte s4 = (byte)s3;
            Console.WriteLine("s4: "+s4); // reel sayıyı byte'a çevirirsek yuvarlayıp tam sayı olarak çıktı verir.



            // ToString Metodu

            Console.WriteLine("\nToString Metodu"); //  "\n" ekrana yazdırmadan ekrankda bir satır boşluk bırakmak için kullanılır.

            int xx= 6;
            string yy= xx.ToString();
            Console.WriteLine(yy);

            string zz = 12.7f.ToString(); // tanım esnasında da tip dönüşümü yapabiliyoruz.
            Console.WriteLine(zz);

            // iki string değerini integer türüne çevirip toplayalım

            string c1 = "7",c2="9";
            int d1,d2;
            int result;
            d1 = Convert.ToInt32(c1);
            d2 = Convert.ToInt32(c2);
            result= d1+d2;
            Console.WriteLine("Sonuç: "+result);



            // Parse ile convert yapma

            string asd1 = "11",asdf="11.1";
            int rakam1;
            double rakam2;
            rakam1 = Int32.Parse(asd1);
            rakam2 = Double.Parse(asdf);
            
            Console.WriteLine("Rakam1: "+rakam1);
            Console.WriteLine("Rakam2: "+rakam2);


        }
    }
}
