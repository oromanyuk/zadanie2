using System;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("№1");
            string s = Console.ReadLine();
            int g = 0;
            int it = 789;
            for(int i = 0; i <= s.Length; i++)
            {
                if (s[i] == 'f')
                {
                    g++;
                    if (g == 2) it = i;
                }
            }
            if (g == 0) Console.WriteLine("-2");
            else if (g == 1) Console.WriteLine("-1");
            else Console.WriteLine(it);*/


            Console.WriteLine("№2");
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();

            string str2 = "";
            for(int i =0; i< str.Length;i++)
            {
                if (str[i] == 'а') str2 = str2 + 'a';
                if (str[i] == 'б') str2 = str2 + 'b';
                if (str[i] == 'в') str2 = str2 + 'v';
                if (str[i] == 'г') str2 = str2 + 'g';
                if (str[i] == 'д') str2 = str2 + 'd';
                if (str[i] == 'е') str2 = str2 + 'e';
                if (str[i] == 'ё') str2 = str2 + "yo";
                if (str[i] == 'ж') str2 = str2 + "zh";
                if (str[i] == 'з') str2 = str2 + 'z';
                if (str[i] == 'и') str2 = str2 + 'i';
                if (str[i] == 'й') str2 = str2 + 'j';
                if (str[i] == 'к') str2 = str2 + 'k';
                if (str[i] == 'л') str2 = str2 + 'l';
                if (str[i] == 'м') str2 = str2 + 'm';
                if (str[i] == 'н') str2 = str2 + 'n';
                if (str[i] == 'о') str2 = str2 + 'o';
                if (str[i] == 'п') str2 = str2 + 'p';
                if (str[i] == 'р') str2 = str2 + 'r';
                if (str[i] == 'с') str2 = str2 + 's';
                if (str[i] == 'т') str2 = str2 + 't';
                if (str[i] == 'у') str2 = str2 + 'u';
                if (str[i] == 'ф') str2 = str2 + "f";
                if (str[i] == 'х') str2 = str2 + "h";
                if (str[i] == 'ц') str2 = str2 + "c";
                if (str[i] == 'ч') str2 = str2 + "ch";
                if (str[i] == 'ш') str2 = str2 + "sh";
                if (str[i] == 'щ') str2 = str2 + "shh";
                if (str[i] == 'ь') str2 = str2 + "'";
                if (str[i] == 'ы') str2 = str2 + "y'";
                if (str[i] == 'ъ') str2 = str2 + '"';
                if (str[i] == 'э') str2 = str2 + "e'";
                if (str[i] == 'ю') str2 = str2 + "yu";
                if (str[i] == 'я') str2 = str2 + "ya";
            }
            Console.Write("Транслит: " + str2);
            /*int g2 = 0;
            Console.WriteLine("№3");
            string str3 = "";
            for(int i = 0; i <=str.Length; i++)
            {
                if (str[i] == 'h' || g2 > 0) str3 = str3 + 'H';
                else str3 = str3 + str[i];
                g2++;
            }*/
        }
    }
}
