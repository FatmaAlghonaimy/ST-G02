using Day5.Inheritance;
//using Common;
using System.Net.Http.Headers;
using Day5.OperatorOverloading;
namespace Day5
{
    internal class Program
    {
        #region Method Overloading
        //static int Sum(int a, int b)
        //{
        //    return a + b;
        //}
        //static double Sum(double a, double b)
        //{
        //    return a + b;
        //}
        //static double Sum(int a, double b)
        //{
        //    return a + b;
        //}
        //static double Sum(double a, int b)
        //{
        //    return a + b;
        //}
        //static object Sum(object a, object b)
        //{
        //    return (int)a + (int)b;
        //}
        //cost , type mistmatch
        #endregion
        static void Main(string[] args)
        {
            #region Continue Enum
            #region Example 02 TryParse Enum
            //Employee employee = new Employee();
            //employee.Id = 1;
            //employee.Name = "Ali";
            //object? branchValue;

            //bool isParsed;
            ////do
            ////{
            ////    Console.WriteLine("Enter branch");
            ////    isParsed = Enum.TryParse(typeof(Branch), Console.ReadLine(), out branchValue);
            ////} while (branchValue is null || !isParsed);

            ////employee.Branch = (Branch)branchValue;
            ////Console.WriteLine(employee);
            //Branch branch;

            //do
            //{
            //    Console.WriteLine("Enter branch");
            //    isParsed = Enum.TryParse(Console.ReadLine()?? "0", out  branch);
            //} while (!isParsed);

            //employee.Branch = branch;
            //Console.WriteLine(employee);
            #endregion

            #region Example 03 - Permissions

            //Employee employee = new Employee(10, "Ali", Branch.Finance);
            ////employee.Permissions[0] = true;  //read
            ////employee.Permissions[1] = true;   //write

            //employee.Permission = Permission.Read;
            ////employee.Permission = (Permission)3;  //Read, write 

            //employee.Permission = Permission.Read | Permission.Write | Permission.Update;
            //employee.Permission |= Permission.Update; //0011  0100 

            ////and 
            ////deny all permissions excpet write

            //employee.Permission &= Permission.Write;    //0111  & 0010 == 0010   0000


            // // 0010 
            // // 0001 //read
            // // 0000 //read
            //if((employee.Permission & Permission.Delete) == Permission.Delete)
            //{
            //    Console.WriteLine("Has Delete");
            //}
            //else
            //{
            //    employee.Permission |= Permission.Delete;
            //}
            ////xor //toggle

            ////employee.Permission = employee.Permission ^ Permission.Delete; //remove delete incase exists
            //// 1111 
            //// 1000

            //// 0111
            //// 1000
            //// 1111
            //Console.WriteLine(employee);

            #endregion
            #endregion

            #region Class

            #region Example 01 
            //Car car; //reference  //4bytes in stack , null

            //car = new Car(); //default ctor
            //car = new Car(1, "BMW", 400);
            //car = new Car(10);
            //Console.WriteLine(car);
            //ctor selection
            //allocate object in heap // 16 byte
            //called default ctor 

            #endregion
            #endregion

            #region Inheritance 
            //Parent parent; //refernce 
            //parent = new Parent();
            //Console.WriteLine(parent);
            //Console.WriteLine(parent.Product());

            //parent = new Child();    //upcasting

            //ref parent === object child   -- binding
            //parent.Z = 1;

            //Child child = new Child();
            //child.X = 10;
            //child.Y = 20;
            //child.Z = 30;
            //child.Product();
            //Console.WriteLine(child);


            //Child child = new Child(10, 20, 30);
            #endregion

            #region Continue Access Mofidiers 

            #region Type A 
            //private int x;
            //internal int y;
            //public int z;

            //private protected int a;
            //protected int b;
            //internal protected int c;

            //TypeA typeA = new TypeA();
            ////typeA.x 
            ////typeA.y
            //typeA.z = 10; 
            //typeA.a = 10; //invaid
            //typeA.b = 10;  //invalid
            //typeA.c = 10; //invalid
            #endregion

            #region Type B
            #region Type B Attributes
            ////x = 1; //invalid // not inherited
            //y = 2; //valid //internal is inherited inside the same project as [internal]
            //z = 3; //valid //public is inherited anywhere [public]
            //a = 4; //valid //private protected is inherited inside the same project [private] 
            //b = 5; //valid //protected is inherited anywhere [private] 
            //c = 6; //valid //internal protected is inherited inside the same project [internal] 
            #endregion

            //TypeB typeB = new TypeB();
            //typeB.y = 1; //invalid
            //typeB.z = 1;

            //typeB.a = 1;
            //typeB.b = 1;
            //typeB.c = 1;


            #endregion

            #region Type D
            #region Type D Attributes
            //x = 1; //invalid -- not inherited
            //y = 2; //invalid -- not inherited outside assembly
            //z = 3; //valid //inherited as [public] anywhere

            //a = 1; //invalid -- not inherited outside assembly
            //b = 2; //valid -- inherited as private anywhere
            //c = 3; //valid -- inherited as private outside assembly
            #endregion

            //TypeD typeD = new TypeD();

            //typeD.z = 1;

            #endregion

            #endregion

            #region Method Overloading
            //int a = 5;
            //int b = 10;
            //int result = Sum(a, b);
            //double result2 = Sum(10.5, b);
            #endregion

            #region Generics
            //GenericObject<Car> genericObject = new GenericObject<Car>();
            //GenericObject<bool> genericObject3 = new GenericObject<bool>();
            //GenericObject<int> genericObject2 = new GenericObject<int>();
            ////Car car = new Car(10);
            //genericObject3.Print<int>(10);
            #endregion

            #region Operator Overloading

            #region Binary Operators
            //Complex c1 = new Complex() { Real = 2, Imag = 3 };
            //Complex c2 = new Complex() { Real = 4, Imag = 5 };  //6 + 8 i

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            ////Complex c4 = null;
            //Complex c3 = c1 - c2;
            //Console.WriteLine(c3);

            #endregion

            #region Unary Operators
            //Complex c1 = new Complex() { Real = 2, Imag = 3 };
            //Complex c2 = new Complex() { Real = 4, Imag = 5 };  //6 + 8 i

            //Console.WriteLine(c1++);
            //Console.WriteLine(c1);
            //Console.WriteLine(++c1);
            #endregion

            #region Relational Operators  

            //Complex c1 = new Complex() { Real = 2, Imag = 3 };
            //Complex c2 = new Complex() { Real = 4, Imag = 5 };  //6 + 8 i

            ////refernces 
            //Console.WriteLine(c1.Equals(c2));
            //if (c1 == c2)
            //{
            //    Console.WriteLine("C1 >");
            //}
            //else
            //{
            //    Console.WriteLine("C1 <=");
            //}
            #endregion

            #region Casting Operator Overloading 
            //Complex C1 = new Complex() { Real = 2 , Imag = 3};
            //int x = (int)C1;
            //Console.WriteLine(x);

            //string str = (string)C1; //implicit overloading
            //Console.WriteLine(str);
            #endregion

            #region User Defined Datatype Casting Operator overloading [Mapping]
            //User user = new User()
            //{
            //    Id = 10,
            //    Email = "email",
            //    FullName = "Fatma Alaa",
            //    Password = "password",
            //    SecurityStamp = Guid.NewGuid()
            //};
            //UserViewModel viewModel = user;
            //Console.WriteLine(viewModel);

            //automapper
            #endregion
            #endregion
        }
    }
}
