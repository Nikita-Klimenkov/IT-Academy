using System;
using System.Collections.Generic;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReceptOfSushi();

            PrimitiveDataInitialization();

            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadLine();
            Console.Clear();

            ImplicitConversion();
            ExplicitConversion();

            Boxing();
            UnBoxing();

            //WorkWithVarVariable();

            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadLine();
            Console.Clear();


            FindCountOfMeters();
        }

        private static void PrimitiveDataInitialization()
        {
            List<object> types = new List<object>();

            Console.Write("\nВведите необходимое значение _double: ");
            double _double = Convert.ToDouble(Console.ReadLine());
            types.Add(_double);

            Console.Write("\nВведите необходимое значение _bool: ");
            bool _bool = Convert.ToBoolean(Console.ReadLine());
            types.Add(_bool);

            Console.Write("\nВведите необходимое значение _byte: ");
            byte _byte = Convert.ToByte(Console.ReadLine());
            types.Add(_byte);

            Console.Write("\nВведите необходимое значение _uint: ");
            uint _uint = Convert.ToUInt32(Console.ReadLine());
            types.Add(_uint);

            Console.Write("\nВведите необходимое значение _sbyte: ");
            sbyte _sbyte = Convert.ToSByte(Console.ReadLine());
            types.Add(_sbyte);

            Console.Write("\nВведите необходимое значение _decimal: ");
            decimal _decimal = Convert.ToDecimal(Console.ReadLine());
            types.Add(_decimal);

            Console.Write("\nВведите необходимое значение _char: ");
            char _char = Convert.ToChar(Console.ReadLine());
            types.Add(_char);

            Console.Write("\nВведите необходимое значение _float: ");
            float _float = Convert.ToSingle(Console.ReadLine());
            types.Add(_float);

            Console.Write("\nВведите необходимое значение _int: ");
            int _int = Convert.ToInt32(Console.ReadLine());
            types.Add(_int);

            Console.Write("\nВведите необходимое значение _long: ");
            long _long = Convert.ToInt64(Console.ReadLine());
            types.Add(_long);

            Console.Write("\nВведите необходимое значение _ulong: ");
            ulong _ulong = Convert.ToUInt64(Console.ReadLine());
            types.Add(_ulong);

            Console.Write("\nВведите необходимое значение _short: ");
            short _short = Convert.ToInt16(Console.ReadLine());
            types.Add(_short);

            Console.Write("\nВведите необходимое значение ushort: ");
            ushort _ushort = Convert.ToUInt16(Console.ReadLine());
            types.Add(_ushort);

            Console.Write("\nВведите необходимое значение _object: ");
            object _object = Console.ReadLine();
            types.Add(_object);

            Console.Write("\nВведите необходимое значение _string: ");
            string _string = Console.ReadLine();
            types.Add(_string);

            Console.Clear();
            foreach (var type in types)
            {
                Console.WriteLine($"{type}, \t{type.GetType()}");
            }
        }

        private static void ImplicitConversion()
        {
            byte _byte = 10;

            short _short = _byte;
            int _int = _short;
            long _long = _int;
            decimal _decimal = _long;
            
        }

        private static void ExplicitConversion()
        {
            double _double = 14.1;
            int _int = 36;
            short _short = 2;
            ulong _ulong = 167;
            float _float = 14.2f;

            decimal _decimal = (decimal)_double;
            byte _byte = (byte)_int;
            uint _uint = (uint)_ulong;
            long _long = (long)_float;
            ushort _ushort = (ushort)_int;
        }

        private static void Boxing()
        {
            int _int = 0;
            object obj = 1;
            obj = _int;
        }

        private static void UnBoxing()
        {
            int _int = 0;
            object _obj = 1;
            _int = (int)_obj;
        }

        private static void WorkWithVarVariable()
        {
            var _string = "Hello"; 
            var _int = 45788;
            var _char = new[] {'h', '5', '/'};

           // _string = 5; //Выдаётся ошибка так как изначально переменная var имеет тип данных string, и мы не можем поменять его.
        }

        private static void FindCountOfMeters()
        {
            Console.WriteLine("Введите количество сантиметров: ");
            float sancentimeter = Convert.ToInt32(Console.ReadLine());

            int result = (int)sancentimeter / 100;
            Console.WriteLine($"Ответ: {result} метров");
        }

        private static void ReceptOfSushi()
        {
            Console.WriteLine("Как приготовить суши без СМС и регистрации. \n" +
                "Для этого нам понядобится: \n" +
                "1) Японский уксус\n"+
                "2) Соевый соус\n" +
                "3) Гари\n" +
                "4) Нори\n" +
                "5) Японский рис\n" +
                "6) Форель и свежий огурец\n");

            Console.WriteLine("Введите количество мг японского уксуса который вы хотитите добавить: ");
            int japaneseVinegar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество стаканов с рисом :");
            int countOfRice = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < countOfRice; i++)
            {
                Console.WriteLine("Добавили 1 стакан с рисом");
            }

            Console.WriteLine("Введите количество ломтиков нури :");
            int countOfNuri = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество ложек соли :");
            int countOfSalt = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < countOfSalt; i++)
            {
                Console.WriteLine("Добавили 1 ложку соли");
            }

            Console.WriteLine("Рис должен постоять 10 минут \nТеперь начинаем заворачивать в лист нури рис и форель со свежим огурцом");
            Console.WriteLine("Остался последний штрих - У вас имеется специальный набор для суши?");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "ДА")
            {
                Console.WriteLine("Поздравляю вы сделали замечательные суши, берём наш набор и наслаждаемся");
            }
            else
            {
                Console.WriteLine("Поздравляю вы сделали замечательные суши, набора у нас нету, но ничего страшного и без него довольно вкусно");
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
