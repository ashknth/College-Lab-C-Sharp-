using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        int a;
        int b;
        int mod;
        int sd;


        public void oddEven()
        {
            Console.WriteLine("Enter a number::");
            a = Convert.ToInt32(Console.ReadLine());


            if (a % 2 == 0)
            {
                Console.WriteLine("The number {0} is even", a);
            }
            else
            {
                Console.WriteLine("The number {0} is odd", a);

            }
            Console.ReadLine();
        }

        public int Add()
        {
            Console.WriteLine("Enter two number::");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            return a == b ? (a + b) * 3 : a + b;
            Console.WriteLine("The sum of two numbers {0} and {1} is {2}", a, b, a + b);

        }

        public void Nums()
        {
            Console.WriteLine("Enter  number::");
            a = Convert.ToInt32(Console.ReadLine());
            while (a > 0)
            {
                mod = a % 10;
                sd = sd + mod;
                a = a / 10;
            }
            Console.WriteLine("The sum of two numbers {0}", sd);


        }
        public void Rev()
        {
            Console.WriteLine("Enter  number::");
            a = Convert.ToInt32(Console.ReadLine());
            
            while (a > 0)
            {
                mod = a % 10;
                sd = sd*10 + mod;
                a = a / 10;
            }
            Console.WriteLine("The  reverse of number is {0}",sd );

        }

        public bool check(int a, int b)
        {
            //Console.WriteLine("Enter two number::");
          //  a = Convert.ToInt32(Console.ReadLine());
           // b = Convert.ToInt32(Console.ReadLine());
            return(a==30 || b==30 || (a + b)==30);
           // Console.WriteLine("The sum of two numbers {0} and {1} is {2}", a, b, a + b);

        }


        public bool multiple(int a)
        {
            return (a % 3 == 0 || a % 7 == 0);

        }


        public void Menu()
        {
            int choice;
            Console.WriteLine("1.OddEven \n 2.Add 2 num  \n 3.digitSum  \n 4.Reverse  \n 5.Return true if one of them is 30  \n 6.Multiple of 3 or 7\n");
            Console.WriteLine("Enter your choice::");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    oddEven();
                    break;
                case 2:
                    Add();
                    break;
                case 3:
                    Nums();
                    break;
                case 4:
                    Rev();
                    break;
                case 5:
                    Console.WriteLine(check(10,20));
                    Console.WriteLine(check(10,0));
                    Console.WriteLine(check(30,0));
                    break;
                case 6:
                   
                    Console.WriteLine(multiple(7));
                    Console.WriteLine(multiple(3));
                    Console.WriteLine(multiple(5));
                    Console.WriteLine(multiple(2));
                    
                    break;

            }
        }

      
  

        public static void Main(string[] args)
        {
            int a;
            int b;
            Program program = new Program();
            while (true)
            {
                program.Menu();
            }


        }
    }
}
   
    
