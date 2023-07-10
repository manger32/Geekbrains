using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            void PrintMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); ++i)
                {
                    for (int j = 0; j < matrix.GetLength(1); ++j)
                        Console.Write(matrix[i, j] + " ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            int[,] SpiralMatrix(int Dim_quadratic)
            {
                int[,] Matrix_Q = new int[Dim_quadratic, Dim_quadratic];
                int ElementCounter = 1;
                int VerticI = 0;
                int HorizJ = 0;
                bool NowHorizontal = true;
                bool Backwards = false;
                bool NowVertical = false;
                bool Upwards = false;
                for (int i = 0; i < (Dim_quadratic + 1) / 2; ++i)
                {
                    for (int j = 0; j < 4 * (Dim_quadratic - i) - (3 + i); ++j)
                    {
                        Matrix_Q[VerticI, HorizJ] = ElementCounter++;
                        Console.WriteLine(Matrix_Q[VerticI, HorizJ] + " ");
                        if (NowHorizontal)
                            if (Backwards)
                                HorizJ--;
                            else
                                HorizJ++;
                        if (NowVertical)
                            if (Upwards)
                                VerticI--;
                            else
                                VerticI++;
                        if (HorizJ == i && NowHorizontal)
                        {
                            NowVertical = true;
                            NowHorizontal = false;
                            if (Backwards)
                                Backwards = false;
                            else
                                Backwards = true;
                        }
                        if (VerticI == i && NowVertical)
                        {
                            NowVertical = false;
                            NowHorizontal = true;
                            if (Upwards)
                                Upwards = false;
                            else
                                Upwards = true;
                        }
                        if (HorizJ == Dim_quadratic - i - 1 && NowHorizontal)
                        {
                            NowVertical = true;
                            NowHorizontal = false;
                            if (!Backwards)
                                Backwards = true;
                            else
                                Backwards = false;
                        }
                        if (VerticI == Dim_quadratic - i - 1 && NowVertical)
                        {
                            NowVertical = false;
                            NowHorizontal = true;
                            if (!Upwards)
                                Upwards = true;
                            else
                                Upwards = false;
                        }
                    }
                }
                return Matrix_Q;
            }

            int[,] uLeMatrix = SpiralMatrix(4);
            PrintMatrix(uLeMatrix);
        }
    }
}
