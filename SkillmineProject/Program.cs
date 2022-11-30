using System;

namespace SkillmineProject
{
    class Program
    {
        static void Main(string[] args)
        {
            byte mybyte; //1 byte, 127 to -128.
            mybyte = 45;

            sbyte mybyte1 = -23; // 1 bit for sign and 7 bit for value.

            short mys = 456; //2 byte //32568 to -32567

            int myint = 34637783; //4 byte 2^31 to 2^-31

            long mylong = 53656476; //8 byte 2^64 to 2^-64

            double mydouble = 45.67; //8 byte
            float myfloat = 75.73f; // 4 byte

            //char ch = 'd';
            Console.WriteLine(mybyte);
            Console.WriteLine(mybyte1);
            Console.WriteLine(mys);
            Console.WriteLine(myint);
            Console.WriteLine(mylong);
            Console.WriteLine(mydouble);
            Console.WriteLine(myfloat);
        }
    }
}
