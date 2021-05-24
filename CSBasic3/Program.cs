using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSBasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 52, 172, 13, 13, 103 };
            intArray[2] = 0;
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray[4]);
            Console.WriteLine(intArray.Length);

            int[] intArray2 = new int[1000];
            Console.WriteLine(intArray2[0]);
            Console.WriteLine(intArray2[999]);


            int i = 0;
            int[] intArray3 = { 52, 273, 32, 65, 103 };
            while(i < intArray3.Length)
            {
                Console.WriteLine(i + "번째 출력:" + intArray3[i]);
                i++;
            }

            string input;
            do
            {
                Console.Write("입력(exit를 입력하면 종료) : ");
                input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        Console.WriteLine("go 공지사항");
                        break;
                    case "2":
                        Console.WriteLine("go 오늘의 점심");
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
   
                }

            } while (input != "exit");

            for(int i2 = '가'; i2 <= '힣'; i2++)
            {
                Console.Write((char)i2);
            }

            for(i = intArray3.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }

            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }

            for(i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            for(i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10-i; j++)
                {
                    Console.Write(' ');
                }
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.Write('\n');
            }



            string inputString = "Potato Tomato";
            inputString.ToUpper();
            Console.WriteLine(inputString);
            Console.WriteLine(inputString.ToLower()); // C#에서 String 관련 함수들은 원본을 건들지 않는다. 복사해서 반환
            Console.WriteLine(inputString);


            string foodString = "감자 고구마 토마토 치킨";
            string[] foods = foodString.Split(new char[] { ' ' });
            foreach(var food in foods)
            {
                Console.WriteLine(food);
            }

            string pathString = "C:\\Program Files (x86)\\Common Files\\Oracle\\Java\\javapath;C:\\Python27;C:\\Python27\\Scripts;C:\\oraclexe\\app\\oracle\\product\\11.2.0\\server\\bin;C:\\windows\\system32;C:\\windows;C:\\windows\\System32\\Wbem;C:\\windows\\System32\\WindowsPowerShell\\v1.0\\;C:\\windows\\System32\\OpenSSH\\;C:\\Program Files (x86)\\NVIDIA Corporation\\PhysX\\Common;C:\\Program Files\\NVIDIA Corporation\\NVIDIA NvDLISR;C:\\Program Files\\Git\\cmd;C:\\Users\\ckdgh\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Python 3.7;C:\\Bitnami\\wampstack-7.4.8-0\\mysql\\bin;C:\\Program Files\\MySQL\\MySQL Server 8.0\\bin;C:\\Program Files\\dotnet\\;C:\\Program Files\\nodejs\\;C:\\Program Files\\Microsoft SQL Server\\130\\Tools\\Binn\\;C:\\Program Files\\Microsoft SQL Server\\Client SDK\\ODBC\\170\\Tools\\Binn\\;%SystemRoot%\\system32;%SystemRoot%;%SystemRoot%\\System32\\Wbem;%SYSTEMROOT%\\System32\\WindowsPowerShell\\v1.0\\;%SYSTEMROOT%\\System32\\OpenSSH\\;C:\\Program Files\\Docker\\Docker\\resources\\bin;C:\\ProgramData\\DockerDesktop\\version-bin;C:\\cassandra\\apache-cassandra-3.11.10\\bin;C:\\Program Files\\Java\\jdk1.8.0_241\\bin;";
            string[] paths = pathString.Split(new char[] { ';' });
            foreach(var path in paths)
            {
                Console.WriteLine(path);
            }

            string StrangeInput = "   text \n            \n";
            Console.WriteLine("[" + StrangeInput + "]");
            Console.WriteLine("[" + StrangeInput.Trim() + "]");

            string[] foodsArray = { "감자", "고구마", "토마토" };
            Console.WriteLine(string.Join(", ", foodsArray));

            Console.Clear();
            Console.WriteLine("포맷 중 :  0% [__________]");

            for (int f = 0; f < 10; f++)
            {

                Console.SetCursorPosition(0, 0);
                Console.Write("포맷 중 : ");
                Console.Write((f + 1) * 10 + "%[");
                for (int f2 = 0; f2 < f; f2++)
                    Console.Write("#");
                for (int f2 = f + 1; f2 < 10; f2++)
                    Console.Write("_");
                Console.WriteLine("]");
                Thread.Sleep(1000);
            }
            Thread.Sleep(3000);


            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);
                if (x % 3 == 0)
                    Console.WriteLine("__0");
                else if (x % 3 == 1)
                    Console.WriteLine("_^0");
                else
                    Console.WriteLine("^_0");
                Thread.Sleep(1000);
                x++;
            }


        }



    }
}
