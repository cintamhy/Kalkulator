using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Kalkulator kal = new Kalkulator{};
            double Hasil;
            Console.WriteLine("Input angka pertama : ");
            string nilaiPertama = Console.ReadLine();

            Console.WriteLine("Input angka kedua : ");
            string nilaiKedua = Console.ReadLine();

            Console.WriteLine("Pilih Jenis Operasi : ");
            Console.WriteLine("     1. Tambah       ");
            Console.WriteLine("     2. Kurang       ");
            Console.WriteLine("     3. Kali     ");
            Console.WriteLine("     4. Bagi     ");
            Console.WriteLine("     5. Pangkat      ");
            string operasi = Console.ReadLine();
            switch(operasi)
            {
                case "1" :
                Hasil = kal.Tambah(double.Parse(nilaiPertama), double.Parse(nilaiKedua));
                if(Hasil <= 0)
                {
                    Hasil = 0;
                }
                Console.WriteLine(nilaiPertama+" + "+nilaiKedua+" = "+Hasil);
                break;

                case "2" :
                Hasil = kal.Kurang(double.Parse(nilaiPertama), double.Parse(nilaiKedua));
                if(Hasil <= 0)
                {
                    Hasil = 0;
                }
                Console.WriteLine(nilaiPertama+" - "+nilaiKedua+" = "+Hasil);
                break;

                case "3" :
                Hasil = kal.Kali(double.Parse(nilaiPertama), double.Parse(nilaiKedua));
                if(Hasil <= 0)
                {
                    Hasil = 0;
                }
                Console.WriteLine(nilaiPertama+" x "+nilaiKedua+" = "+Hasil);
                break;

                case "4" :
                Hasil = kal.Bagi(double.Parse(nilaiPertama), double.Parse(nilaiKedua));
                if(Hasil <= 0)
                {
                    Hasil = 0;
                }
                Console.WriteLine(nilaiPertama+" : "+nilaiKedua+" = "+Hasil);
                break;

                case "5" :
                Hasil = kal.Pangkat(double.Parse(nilaiPertama), double.Parse(nilaiKedua));
                if(Hasil <= 0)
                {
                    Hasil = 0;
                }
                Console.WriteLine(nilaiPertama+" ^ "+nilaiKedua+" = "+Hasil);
                break;
            }
            }
            catch(System.DivideByZeroException)
            {
                Console.WriteLine("Hasil Operasi tidak berfungsi");
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Masukan nilai yang valid");
            }
        }

        class Kalkulator
        {
            double Hasil;
            public Kalkulator()
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("||||||||||  o(^-^)o   Ini Adalah Kalkulator Sederhana Dengan Bahasa C# Oleh Cinta Maharany  o(^-^)o   ||||||||||");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            }
            public double Tambah (double input1, double Input2)
            {
                return input1 + Input2;
            }
            public double Kurang (double input1, double Input2)
            {
                return input1 - Input2;
            }
            public double Kali (double input1, double Input2)
            {
                return input1 * Input2;
            }
            public double Bagi (double input1, double Input2)
            {
                return input1 / Input2;
            }
            public double Pangkat (double input1, double Input2)
            {
                return Math.Pow(input1, Input2);
            }
        }
    }
}
