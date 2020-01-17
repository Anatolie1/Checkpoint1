using System;

namespace checkpoint1
{
    class Program
    {
        static int[] Table()
        {
            Console.WriteLine("Give the size of your array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] table = new int[size];
            for (int i = 0; i < size; i ++)
            {
                Console.WriteLine("Give the values : ");
                table[i] = Convert.ToInt32(Console.ReadLine());
            }
            return table;
        }
        static int SommeTable(int[] array)
        {      
            int summ = 0;
            foreach (int i in array)
            {
                summ = summ + i;
            }
            return summ;
        }
        static double MeanTable(int summ, int sizeArray)
        {
            double mean = (double)summ / sizeArray;
            return mean;
        }
        static void Main(string[] args)
        {
            int[] array = Table();
            int sizeArray = array.Length;
            int summ = SommeTable(array);
            double mean = MeanTable(summ, sizeArray);
            Console.WriteLine("The summ of the array values are :  {0}", summ);
            Console.WriteLine("The mean of the array values are :  {0}", mean);
            
            int i, min;
            while (sizeArray > 0)
            {
                for (i = 0; i < sizeArray - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        min = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = min;
                    }
                }
                sizeArray = sizeArray - 1;
                Console.Write(array[i]+ "    ");
            }
        }
    }
}
