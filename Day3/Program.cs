using System.Runtime.Intrinsics.Arm;
using System.Text;
namespace Day3
{
    //public void print()
    //{

    //} 
    internal class Program
    {

        // class member method [static modifier]
        // object member [no static]
        #region Methods 

        //method overloading 
        //public static void Swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y; y= temp;
        //    Console.WriteLine(x);
        //    Console.WriteLine(y);

        //}
        //public static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y; y= temp;
        //}


        //public static int SumArray(int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        //public static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        //public static int SumArray(int[] arr)
        //{
        //    int sum = 0;
        //           //2refernce the same object      
        //    arr = new int[] { 100, 200, 300 };
        //    arr[0] = 1000;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        //public static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr = new int[] { 100, 200, 300 };
        //    arr[0] = 1000;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}


        //public static void SumSub(int x, int y, ref int sum , ref int sub)
        //{
        //    //sum = x + y;
        //    //sum = x + y;
        //    //sub = x - y;

        //    //return new DTO() { sum = sum, sub = sub };

        //}

        //public static void SumArray(out int sum, int x = 10, params int[] arr) //requiredparameters , default , params
        //{
        //    sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //}

        //public static void Concat<T>(params ReadOnlySpan<T> items)
        //{
        //    for(int i = 0;i < items.Length; i++)
        //    {
        //        Console.WriteLine(items[i]);
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Functions 

            #region Function Prototype
            ////Test test = new Test();
            //////test.PrintShape();
            ////Test.PrintShape(10, "*"); //passing by order 
            //Test.PrintShape(Shape:"*", count: 10); //passing by name
            //Test.PrintShape("*"); //passing by order 

            #endregion

            #region Function Parameters [Value Type]

            #region Passing by Value 
            //int a = 10, b = 20;
            //Swap(a, b);
            //Console.WriteLine("---------------");
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #region Passing By Reference 
            //int a = 10, b = 20;
            //Swap(ref a, ref b);

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #endregion

            #region Function Parameters [Reference Type]

            #region Example 01 

            #region Passing By Value
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int result = SumArray(numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);
            #endregion

            #region Passing by Reference 
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int result = SumArray(ref numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);
            #endregion

            #endregion

            #region Example 02 

            #region Passing By Value
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int result = SumArray(numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);
            #endregion

            #region Passing by Reference 
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int result = SumArray(ref numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);
            #endregion

            #endregion

            #endregion

            #region Function Parameters [Passing By out]
            //int a = 10; int b = 20;
            //int sum = 0 ; int sub =0;
            //SumSub(a, b, ref sum, ref sub);
            //Console.WriteLine(sum);
            //Console.WriteLine(sub);

            //bool isParsed = int.TryParse()
            #endregion

            #region Function Parameters [Params]

            #region Before C# 13
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int sum;
            //SumArray(out sum,1,2,3,4); //rest operator in js
            //Console.WriteLine(sum);
            #endregion

            #region After C# 13  .net 9

            //Concat<object>("Hello", 123, 10.5m,DateTime.Now);

            //string message = string.Format("Hello {0}, your balance is {1}", "Fatma", 1000);

            #endregion

            #endregion

            #endregion

            #region Arrays 

            #region 1D Array 

            #region Creation
            //string[] names; //reference == nulll //4byte

            //names = new string[5];  //5 places in heap , default value of type, null   //4byte , null
            //names[0] = "Nada";  //null ====>>>> refernce =====>>> nada (array of chars)

            //int[] numbers = { 1, 2, 3, 4 };
            //numbers[4] = 5; //index out of range

            //Int32 num = 10;

            //Array arr1 = new int[3];
            #endregion

            #region Initialization and Access

            //length , Rank 

            //int[] numbers = { 1, 2, 3, 4, 5, 6 }; //6
            //Console.WriteLine(numbers.Length); //6
            //Console.WriteLine(numbers.Rank); //1
            #endregion

            #endregion

            #region 2D Array [Rectangular]

            #region Creation
            //int[,] arr1 = new int[3, 4]; //12 field *4 == 48 byte //default values = 0

            //int[,,] arr2 = new int[2, 3,4] { {1,2,3 },
            //                              {4,5,6 } };
            #endregion

            #region Access

            ////Length, Rank 

            //Console.WriteLine(arr2.Length); //6
            //Console.WriteLine(arr2.Rank); //2

            //for (int i = 0; i < arr2.GetLength(0); i++) {
            //    for (int j = 0; j < arr2.GetLength(1); j++) {
            //        Console.Write(arr2[i,j]+ " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #endregion

            #region Jagged Array  
            //int[][] jaggedArray = new int[4][];

            //jaggedArray[0] = new int[2];
            //jaggedArray[1] = new int[3];
            ////jaggedArray[2] = new int[4];

            //int[][,] jaggedArray = new int[][,]
            //{
            //    new int[2],  // 0 0
            //    [4,5,6 ],    // 4 5 6
            //    new int[2,3]
            //};

            //3  2    3     4


            //1dimension array of arrays 

            //Console.WriteLine(jaggedArray.Rank);
            //Console.WriteLine(jaggedArray[0].Length);
            //Console.WriteLine(jaggedArray[1].Length);
            //Console.WriteLine(jaggedArray[2].Length);
            #endregion

            #endregion

            #region Array Methods
            //int[] numbers1 = { 1, 5, 8, 3, 9 };
            //int[] numbers2 = { 10,20,30 };

            ////Array.Sort(numbers1);
            ////Array.Reverse(numbers1);
            ////Array.Clear(numbers1);
            ////Array.Clear(numbers1,0,3);
            ////Array.Resize(ref numbers1,2);
            ////Array.Copy(numbers2, numbers1,2);
            ////Array.ConstrainedCopy(numbers2,1,numbers1, 3,2);

            //foreach (int i in numbers1) {
            //    Console.WriteLine(i);
            //}

            #endregion

            #region string 
            //string name01;
            //name01 = "Fatma";

            //string name02 = "Amr";

            ////Console.WriteLine(name01.GetHashCode()); 
            ////Console.WriteLine(name02.GetHashCode());

            //name02 = name01;

            //Console.WriteLine(name01.GetHashCode());
            //Console.WriteLine(name02.GetHashCode());
            //Console.WriteLine(name01);
            //Console.WriteLine(name02);
            //Console.WriteLine("-------------------------");
            //name01 = "Ahmed";

            //Console.WriteLine(name01.GetHashCode());
            //Console.WriteLine(name02.GetHashCode());
            //Console.WriteLine(name01);
            //Console.WriteLine(name02);


            //string message = "Hello";
            //Console.WriteLine(message.GetHashCode());
            ////message += "World";
            ////Console.WriteLine(message.GetHashCode());


            //string message02 = "Hello";
            //Console.WriteLine(message02.GetHashCode());

            //string pool  (memory cache of string literals)
            //clr check 
            #endregion

            #region string Methods
            //string message = "Hello ITI";
            //Console.WriteLine(message.Length);
            //Console.WriteLine(message.ToUpper());
            //Console.WriteLine(message.ToLower());
            //Console.WriteLine(message.Trim());
            //Console.WriteLine(message.TrimStart());
            //Console.WriteLine(message.TrimEnd());
            //Console.WriteLine(message.Substring(3));//from index 3 
            //Console.WriteLine(message.Substring(3,2));//from index 3  2 chars
            //Console.WriteLine(message.Replace("e", "M"));//from index 3  2 chars
            //Console.WriteLine(message.Contains("e"));//from index 3  2 chars
            //Console.WriteLine(message.IndexOf("ITI"));
            #endregion

            #region stringbuilder 
            //StringBuilder sb = new StringBuilder("Hello");
            //Console.WriteLine(sb.GetHashCode());
            //sb.Append(" World");

            //Console.WriteLine(sb.GetHashCode());
            //Console.WriteLine(sb);
            #endregion

            #region stringbuilder Methods
            //StringBuilder sb = new StringBuilder("Hello");
            ////sb.AppendLine("World");
            ////sb.Append("Fatma");
            ////sb.AppendFormat("You age is {0}", 25);
            //sb.AppendJoin("_","Fatma", "Alaa", "ITI");
            //sb.Replace("ITI", "Alghonaimy");
            ////sb.Clear();
            //sb.Remove(1,5);
            
            //Console.WriteLine(sb);

            #endregion
        }
    }
}
