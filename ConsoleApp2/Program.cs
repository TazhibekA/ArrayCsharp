using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ThirdTask();
        }

        static void FirstTask()
        {
            Console.WriteLine("Enter some symbols: ");
            int input;
            int spaceCount = 0;
            do
            {
                input = (char)Console.Read(); // по разному пытался, не понимаю как правильно это сделать
                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');

            Console.WriteLine("Quantity of spaces: " + spaceCount);
            Console.Read();
        }

        static void SecondTask() {
            int[] array=new int [6];
            int firstSum = 0;
            int secondSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i < 3)
                {
                    firstSum = firstSum + array[i];
                }
               else if (i>2 && i<6){
                    secondSum = secondSum + array[i];
                }
            }

            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");

            }
            Console.Read();

        }

        static void FourthTask()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            for (; A <= B; A++)
            {
                for (int i = 0; i < A; i++)
                    Console.Write(A);
                Console.WriteLine();
            }
            
            Console.Read();

        }

        static void FifthTask()
        {
            
            int N = int.Parse(Console.ReadLine());
            string str = "";

            while (N >= 10)
            {
                str += (N % 10).ToString();
                N = N / 10;
            }

            str += N.ToString();
            Console.WriteLine(str);

        }
        static void ThirdTask()
        { 
            char secondSymbol = ' ';
            Console.WriteLine("Enter : ");
            while (true)
            {
                var symbol = Console.Read();

                if (symbol >= 65 && symbol <= 90)
                {
                    symbol += 32;
                }
                else if (symbol >= 97 && symbol <= 122)
                {
                    symbol -= 32;
                }
                secondSymbol = Convert.ToChar(symbol);
                Console.Write(secondSymbol);
            }
          
        }

    }
}
