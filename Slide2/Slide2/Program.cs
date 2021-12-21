using System;

namespace Slide2
{
    class Program
    {

        private static String name { set; get; }



    }

    class Excersive
    {
        public static String formatString(String t)
        {
           
            t= t.Trim();
            while(t.IndexOf("  " )!= -1){
                t= t.Replace("  ", " ");
            }
            // viet hoa chu cai dau moi tu
            char[] array = t.ToCharArray();
            String r = "";
            array[0] = array[0].ToString().ToUpper().ToCharArray()[0];
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i]==' ')
                {
                    String d = array[i+1].ToString();
                    d = d.ToUpper();
                    array[i+1] = d.ToCharArray()[0];
                }
                r += array[i];
            }
           
            return r;
        }

        static void Main(string[] args)
        {
            String t = "       le lo anh           giang      fchgb    ";
            
            Console.WriteLine(formatString(t));
        }
    }
}
