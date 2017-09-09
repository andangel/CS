using System;

namespace A01整型表
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Marshal.SizeOf(s1));
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=================================================================");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("sbyte类型 占用字节: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", sizeof(sbyte));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("sbyte类型 数值范围: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}  {1}\n", sbyte.MaxValue, sbyte.MinValue);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("byte类型 占用字节: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", sizeof(byte));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("byte类型 数值范围: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}  {1}\n", byte.MaxValue, byte.MinValue);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("char类型 占用字节: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", sizeof(char));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("char类型 数值范围: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"\uffff  \0", char.MaxValue, char.MinValue);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("short类型 占用字节: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", sizeof(short));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("short类型 数值范围: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}  {1}\n", short.MaxValue, short.MinValue);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ushort类型 占用字节: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", sizeof(ushort));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ushort类型 数值范围: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}  {1}\n", ushort.MaxValue, ushort.MinValue);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("int类型 占用字节: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", sizeof(int));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("int类型 数值范围: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}  {1}\n", int.MaxValue, int.MinValue);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("uint类型 占用字节: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", sizeof(uint));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("uint类型 数值范围: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}  {1}\n", uint.MaxValue, uint.MinValue);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("long类型 占用字节: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", sizeof(long));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("long类型 数值范围: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}  {1}\n", long.MaxValue, long.MinValue);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ulong类型 占用字节: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", sizeof(ulong));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ulong类型 数值范围: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}  {1}\n", ulong.MaxValue, ulong.MinValue);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("float类型 占用字节: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", sizeof(float));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("float类型 数值范围: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}  {1}  精度7位\n", float.MaxValue, float.MinValue);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t科学计数法,E-38就是10的-38次方,E+38就是10的38次方\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("double类型 占用字节: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", sizeof(double));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("double类型 数值范围: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}  {1}  精度15-16位\n", double.MaxValue, double.MinValue);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t科学计数法,E-308就是10的-308次方,E+38就是10的308次方\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("decimal类型 占用字节: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", sizeof(decimal));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("decimal类型 数值范围: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}  {1}\n", decimal.MaxValue, decimal.MinValue);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=================================================================");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
