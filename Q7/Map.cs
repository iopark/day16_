using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    public struct Map
    {
        static int[] Generate()
        {
            int[] map_deriv = new int[25];
            //int[] temp = new int[25];

            for (int i = 0; i < 25;)
            {
                Random random = new Random();
                int newGen = random.Next(1, 26);

                //Console.WriteLine(newGen);

                bool check = map_deriv.Contains(newGen);

                if (!check)
                {
                    map_deriv[i] = newGen;
                    i++;
                }
                else
                {
                    //Console.WriteLine("false");
                    continue;
                }


            }
            return map_deriv;
        }

        static int[,] IntoMatrix(int[] map)
        {
            int count = 0;
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = map[count];
                }
            }
            return matrix;
        }
    }
}
