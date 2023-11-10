using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] matrix=new int[3][];
            //matrix[0] = new int[4] {1,2,3,4};
            //matrix[1] = new int[2] { 10, 20};
                  ////matrix[1] = new int[3] { 10,20,0 };
            //matrix[2] = new int[3] { 2,4,6 };

            //int element = matrix[0][1];
            //matrix[1][2] = 15;


            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {
            //        Console.Write(matrix[i][j] + " ");

            //    }

            //    Console.WriteLine(); 
            //}



            //Console.ReadKey();



            //TASK 4:ADVANCED CONCEPTS


            object[][] objmatrix = new object[2][];
            objmatrix[0] = new dynamic[] { 55, "Ravula Sonali", 1.56 };
            objmatrix[1] = new dynamic[] { true, 's', DateTime.Now };

            for (int i = 0; i < objmatrix.Length; i++)
            {
                for (int j = 0; j < objmatrix[i].Length; j++)
                {
                    Console.WriteLine($"type: {objmatrix[i][j].GetType()},value: {objmatrix[i][j]}");
                }
            }

            Console.ReadKey();

        }
    }
}
