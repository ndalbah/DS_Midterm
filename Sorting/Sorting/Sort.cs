using System;
namespace Sorting
{
	public class Sort
    {
        public static void FirstIteration(int[] array)
		{
            int k = array.Length / 2;

            while (!(k == 1))
            {
                for (int i = 0; i < array.Length - k; i++)
                {
                    if (array[i + k] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[i + k];
                        array[i + k] = temp;
                    }
                }

                k = k / 2;
                for (int i = 0; i < array.Length - k; i++)
                {
                    if (array[i + k] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[i + k];
                        array[i + k] = temp;
                    }
                }

                k = k / 2;
                for (int i = 0; i < array.Length - k; i++)
                {
                    if (array[i + k] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[i + k];
                        array[i + k] = temp;
                    }
                }
            }


        }

        public static void Bubble_Sort(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void Display(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                {
                    Console.Write(" , ");
                }
            }
        }
    }
}

