using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasic4
{
    class MyMath
    {
        public int a; 
        public static double PI = 3.141592;
        public static void Hello()
        {
            //a = 3;
            Console.WriteLine("Greeting~");
        }
    }
    class Product
    {
        public string name = "default";
        public int price = 1000;

        public override string ToString()
        {
            return this.name + " / " + this.price;
        }
    }

    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }

    }


    class Program
    {
        /*class Math
        {
           클래스 이름 충돌  
        }*/
        static void Main(string[] args)
        {
            Car[] cars = new Car[10];

            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100)); //0부터 100미만 (0 ~ 99)
            Console.WriteLine(random.Next(10, 100)); //
            
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 100);

            List<int> list = new List<int>();
            list.Add(52);
            list.Add(15);
            list.Add(8);
            list.Add(89);

            foreach(var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem: " + item);
            }
            list.Remove(52);
            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem: " + item);
                //list.Remove(item);
            }

            Console.WriteLine(Math.Abs(-52288));
            Console.WriteLine(Math.Ceiling(53.273));
            Console.WriteLine(Math.Floor(53.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));

            Product product = new Product();
            Console.WriteLine(product);
            Product productA = new Product() { name = "감자", price = 20000 };
            Console.WriteLine(productA);
            Product productB = new Product() { name = "고구마", price = 3000 };
            Console.WriteLine(productB);

            // static 변수는 인스턴스를 생성하지 않고 사용할 수 있다. 
            Console.WriteLine(MyMath.PI);
            MyMath.Hello();

        }
    }


    class FirstClass
    {

    }
    class SecondClass
    {
        class ChildClass
        {

        }
    }
}
