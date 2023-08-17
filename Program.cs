//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using My_FirstProject.Common;
namespace My_FirstProject
{
    public class program
    {
        //static int x = 100;
        //int y = 200;
        //const double id = 1.05;
        //public program(int a) {
        //y = a;
        //}
        public int ProductofNumbers(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        { 
            int x= Convert.ToInt32(Console.ReadLine());
            int y= Convert.ToInt32(Console.ReadLine());
            program solution = new program();
            Console.WriteLine(solution.ProductofNumbers(x,y));
            Employee employee = new Employee();
            employee.Name = "Vamsi";
            employee.Id = 559;
         
            /*
            int num =Convert.ToInt32(Console.ReadLine());
            //int num = Console.Read();
            Console.WriteLine(num==10);
            //Console.WriteLine(num);
            if (num >= 10)
            {
                Console.WriteLine("greater than 10");
            }
            else
            { 
                Console.WriteLine("less than 10");
            }
            Console.WriteLine("while");
            while(num > 0)
            {
                Console.WriteLine(num);
                num--;
            }
            Console.WriteLine("do while");
            do
            {
                Console.WriteLine(num);
                num++;
            } while(num < 0);
            */
            //Char str= Convert.ToChar(Console.Read());
            //for( int i = 0; i < num; i++ )
            //{
            //    Console.WriteLine(i);
            //}
            /*
            int x = 10;
            int res1 = x++;
            Console.WriteLine(res1);
            int y= 10;
            int res2 = ++y;
            Console.WriteLine(res2);
            */
            //Console.WriteLine(x);
            //x = 150;
            //program obj1 = new program(400);
            //program obj2 = new program(300);
            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2.y);
            //Console.WriteLine(id);
            /*
            //Console.WriteLine("Vamsi chokkapu");
            //Console.WriteLine("Hello");
            //Console.Write("Vamsi");
            //Console.WriteLine("Let's see");
            
            string str = "ABC";
            Console.WriteLine(str);
            //Console.ReadKey();
            Console.WriteLine(str.Length);
            


            int num1 = 250; // 256, 300, 400 ...
            byte bytenum1= (byte)num1;
            Console.WriteLine(bytenum1);
            Console.WriteLine(bytenum1.GetType());
            //Conversion between non-compatible types like int and string.
            string str = "100";
            //int num = int.Parse(str);
            int num = Convert.ToInt32(str);
            Console.WriteLine(num);
            */

            Console.ReadKey();

        }
    }
}