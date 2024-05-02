using kalkulatorLibrary;
using System;

namespace kalkutor
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator 2 Digit Paling Legit sejagat raya");
            Console.WriteLine(" ");
            Console.WriteLine("Masukkan angka pertama\t:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan angka kedua\t:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Operasi ( + , -, *, / , % )");
            char operasi = Convert.ToChar(Console.ReadLine());
            double hasil = 0;
            if (operasi == '+')
            {
                hasil = point.Penambahan(num1, num2);
            }
            else if(operasi == '-')
            {
                hasil = point.Pengurangan(num1, num2);
            }
            else if (operasi == '*')
            {
                hasil = point.Perkalian(num1, num2);
            }
            else if(operasi == '/')
            {
                hasil = point.Pembagian(num1, num2);
            }
            else if(operasi == '%')
            {
                hasil = point.Modulo(num1, num2);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Hasil\t:" + hasil);

        }
    }
}
