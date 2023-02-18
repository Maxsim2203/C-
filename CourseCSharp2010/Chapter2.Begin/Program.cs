using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2.Begin
{
    class Program
    {
        static void Main(string[] args)
        {




            // блок кода

            {
                Console.WriteLine("Block code");
            }


            // register

            {
                int a = 3;
                int A = 3;
            }


            // const

            const int b = 3;
            //b = 4;


            // Логические литералы

            Console.WriteLine(true);
            
            // Целочисленные литералы

            Console.WriteLine(3);


            // for not C#8
            //Console.WriteLine(0b11);        // 3
            //Console.WriteLine(0b1011);      // 11
            //Console.WriteLine(0b100001);    // 33

            Console.WriteLine();
            Console.WriteLine(0x0A);    // 10
            Console.WriteLine(0xFF);    // 255
            Console.WriteLine(0xA1);    // 161

            // Вещественные литералы

            Console.WriteLine();
            Console.WriteLine(3.2e3);   // по сути равно 3.2 * 10<sup>3</sup> = 3200
            Console.WriteLine(1.2E-1);  // равно 1.2 * 10<sup>-1</sup> = 0.12

            // Символьные литералы

            Console.WriteLine();
            Console.WriteLine('2');
            Console.WriteLine('A');
            Console.WriteLine('T');


            // Управляющие последовательности

            Console.WriteLine();
            Console.WriteLine("a\tb");


            // ASCII

            Console.WriteLine();
            Console.WriteLine('\x78');    // x
            Console.WriteLine('\x5A');    // Z

            // Unicode

            Console.WriteLine();
            Console.WriteLine('\u0420');    // Р
            Console.WriteLine('\u0421');    // С

            // Строковые литералы

            Console.WriteLine();
            Console.WriteLine("hello");
            Console.WriteLine("фыва");
            Console.WriteLine("hello word");

            Console.WriteLine();
            Console.WriteLine("Компания \"Рога и копыта\"");
            
            Console.WriteLine();
            Console.WriteLine("Привет \nмир");


            // null представляет ссылку, которая не указывает ни на какой объект. То есть по сути отсутствие значения.

            // системы счисления

            Console.WriteLine(Convert.ToString(100, 2));
            Console.WriteLine(Convert.ToString(100, 8));
            Console.WriteLine(Convert.ToString(100, 16));


            // Типы данных

            // bool: хранит значение true или false (логические литералы). Представлен системным типом System.Boolean

            bool alive = true;
            bool isDead = false;

            // byte: хранит целое число от 0 до 255 и занимает 1 байт. Представлен системным типом System.Byte

            byte bit1 = 1;
            byte bit2 = 102;

            // sbyte: хранит целое число от -128 до 127 и занимает 1 байт. Представлен системным типом System.SByte

            sbyte bit3 = -101;
            sbyte bit4 = 102;

            // short: хранит целое число от -32768 до 32767 и занимает 2 байта. Представлен системным типом System.Int16

            short n1 = 1;
            short n2 = 102;


            // ushort: хранит целое число от 0 до 65535 и занимает 2 байта. Представлен системным типом System.UInt16

            ushort n3 = 1;
            ushort n4 = 102;


            //int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта. Представлен системным типом System.Int32. Все целочисленные литералы по умолчанию представляют значения типа int:
            
            int a1 = 10;
            //int b1 = 0b101;  // бинарная форма b =5
            int c1 = 0xFF;   // шестнадцатеричная форма c = 255

            //uint: хранит целое число от 0 до 4294967295 и занимает 4 байта. Представлен системным типом System.UInt32

            uint a2 = 10;
            //uint b2 = 0b101;
            uint c2 = 0xFF;

            //long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт. Представлен системным типом System.Int64

            long a3 = -10;
            //long b3 = 0b101;
            long c3 = 0xFF;

            //ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт. Представлен системным типом System.UInt64

            ulong a4 = 10;
            //ulong b4 = 0b101;
            ulong c4 = 0xFF;

            //float: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта. Представлен системным типом System.Single
        
            //double: хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта. Представлен системным типом System.Double
        

            //decimal: хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт. Представлен системным типом System.Decimal


            //char: хранит одиночный символ в кодировке Unicode и занимает 2 байта. Представлен системным типом System.Char. Этому типу соответствуют символьные литералы:

            char a5 = 'A';
            char b5 = '\x5A';
            char c5 = '\u0420';

            // string: хранит набор символов Unicode. Представлен системным типом System.String. Этому типу соответствуют строковые литералы.

            string hello = "Hello";
            string word = "world";

            //object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе. Представлен системным типом System.Object, который является базовым для всех других типов и классов .NET.

            object a7 = 22;
            object b7 = 3.14;
            object c7 = "hello code";


            // Использование суффиксов

            /*
             * 
             * При присвоении значений надо иметь в виду следующую тонкость: все вещественные литералы (дробные числа) рассматриваются 
             * как значения типа double. И чтобы указать, что дробное число представляет тип float или тип decimal, 
             * необходимо к литералу добавлять суффикс: F/f - для float и M/m - для decimal.
             * 
             */


            float a8 = 3.14F;
            float b8 = 30.6f;

            decimal c = 1005.8M;
            decimal d = 334.8m;


            /*
             Подобным образом все целочисленные литералы рассматриваются как значения типа int. Чтобы явным образом указать,
             * что целочисленный литерал представляет значение типа uint, надо использовать суффикс U/u,
             * для типа long - суффикс L/l, а для типа ulong - суффикс UL/ul: 
             */

            uint a9 = 10U;
            long b9 = 20L;
            ulong c10 = (int)30UL;



            // Неявная типизация

            var hello1 = "Hell to World";
            var c11 = 20;




            // Консольный ввод-вывод
            Console.WriteLine("Some text");

            // Интерполяция
            int someText = 10;
            Console.WriteLine(String.Format("{0}", someText));

            Console.WriteLine("{0}", someText);
            
            Console.Write(someText);
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
