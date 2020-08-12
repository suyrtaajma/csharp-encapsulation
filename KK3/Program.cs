using System;

namespace KK3
{
    //Aritmatika
    
    /*/Persegi
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Persegi--------------");
            Console.WriteLine("Masukan Sisi  = ");
            int a = Convert.ToInt32(Console.ReadLine());
            double keliling = 4 * a;
            double luas = a * a;
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("Hasil Keliling Persegi    = " + keliling);
            Console.WriteLine("Hasil Luas Persegi        = " + luas);
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.ReadLine();
        }
    }*/

    /*/Persegi Panjang
    class persegiPanjang
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Persegi Panjang------------");
            Console.WriteLine("\nMasukan Nilai Panjang  = ");           //
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Lebar    = ");
            int b = Convert.ToInt32(Console.ReadLine());
            double keliling = 2 * (a + b);
            double luas = a * b;
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("Hasil Keliling Persegi Panjang   = " + keliling);
            Console.WriteLine("Hasil Luas Persegi Panjang       = " + luas);
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.ReadLine();
        }
    }*/

    /*/Segi3
    class segi3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Segitiga---------------");
            Console.WriteLine("\nMasukan Nilai Alas      = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Tinggi    = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Sisi      = ");
            int c = Convert.ToInt32(Console.ReadLine());
            double keliling = c + c + c;
            double luas = 0.5 * a * b;
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("Hasil Keliling Segitiga  = " + keliling);
            Console.WriteLine("Hasil Luas Segitiga      = " + luas);
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.ReadLine();
        }
     }*/

   /*/ Layang layang
    class layang
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Layang-layang------------");
            Console.WriteLine("\nMasukan Nilai Sisi 1   = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Sisi 2   = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Sisi 1   = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Sisi 2   = ");
            int d = Convert.ToInt32(Console.ReadLine());
            double keliling = c * d;
            double luas = a * b;
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("Hasil Keliling Layang - layang    = " + keliling);
            Console.WriteLine("Hasil Luas Layang - layang        = " + luas);
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.ReadLine();
        }
    }*/

    /*/Jajar Genjang
    class jajarg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Jajar Genjang------------");
            Console.WriteLine("\nMasukan Nilai Alas   = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Tinggi   = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Sisi 1   = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Sisi 2   = ");
            int d = Convert.ToInt32(Console.ReadLine());
            double keliling = 2 * (c + d);
            double luas = a * b;
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("Hasil Keliling Jajar Genjang    = " + keliling);
            Console.WriteLine("Hasil Luas Jajar Genjang        = " + luas);
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.ReadLine();
        }
    }*/

    /*/Trapesium
    class trape
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Trapesium--------------");
            Console.WriteLine("\nMasukan Nilai Sisi 1   = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Sisi 2   = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Sisi 3   = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Sisi 4   = ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Tinggi   = ");
            int e = Convert.ToInt32(Console.ReadLine());
            double keliling = a + b + c + d;
            double luas = 0.5 * (a * b) * e;
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("Hasil Keliling Trapesium    = " + keliling);
            Console.WriteLine("Hasil Luas Trapesium        = " + luas);
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.ReadLine();
        }
    }*/

    //Belah Ketuapt
    class belahk
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Belah Ketupat------------");
            Console.WriteLine("\nMasukan Nilai Diagonal 1   = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Diagoanl 2   = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Sisi         = ");
            int c = Convert.ToInt32(Console.ReadLine());
            double keliling = 4 * c;
            double luas = 0.5 * a * b;
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("Hasil Keliling Belah Ketupat    = " + keliling);
            Console.WriteLine("Hasil Luas Belah Ketupat        = " + luas);
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.ReadLine();
        }
    }

    /*//Kubus
      class Program
      {
          static void Main(string[] args)
          {
              Console.WriteLine("\nMasukan Nilai Sisi  : ");
              int a = Convert.ToInt32(Console.ReadLine());
              double luas = 6 * (a * a);
              double volume = a * a * a;
              Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
              Console.WriteLine("Hasil Luas Kubus    = " + luas);
              Console.WriteLine("Hasil Volume Kubus  = " + volume );
              Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
              Console.ReadLine();
          }
      }

     //Balok
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMasukan Nilai Panjang  : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Lebar    : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Tinggi   : ");
            int c = Convert.ToInt32(Console.ReadLine());
            double luasPermu = 2 * ((a * b) + (a * c) + (b * c));
            double luas = luasPermu * 6;
            double vol = a * b * c;
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("Hasil Luas Balok    = " + luas);
            Console.WriteLine("Hasil Volume Balok  = " + vol);
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.ReadLine();
        }
    }

     //Limas
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMasukan Nilai Panjang   = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Lebar   = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Tinggi   = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Sisi   = ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Alas   = ");
            int e = Convert.ToInt32(Console.ReadLine());
            double luasAlas = d * d;
            double luasSelimut = 4 * 0.5 * (e * c);
            double luas = luasAlas + luasAlas + luasSelimut;
            double vol = luasAlas * c / 3;
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("Hasil Luas Limas   = " + luas);
            Console.WriteLine("Hasil Volume Limas = " + vol);
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.ReadLine();
        }
    }

     //Tabung
    class Program
    {
        static void Main(string[] args)
        {
            float phi = 3.14f;
            Console.WriteLine("\nMasukan Nilai Jari-jari    : ");
            float a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Tinggi         : ");
            float b = Convert.ToInt16(Console.ReadLine());
            float kelAlas = 2 * phi * a;
            float luasAlas = phi * (a * a);
            float luasSelimut = kelAlas + luasAlas;
            float luas = (2 * luasAlas) + luasSelimut;
            float vol = phi * (a * a) * b;
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("Hasil Luas Tabung    = " + luas);
            Console.WriteLine("Hasil Volume Tabung  = " + vol);
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.ReadLine();
        }
    }

     //Prisma
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMasukan Nilai Panjang   : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Lebar       : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Tinggi      : ");
            int c = Convert.ToInt32(Console.ReadLine());
            double luasAlas = 0.5 * a * b;
            double luasSelimut = b * c;
            double luas = 2 * luasAlas + luasSelimut;
            double vol = luasAlas * b;
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("Hasil Luas Prisma     = " + luas);
            Console.WriteLine("Hasil Volume Prisma   = " + vol);
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.ReadLine();
        }
    }

     //Kerucut
    class Program
    {
        static void Main(string[] args)
        {
            float seper3 = 0.333f;
            Console.WriteLine("\nMasukan Nilai Sisi        : ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Jari-jar     : ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Tinggi       : ");
            int c = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Masukan Nilai Garis Miring : ");
            int d = Convert.ToInt16(Console.ReadLine());
            float luas = (22 / 7 * b * d) + (22 / 7 * b * a);
            float vol = seper3 * (22 / 7) * (b * b * c);
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("Hasil Luas Kerucut    = " + luas);
            Console.WriteLine("Hasil Volume Kerucut  = " + vol);
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.ReadLine();
        }
    }

    //Bola
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMasukan Nilai Jari-jari  : ");
            float a = Convert.ToInt16(Console.ReadLine());
            float luas = 4 * 22 / 7 * (a * a);
            float vol = 4 / 3 * 22 / 7 * (a * a * a);
            Console.WriteLine("\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("Hasil Luas Bola    = " + luas);
            Console.WriteLine("Hasil Volume Bola  = " + vol);
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.ReadLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n 1. Segitiga \n 2. Persegi \n 3. Persegi Panjang " +
                "\n 4. Jajar Genjang \n 5. Trapezium \n 6. Layang - layang \n 7. Kubus");
            Console.Write("Pilih Menu: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1) {
                Console.WriteLine("1.Segitiga");
            } else if (menu == 2) {
                Console.WriteLine("2.Persegi");
            } else if (menu == 3) {
                Console.WriteLine("3.Persegi Panjang");
            } else if (menu == 4) {
                Console.WriteLine("4.Jajar Genjang");
            } else if (menu == 5){
                Console.WriteLine("5.Trapezium");
            } else if (menu == 6) {
                Console.WriteLine("6.Layang - layang");
            } else if (menu == 7) {
                Console.WriteLine("7.Kubus");
            } else {
                Console.WriteLine("Pilihan menu tidak ditemukan");
            }
            Console.ReadLine();
        }
    }

    class Program
    {
        private static bool x;
        //Perulangan
        static void Main(string[] args)
        {   
            Console.WriteLine("\nOutput 1,2,3,4,5,6,7,8,9,10");
            for (int x = 1; x < 11; x++)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Output 1,3,9,27");
            for (int x = 1; x < 17; x *= 2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Output 3,9,27");
            for (int x = 3; x < 28; x *= 3)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Output 2,8,32");
            for (int x = 2; x < 33; x *= 4)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Output 2,12,72");
            for (int x = 2; x < 72; x *= 4)
            {
                Console.WriteLine(x);
            }       
        }
    }*/

    /*/Pola
    class Program
    {
        private static int a;
        private static int b;
        private static int c;

        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("\n████ 1 ████\n");
            for (int a = 1; a <= n; a++)
            {
                if ((a == 1) || (a == n))
                {
                    for (int b = 1; b <= n; b++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (int b = 1; b <= n; b++)
                    {
                        if ((b == 1) || (b == n))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n████ 2 ████\n");
            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n████ 3 ████\n");
            for (int a = 1; a <= n; a++)
            {
                for (int b = n; b >= a; b--)
                {
                    Console.Write(" ");
                }
                for (int b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n████ 4 ████\n");
            for (int a = 1; a <= n; a++)
            {
                for (int b = n; b > a; b--)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= (2 * a - 1); c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n████ 5 ████\n");
            for (int a = 1; a <= n; a++)
            {
                for (int b = n; b >= a; b--)
                {
                    Console.Write(" ");
                }
                for (int b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                for (int b = 1; b < a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int a = 2; a <= n; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write(" ");
                }
                for (int b = n; b >= a; b--)
                {
                    Console.Write("*");
                }
                for (int b = n; b > a; b--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n████ 6 ████\n");
            for (a = n; a >= 1; a--)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                for (c = a; c < n; c++)
                {
                    Console.Write(" ");
                }
                for (c = a; c < n; c++)
                {
                    Console.Write(" ");
                }
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (a = 1; a <= n; a++)
            { 
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                for (c = a; c < n; c++)
                {
                    Console.Write(" ");
                }
                for (c = a; c < n; c++)
                {
                    Console.Write(" ");
                }
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }*/
}