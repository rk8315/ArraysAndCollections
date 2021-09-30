using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayIntro();
            //MultiDimensionalArrays();
            NestedForLoopsAnd2DArrays();
        }
        
        public static void ArrayIntro()
        {
            // create an array with 5 of your friends
            // create a foreach loop which greets all of them

            string[] friends = { "Larry", "Moe", "Curly", "bobbert", "roberto" };
            foreach (string name in friends)
            {
                Console.WriteLine("Hello, {0}", name);
            }
            Console.ReadKey();




            /*
            int[] nums = new int[10];

            for(int i =0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("element{0} = {1}", j, nums[j]);
            }

            int counter = 0;

            foreach(int k in nums)
            {
                Console.WriteLine("element{0} = {1}", counter, nums[k]);
                counter++;
            }

            Console.ReadKey();
            */


            /*
            //creating new array with name "grades". Define how many values will be in array.
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 7;
            grades[4] = 10;

            Console.WriteLine("grades at index 0: {0}", grades[0]);
            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0: {0}", grades[0]);

            // another way to initialize an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            //third way to initialize an array
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);

            Console.Read();
            */
        }
        public static void MultiDimensionalArrays()
        {
            // declare 2d array
            string[,] matrix;

            // declare 3d array
            int[,,] threeD;

            //two dimensional array
            int[,] array2D = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            Console.WriteLine("Central value is {0}", array2D[1, 1]);
            Console.WriteLine("Trying to access the 7. Result: {0}", array2D[2, 0]);
            Console.ReadKey();

            // three dimensional array
            string[,,] array3D = new string[,,]
            { //depth
                { //height
                    {"000", "001"}, //length
                    {"010", "011"}
                },
                {
                    {"100", "101"},
                    {"110", "111"}
                }
            };
            Console.WriteLine("First value is {0}", array3D[0, 0, 0]);
            Console.WriteLine("Last value is {0}", array3D[1, 1, 1]);
            Console.ReadKey();
        }
        public static void NestedForLoopsAnd2DArrays()
        {
            // reason for using nested for loops is due to security that prevents us from
            // modifying data within a foreach loop. In a nested for loop, we are able to 
            // change the values within the array.
            int[,] matrix =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };


            Console.WriteLine("This is our 2d array printed using nested for loop");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();

            Console.WriteLine("This will print out the diagnal values of matrix using nested for loop");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();

        }
    }
}
