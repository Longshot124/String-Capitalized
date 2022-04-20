using System;
using System.Globalization;
using System.Linq;

namespace String_Capitalized
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string text = "bU tasKI metHodla yAzmAliSiz";
            Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text));

            //var result = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
            //Console.WriteLine(result);


        }
    }
}
