using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wrox.chaptor5;

namespace Wrox.chaptor6
{
    class DefineArray
    {
        public int[,] twodim = {
            {1,2,3 },
            {4,5,6 },
            {7,8,9 }
        };

        public int[][] jagged = new int[3][];

        public DefineArray()
        {
            jagged[0] = new int[2] { 1, 2 };
            jagged[1] = new int[3] { 3,6,4};
            jagged[2] = new int[2] { 0,9};

        }

        public void Show(int[][] jagged)
        {
            for(int row = 0;row<jagged.Length;row++)
            {
                for(int element = 0;element<jagged[row].Length;element++)
                {
                    Console.Write("jagged[{0}][{1}] = {2}  ", row, element, jagged[row][element]);
                }
                Console.WriteLine();
            }
        }

        public Array UseArray()
        {
            Array array = Array.CreateInstance(typeof(int), 5);
            for(int i = 0; i < 5; i++)
            {
                array.SetValue(33, i);
            }
            for(int i = 0; i < 5;i++)
            {
                int value = (int)array.GetValue(i);
                //Console.Write("{0}  ", value);
            }

            return array;
        }

        public void GetArray()
        {
            int[] array = (int[])UseArray();
            foreach(int value in array)
            {
                Console.Write("{0}  ", value);
            }
        }

        public void SetArray()
        {
            int[] length = { 2, 3 };
            int[] lowerBound = { 1, 10 };
            Array array = Array.CreateInstance(typeof(int), length, lowerBound);
            
            array.SetValue(2, 1, 10);
            array.SetValue(3, 1, 11);
            array.SetValue(4, 1, 12);
            array.SetValue(7, 2, 10);
            array.SetValue(7, 2, 11);
            array.SetValue(7, 2, 12);

            int[,] array1 = (int[,])array;

            for (int i = 1; i < 3;i++)
            {
                for(int j = 10;j < 13;j++)
                {
                    Console.Write("{0} ", array1[i, j]);
                }
                Console.WriteLine();
            }

        }

        public void CloneAarray()
        {
            int[] arr1 = { 1, 2 };
            int[] arr2 = (int[])arr1.Clone();
            
            foreach(int value in arr2)
            {
                Console.WriteLine(value);
            }

            arr2[1] = 10;

            foreach (int value in arr1)
            {
                Console.WriteLine(value);
            }

            foreach (int value in arr2)
            {
                Console.WriteLine(value);
            }

        }

        public void CloneArray2()
        {
            Account[] A1 =
            {
                new Account("ICBC",21M),
                new Account("ABC",32m)
            };

            Account[] A2 = (Account[])A1.Clone();

            foreach(Account a in A1)
            {
                Console.Write("{0} ", a.ToString());
            }
            Console.WriteLine();
            foreach (Account a in A2)
            {
                Console.Write("{0} ", a.ToString());
            }

            A2[1].Balance = 100m;

            Console.WriteLine();
            foreach (Account a in A1)
            {
                Console.Write("{0} ", a.ToString());
            }
            Console.WriteLine();
            foreach (Account a in A2)
            {
                Console.Write("{0} ", a.ToString());
            }
        }

        public void SortArray()
        {
            string[] names = { "jane", "black", "Jone", "ada" };
            Array.Sort(names);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public void SortArray1()
        {
            Person[] persons = {
                new Person{FirstName = "black",LastName = "green"},
                new Person{FirstName = "jone",LastName = "ada"}
            };

            Array.Sort(persons);
            foreach(Person p in persons)
            {
                Console.WriteLine(p.ToString());
            }
        }








    }
}
