//using Common;
using Day4.Encapsulation;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Library
            //Class1 class1 = new Class1();
            #endregion

            #region Access Modifiers [Private - Internal - Public]
            //private int x;
            //internal int y;
            //public int z;
            //TypeA typeA = new TypeA();
            //typeA.x = 1;
            //typeA.y = 1; typeA.z = 1;

            #endregion

            #region Struct 
            #region Example 01
            //Point p1; //refernce 
            ////clr 8 byte in stack uniintialized

            //p1 = new Point(); //constuctor selection ??????   0   0
            ////p1 =  new Point(4, 3); //syntax sugar

            ////Console.WriteLine(p1.x);
            ////Console.WriteLine(p1.y);

            //Point p2 = new Point(5, 6);      //5 6 
            //p1 = p2;    ///    5 6

            //p1.x = 10000;   ///10000 6        5 6

            //Console.WriteLine(p1.x);  //10000
            //Console.WriteLine(p1.y); //6
            //Console.WriteLine(p2.x); // 5
            //Console.WriteLine(p2.y);  //6
            #endregion

            #endregion

            #region Encapsulation

            #region Example 01 
            //Employee emp = new Employee();
            //emp.id = 1;
            //Console.WriteLine(emp.id);

            //Console.WriteLine( emp.GetID());
            //emp.SetID(5);
            //emp.Id = 5;
            //emp.Name = null;
            //Console.WriteLine(emp.Name);

            //Employee emp2 = new Employee(123, "Fatmaaaaaaa");
            //Console.WriteLine(emp2.Name);
            //emp2.Name = "";
            //Console.WriteLine(emp2.Name);
            #endregion

            #region Example 02
            //PhoneNotebook note01 = new(new string[] { "Ali", "ahmed" }, new int[] { 123, 456 }, 2);

            //Console.WriteLine($"Name : {note01.Names?[0]}, Number: {note01.Numbers?[0]}");
            //Console.WriteLine($"Name : {note01.Names?[1]}, Number: {note01.Numbers?[1]}");

            //PhoneNotebook note02 = new(3);
            //note02.AddPerson(0, "Ali", 123);
            //note02.AddPerson(1, "Ahmed", 456);
            //note02.AddPerson(2, "Ali", 123);
            //note02.AddPerson(3, "Ali", 123);

            //note02.SetNumber("Ahmed", 0000);

            //Console.WriteLine(note02["Ahmed"]); //get number
            //Console.WriteLine(note02[5]); //get name
            //note02["Ahmed"] = 5; //set number
            //note02[5] = "ahemd"; //set name

            //Console.WriteLine($"Name : {note02.Names?[1]}, Number: {note02.Numbers?[1]}");
            ////Console.WriteLine($"Name : {note02.Names?[1]}, Number: {note02.Numbers?[1]}");


            //note02["Ahmed"] = 9999;
            ////Console.WriteLine(note02["Ahmed"]);
            ////Console.WriteLine($"Name : {note02.Names?[1]}, Number: {note02.Numbers?[1]}");

            //note02[9999] = "Nader";
            //Console.WriteLine($"Name : {note02.Names?[1]}, Number: {note02.Numbers?[1]}");
            //Console.WriteLine(note02[0]);


            //Ienumerable -- get enumerator -- move next , get current , disppse
            //PhoneNotebook[] notebooks = new PhoneNotebook[5];
            //Array notebooks2 = new PhoneNotebook[5];

            //foreach (var i in note02)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < note02.Size; i++)
            //{
            //    Console.WriteLine(note02[i]);
            //}

            #endregion

            #endregion

            #region Objects 
            //universal base Object 
            #region ToString()
            //value type
            //refernce type
            //Point point = new Point();
            //Console.WriteLine(point); //fuly qualified name 
            //Console.WriteLine(15); //fuly qualified name 
            //Console.WriteLine(false); //fuly qualified name 

            //int[] ints = { 1, 2, 3 };

            //Console.WriteLine(ints); 
            //static and dynamic binding
            //object num = new Struct32(15);  //to string 
            //Console.WriteLine(num);
            #endregion

            #region Equals()

            //shllow equivalence 

            //int x = 0; int y = 0;

            //Console.WriteLine(x.Equals(y));

            ////refernce 
            //int[] arr = { 12, 13, 14, 15 };
            //int[] arr2 = { 12, 13, 14, 15 };

            //Console.WriteLine(arr.Equals(arr2)); //refernce arr refernce arr2


            ////userdefined
            //Point point = new Point();
            //Point point2 = new Point();

            //Console.WriteLine(point.Equals(point2));
            #endregion

            #region GetHashCode()

            //value 

            //int x = 10;
            //Console.WriteLine(x.GetHashCode());

            //Point p = new Point();
            //Console.WriteLine(p.GetHashCode());


            //static dymanic biding
            //object num = 123;  //boxing
            
            //Console.WriteLine(num.GetHashCode());

            #endregion

            #region GetType()

            //Point point = new Point();
            //Console.WriteLine(point.GetType());
            //int x = 15;
            //Console.WriteLine(x.GetType());
            #endregion
            #endregion

            #region Enum

            #region Example 01
            //Employee employee =  new Employee(1, "Ahmed");
            //employee.Gender = (Gender)10; //casting
            //Console.WriteLine(employee.Gender);
            #endregion

            #endregion
        }
    }
}
 