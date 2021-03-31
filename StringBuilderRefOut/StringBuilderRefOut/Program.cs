using System;
using System.Text;

namespace StringBuilderRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Value,Reference - ref,out
            //int a = 5;
            //int b = a; //b=5
            //b = 6;
            //Console.WriteLine($"a={a}");
            //Console.WriteLine($"b={b}");

            //int[] arr = { 1, 2, 3 };
            //int[] arr1 = arr;
            //arr1[0] = 10;

            //Console.WriteLine($"arr[0]={arr[0]}");
            //Console.WriteLine($"arr1[0]={arr1[0]}");

            //int a = 5;
            //ChengeNumber(a);
            //Console.WriteLine($"a={a}");
            //int[] arr = { 1, 2, 3 };
            //ChangeIndex(arr);
            //Console.WriteLine($"arr[0]={arr[0]}");
            #region Ref - in method optional
            //int a=10; //initialize must be
            //ChangeNumberWithRef(ref a);
            //Console.WriteLine($"a={a}");
            #endregion
            #region Out - in method must be assigned
            //int b; //initialize optional
            //ChangeNumberWithOut(out b);
            //Console.WriteLine($"b={b}");
            #endregion
            #endregion

            #region Array,String
            //int[] arr = { 500, 20, 5, 10 };
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //string[] arr = { "Faiq", "Nihad", "Cefer" };
            //string str=String.Join('-', arr);
            //Console.WriteLine(str);
            //Console.WriteLine(arr.Length);
            //Array.Resize(ref arr, arr.Length + 1);
            //arr[arr.Length - 1] = "Heshim";
            //foreach (string item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //string word = "Cefer,Nihad,Nazim";
            //string[] arr = word.Split(',');
            //foreach (string item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (char item in word)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(word.Length);
            //Console.WriteLine(word[0]);
            //word[0] = 'a';
            //string word1 = word;
            //word += " Memmedzade";

            //Console.WriteLine(word);
            //Console.WriteLine(word1);

            #endregion

            // Salam P316 Qrupu - malaS 613P upurQ
            //Console.WriteLine(ReverseWord("Salam P316 Qrupu"));
            //StringBuilder builder = new StringBuilder();
            //builder.Append("A");
            //builder.Append("B");
            //builder.Append("C");
            ////builder.Clear();
            //builder.Insert(1, 'D');
            //builder.Remove(1, 2);
            //Console.WriteLine(builder);

        }

        #region StringBuilder
        static string ReverseWord(string sentences)
        {
            StringBuilder result = new StringBuilder();
            string[] arr = sentences.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr[i].Length - 1; j >= 0; j--)
                {
                    result.Append(arr[i][j]);
                }

                if (arr[i] != arr[arr.Length - 1])
                    result.Append(" ");
            }
            return result.ToString();
        }

        //static string ReverseWord(string sentences)
        //{
        //    string result = "";
        //    string[] arr = sentences.Split(' ');
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = arr[i].Length-1; j >= 0; j--)
        //        {
        //            result+=arr[i][j];
        //        }

        //        if(arr[i]!=arr[arr.Length-1])
        //            result += " ";
        //    }
        //    return result;
        //}
        #endregion

        #region Value,Reference - ref,out
        #region Out
        static void ChangeNumberWithOut(out int a)
        {
            a = 400;
            Console.WriteLine($"method a={a}");
        }
        #endregion
        #region Ref
        static void ChangeNumberWithRef(ref int a)
        {
            a = 300;
            Console.WriteLine($"method a={a}");
        }
        #endregion

        //static void ChangeIndex(int[] arr)
        //{
        //    arr[0] = 200;
        //    Console.WriteLine($"method arr[0]={arr[0]}");
        //}
        //static void ChengeNumber(int n)
        //{
        //    n = 100;
        //    Console.WriteLine($"method n={n}");
        //}
        #endregion
    }
}
