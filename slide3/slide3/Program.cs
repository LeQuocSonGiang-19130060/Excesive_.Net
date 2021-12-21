using System;

namespace slide3
{
    class Program
    {

        delegate int myDelegate(String n);

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            myDelegate myd = new myDelegate(convert);
            int value = myd("10");
            Console.WriteLine(value);
        }

      static  int convert(String s)
        {
            int vl =0;
            Int32.TryParse(s, out vl);
            return vl;
        }

    }
}
