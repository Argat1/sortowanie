namespace sortowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] tab = Losuj();
        }

        
        public static int[] Losuj()
        {
            int[] table = new int[100];
            int i = 0;
            Random r = new Random();
            while (i < table.Length)
            {
                table[i] = r.Next(0, 1001);
                Console.WriteLine(table[i]);
                i++;
                 
            }
            return table;
        }
    }
}
