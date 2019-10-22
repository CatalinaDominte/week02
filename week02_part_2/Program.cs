using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week02_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Sum the values of an array and display it to console.
            //ex1();

            //2.Calculate the average value of array elements.
            //ex2();

            //3.Find the index of an element in an array.
            //ex3();

            //4.Remove a specific element from an array
            //ex4();

            //5.Insert an element into an array at a specified position
            //ex5();

            //6.Find the maximum and minimum value of an array.
            //ex6();

            //7.Find common elements between two arrays of integers.
            //ex7();

            //8.Copy elements from an array into another.
            //ex8();

            //Check if a word is a palindrome
            //Palindrome();

            //Implement an algorithm to determine if a string has all unique characters.
            //uniqueCharacters();

            //Given a string s consists of upper/lower-case alphabets and empty space characters ' '
            //lastWord();

            //Homework 4.1- Find common elements between two arrays of integers.
            //commonElements();

            //8.Copy elements from an array into another.
            //ex8();

            Console.ReadLine();
        }

        private static void ex8()
        {
            int[] arr1 = new int[] { 1, 6, 2, 9, 3, 4, 10 };
            int[] arr2 = new int[] { 2, 5, 11, 9, 1 };

            int[] arr3 = new int[] { 10, 3, 6 };//elementele din prima lista pe care doresc sa le copii in a II-a

            int[] newArr = new int[arr2.Length + arr3.Length];

            for (int i = 0; i < arr2.Length; i++)
            {
                newArr[i] = arr2[i];


            }

            for (int j = 0; j < arr3.Length; j++)
            {
                newArr[arr2.Length + j] = arr3[j];
            }
            Console.WriteLine("Lista cu elementele copiate: ");


            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
        }

        private static void commonElements()
        {
            int[] arr1 = new int[] { 1, 6, 2, 9, 3, 4, 10 };
            int[] arr2 = new int[] { 2, 5, 11, 9, 1 };

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine(arr1[i]);
                    }
                }
            }
        }

        private static void lastWord()
        {
            Console.WriteLine("Introduceti un text: ");
            string input = Console.ReadLine();

            int j = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == ' ')
                {
                    break;
                }
                j++;
            }
            if (j != input.Length)
            {
                Console.WriteLine(j);
            }
            else
            {
                Console.WriteLine("0");
            }
        }

        private static void uniqueCharacters()
        {
            Console.WriteLine("Introduceti un cuvat: ");
            string input = Console.ReadLine();
            char[] unic = input.ToArray();
            Array.Sort(unic);

            int x = 0;
            for (int i = 0; i < unic.Length - 1; i++)
            {
                if (unic[i] == unic[i + 1])
                {
                    x++;
                }
            }

            if (x == 0)
            {
                Console.WriteLine("Cuvantul are caractere unice!");
            }
            else
            {
                Console.WriteLine("Cuvantul nu are caractere unice!");
            }
        }



        private static void Palindrome()
        {
            Console.WriteLine("Introduceti un cuvat: "); //Ex: rotitor
            string palindrome = Console.ReadLine();
            int x = 0;

            for (int i = 0; i < palindrome.Length; i++)
            {
                if (palindrome[i] == palindrome[palindrome.Length - i - 1])
                {
                    x++;

                }

            }
            if (x == palindrome.Length)
            {
                Console.WriteLine("Cuvantul este palindrom!");
            }
            else
            {
                Console.WriteLine("Cuvantul nu este palindrom!");
            }



        }

        private static void ex7()
        {
            int[] arr = new int[] { 2, 6, 9, 8, 7 };
            int[] arrNew = new int[] { 7, 3, 8, 1 };
            int count = 0;
            Console.WriteLine("Numerele comune sunt: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arrNew.Length; j++)
                {
                    if (arr[i] == arrNew[j])
                    {
                        count++;
                        Console.WriteLine(arr[i]);
                    }

                }

            }

            Console.WriteLine("Total numere comune: ");
            Console.WriteLine(count);

        }

        private static void ex6()
        {
            int[] arr = new int[] { 2, 8, 9, 8, 7 };


            for (int j = 0; j < arr.Length; j++)
            {

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int x = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = x;
                    }
                }

            }

            Console.WriteLine("Valoarea minima este: ");
            Console.WriteLine(arr[0]);


            Console.WriteLine("Valoarea maxima este: ");

            Console.WriteLine(arr[arr.Length - 1]);

        }

        private static void ex5()
        {
            int[] arr = new int[] { 2, 8, 9, 8, 7 };
            int[] newArr = new int[arr.Length + 1];
            Console.WriteLine("Introduceti numarul pe care doriti sa il adaugati: ");
            int nrAdaugat = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti indexul: ");
            int nrIndex = int.Parse(Console.ReadLine());

            for (int i = 0; i <= nrIndex; i++)
            {
                newArr[i] = arr[i];
                newArr[nrIndex] = nrAdaugat;

            }

            for (int i = nrIndex + 1; i < newArr.Length; i++)
            {
                newArr[i] = arr[i - 1];
            }
            Console.WriteLine("Noua lista: ");
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
        }

        private static void ex4()
        {
            int[] arr = new int[] { 2, 8, 9, 8, 7 };
            Console.WriteLine("Introduceti numarul pe care doriti sa il stergeti: ");
            int NrDelete = int.Parse(Console.ReadLine());
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == NrDelete)
                {
                    continue;
                }
                j++;
            }
            Console.WriteLine("Noua lista: ");
            int k = 0;
            int[] newArr = new int[j];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == NrDelete)
                {
                    continue;
                }
                newArr[k] = arr[i];
                Console.WriteLine(newArr[k]);
            }
        }

        private static void ex3()
        {
            int[] numbers = new int[] { 2, 8, 9, 8, 7 };
            int x = 8;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (x == numbers[i])
                {
                    Console.WriteLine(i);
                }

            }
        }
        private static void ex2()
        {
            int[] numbers = new int[] { 2, 5, 7, 9, 4 };
            int sum = 0;
            int i = 0;
            while (i < numbers.Length)
            {
                sum = sum + numbers[i];
                i++;

            }

            int avr = sum / numbers.Length;

            Console.WriteLine(avr);
        }
        private static void ex1()
        {
            int[] numbers = new int[] { 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];

            }
            Console.WriteLine(sum);
        }

    }
}
