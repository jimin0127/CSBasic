using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        string var = "테스트";
        static void Main(string[] args)
        {
            var name = "이" + "지" + "민";
            Console.Write("개행이 안되는 녀석");
            Console.WriteLine("개행이 되는 녀석");

            var alpha = "알파";
            //var 273alpha = "숫자이름";
            var 한글변수명 = "된당";
            //string 😊 = "이모지는 안된다. ";

            // 인라인 주석
            /*
              여러줄 주석
             */


            //출력
            Console.Write("개행이 안되는 출력\n");
            Console.Write("");
            Console.WriteLine("개행이 되는 출력");

            Console.WriteLine(52);
            // Arithmetic Operator +  - *
            Console.WriteLine(52 + 273);
            // Operator Priority
            Console.WriteLine(52 + 3 * 2);

            Console.WriteLine(10 / 5);
            Console.WriteLine(10 % 5);
            Console.WriteLine(7%3);

            // Real Number
            Console.WriteLine(52.273);
            Console.WriteLine(0);
            Console.WriteLine(0.0);


            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * 2.0);
            Console.WriteLine(1.0 / 2.0);
            Console.WriteLine(1 / 2);
            Console.WriteLine(1 / 2.0);

            Console.WriteLine('A');
            Console.WriteLine('가');
            //Console.WriteLine('AB');

            Console.WriteLine("AB");

            Console.WriteLine("미림\t여자정보\t과학고");
            Console.WriteLine("미림여자정보과학고\t안녕");
            Console.WriteLine("미림\t여자정보\t과학고");
            Console.WriteLine("미림여\t자정보\t과학고");
            Console.WriteLine("미\t여자정보과학고\t안녕");
            Console.WriteLine("\\역슬래시 \n 엔터문자 \"큰 따옴표");

            // 문자열 연결 연산자 Concatenation Operator
            Console.WriteLine("A" + "B");
            Console.WriteLine("A" + 1);
            Console.WriteLine(1 + "A");
            Console.WriteLine("1" + "1");
            Console.WriteLine('A' + 'B');
            Console.WriteLine('A' - 'B');
            //Console.WriteLine("A" - "B"); --> 에러 

            Console.WriteLine("안녕하세요!"[0]);
            Console.WriteLine("안녕하세요!"[1]);
            Console.WriteLine("안녕하세요!"[2]);
            Console.WriteLine("안녕하세요!"[3]);
            //Console.WriteLine("안녕하세요!"[100]);
            //Console.WriteLine("안녕하세요!"[-1]);


            // bool / boolean
            Console.WriteLine(true); //True 대문자로 출력
            Console.WriteLine(false); //False 대문자로 출력


            // Comparison operator
            // == != > < >= <= 
            // => =< <-- 안됨

            Console.WriteLine(62 < 273);

            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Hour > 3 && 8 > DateTime.Now.Hour);


            // integer overflow
            int a = 2147483647;
            int b = 1;
            Console.WriteLine(a + b);

            double c = 52.263;
            char d = '아';

            //sizeof 연산자
            Console.WriteLine("int : " + sizeof(int));
            Console.WriteLine("long : " + sizeof(long));
            Console.WriteLine("float : " + sizeof(float));
            Console.WriteLine("double " + sizeof(double));
            Console.WriteLine("char : " + sizeof(char));
            Console.WriteLine("bool : " + sizeof(bool));

            bool TrueOrFalse = true;

            //복합 대입 연산자
            int output = 0;
            output += 52;
            output += 273;
            output += 103;

            Console.WriteLine(output);
            output *= 2;
            Console.WriteLine(output);

            //문자열 관련 복합 대입 연산자
            string output2 = "Hello ";
            output2 += "World";
            output2 += "!";
            Console.WriteLine(output2);

            //증감 연산자
            int number = 10;                //num 출력
            Console.WriteLine(number++);    // 11 10
            Console.WriteLine(++number);    // 12 12
            Console.WriteLine(number--);    // 11 12
            Console.WriteLine(--number);    // 10 10 
            Console.WriteLine(number);      // 10

            number = 10;
            number++;
            Console.WriteLine(number);
            ++number;
            Console.WriteLine(number);
            number--;
            Console.WriteLine(number);
            --number;
            Console.WriteLine(number);

            int _int = 273;
            long _long = 62439248734;
            float _float = 52.273F;
            double _double = 52.273;
            char _char = '글';
            string _string = "문자열";

            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());
            Console.WriteLine((2211111111).GetType()); //UInt32


        }
    }
}
