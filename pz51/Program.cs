using System;

namespace pz51
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, r, y, m;

            //// 1 задание
            int k;
            for (k = 0; k <= 80; k += 4)
            {
                Console.WriteLine(k);
            }
            ///2 задание Вводим  число 3 и полчим ответ
            string[] b = { "/", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", };
            int c = Convert.ToInt32(Console.ReadLine());
            int g = c + 7;
            for (int d = c; c < g; c += 1)
            {
                Console.Write(b[c]);
            }
            Console.ReadLine();
            /// 3 задание 
            for (m = 0; m <= 4; m++)
            {
                for (int o = 0; o <= 2; o++) Console.Write("##");
                Console.WriteLine("");
            }
            /// 4 задание
            for (i = 0; i <= 100; i++)
            {
                if (i == 0) continue;
                if ((i % 5) != 0) continue;
                Console.WriteLine(i + " ");
            }
            /// 5 задание
            y = 1;
            r = 40;
            for (y = 1, r = 40; r - 1 > 15; y++, r--) ;
            Console.WriteLine("y и r равны :" + y + "и " + r);

        }
    }
}
