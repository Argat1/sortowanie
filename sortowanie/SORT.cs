using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie
{
    public class SORT
    {
        public static int[] Sortoj(int[] tab)
        {
            for (int i = 0; i < tab.Length - 1; i++)
            {
                for (int j = 0; j < tab.Length - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int x = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = x;
                    }
                }
            }

            return tab;
            
        }

        public static void wypisz(int[] tab)
        {
            int y = 0;
            while (y < tab.Length)
            {
                Console.Write(tab[y] + ",");
                y++;
            }
        }

        public static int[] Losuj(int a)
        {
            int[] table = new int[a];
            int i = 0;
            Random r = new Random();
            while (i < table.Length)
            {
                table[i] = r.Next(0, 1001);
                Console.Write(table[i] + ",");
                i++;

            }
            Console.WriteLine();
            return table;
        }
    }
}
