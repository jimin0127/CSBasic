using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    abstract class AbstractParent
    {
        public abstract void Test();
    }

    class AbstractChild : AbstractParent
    {
        public override void Test() { }
    }

    class Animal
    {
        public int Age { get; set; }
        public Animal() { this.Age = 0; }
        public void Eat() { Console.WriteLine("냠냠 먹습니다. "); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다. "); }
    }

    class Dog : Animal
    {
        public string Color { get; set; }
        public void Bark() { Console.WriteLine("왈왈 짓습니다."); }

    }

    class Parent
    {
        public int variable = 273;
        /*public void Method()
        {
            Console.WriteLine("부모의 메소드");
        }*/
        public virtual void Method() // 오버라이드 할 수 있도록 virtual
        {
            Console.WriteLine("부모의 메소드");
        }

    }
    class Child: Parent
    {
        public string variable = "shadowing";
        public override void Method() // 오버라이드(virtual 명시된 메서드만)
        {
            Console.WriteLine("자식의 메서드");
        }
        /*public new void Method() // 명시 하이딩
        {
            Console.WriteLine("자식의 메소드");
        }*/
    }


    class Cat : Animal
    {
        public void Meow() { Console.WriteLine("냥냥 웁니다."); }

    }


        class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();
            Console.WriteLine((new Child()).variable);

            Console.WriteLine(((Parent)(new Child())).variable);
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Cat()
            };
            
            foreach(var item in Animals)
            {
                item.Eat();
                item.Sleep();
                ((Cat)item).Meow();
            }
        }
    }
}
