using Day_6.Interfaces;
using Day_6.Interfaces.Example;
using Day_6.Override;
using System.Diagnostics;
using System.Text;
using Day_6.BuiltinInterface;
using Day_6.Abstraction;

namespace Day_6
{
    internal class Program
    {
        #region When Binding Happens
        //public static void ProcessEmployee(Employee employee)
        //{
        //    employee.GetEmployeeType();
        //    employee.GetEmployeeData();

        //}
        #endregion

        #region Abstraction Methods

        //static void ProcessShape(Shape? shape)
        //{
        //    Console.WriteLine(shape?.CalcArea());
        //    Console.WriteLine(shape?.Preimeter);
        //}

        //static void Print2dShape(I2dDraw shape)
        //{

        //}
        ////static void Print2dShape(Square shape)
        ////{

        ////}
        //static void Print3dShape(I3dDraw shape)
        //{

        //}
        #endregion
        static void Main(string[] args)
        {

            #region Polymorphism - Overriding 
            //ClassA classA = new ClassA(10);
            //classA.MyFun01();
            //classA.MyFun02();

            //ClassB classB = new ClassB(10, 20);
            //classB.MyFun01();
            //classB.MyFun02();

            #endregion

            #region Binding 
            #region When Binding Happens 
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(10, "Ali", 20, 20000);
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee(20, "Ahmed", 25, 30, 300);
            //ProcessEmployee(fullTimeEmployee);
            //ProcessEmployee(partTimeEmployee);
            #endregion

            #region Example 

            #region Reference From D
            //ClassD classD = new ClassD(10, 20, 30, 40);
            //classD.A = 1;
            //classD.B = 2;
            //classD.C = 3;
            //classD.D = 4;
            //classD.MyFun01();
            //classD.MyFun02();
            #endregion

            #region Reference From C

            #region object of ClassC
            //ClassC classC = new ClassC(1, 2, 3);
            //classC.A = 1;
            //classC.B = 1;
            //classC.C = 1;

            //classC.MyFun01();
            //classC.MyFun02();
            #endregion

            #region object of ClassD
            //ClassC classC = new ClassD(1, 2, 3, 4);
            //classC.A = 1; classC.B = 2;
            //classC.C = 3;
            ////classC.D = 5; //invalid

            //classC.MyFun01(); //method of C reference    //based on refernce
            //classC.MyFun02(); // method of D???? //object type 
            #endregion
            #endregion

            #region Reference From B
            #region object of ClassB
            //ClassB classB = new ClassB(1,2);
            //classB.A = 1; classB.B = 2;
            //classB.MyFun01();
            //classB.MyFun02();
            #endregion

            #region object of ClassC
            //ClassB classB = new ClassC(1, 2,3);
            //classB.A = 1; classB.B = 2; 
            //classB.MyFun01();
            //classB.MyFun02();
            #endregion

            #region object of ClassD
            //ClassB classB = new ClassD(1, 2, 3,4);
            //classB.A = 1; classB.B = 2;
            //classB.MyFun01();
            //classB.MyFun02();  //object 
            #endregion
            #endregion

            #region Reference From A

            #region object of ClassA
            //ClassA classA = new ClassA(1);
            //classA.A = 2;
            //classA.MyFun01();
            //classA.MyFun02();
            #endregion

            #region object of ClassB
            //ClassA classA = new ClassB(1,2);
            //classA.A = 2;
            ////classA.B = 1 //invalid
            //classA.MyFun01();
            //classA.MyFun02();
            #endregion

            #region object of ClassC
            //ClassA classA = new ClassC(1, 2,3);
            //classA.A = 2;
            ////classA.B = 1 //invalid
            ////classA.C = 1 //invalid
            //classA.MyFun01();
            //classA.MyFun02();
            #endregion

            #region object of ClassD
            //ClassA classA = new ClassD(1, 2, 3,4);
            //classA.A = 2;
            ////classA.B = 1 //invalid
            ////classA.C = 1 //invalid
            ////classA.D = 1 //invalid
            //classA.MyFun01();
            //classA.MyFun02();
            #endregion

            #endregion

            #endregion
            #endregion

            #region Interface 

            //can create referene???
            //IType refe = new ClassInterface();
            //IType refe2 = new IType();

            #region 1- reference from Interface refering to abject that implements the interface
            //IType type = new ClassInterface(); //valid
            #region Accessing Interface Members
            ////type.MyProperty = 1; //invalid
            //Console.WriteLine(type.MyProperty); //valid
            //type.MyMethod();
            //type.MyMethod02("string");
            #endregion

            #region Accessing ClassInterface Members invaliddddd
            //type.MyProperty = 1; //invlaid
            //type.MyMethod03()
            #endregion
            #endregion

            #region 2- reference from Class refering to abject that implements the interface
            //ClassInterface classInterface = new ClassInterface();
            #region Accessing Interface Members
            //classInterface.MyProperty = 1;
            //Console.WriteLine(classInterface.MyProperty);
            //classInterface.MyMethod();
            //classInterface.MyMethod02(); //invalid
            #endregion

            #region Accessing ClassInterface Members
            //classInterface.MyProperty = 1;
            //classInterface.MyMethod03();
            #endregion

            #endregion

            #endregion

            #region Interface Example
            //Car car = new Car();
            //car.Speed = 300;
            //car.Backward();
            //car.Forward();
            //car.Left();
            //car.Right();

            //Airplane airplane = new Airplane();
            //airplane.Speed = 500;
            ////airplane.Forward();
            //airplane.Backward();
            //airplane.Left();
            ////airplane.Right();

            //IMoveOnAir moveOnAir = new Airplane();
            //IMoveOnGround moveOnGround = new Airplane();
            //moveOnGround.Forward();
            //moveOnAir.Forward();
            //moveOnAir.Backward();
            //moveOnAir.Left();
            //moveOnAir.Right();
            #endregion

            #region Shallow Copy And Deep Copy 

            #region Array Of Value Type 

            #region Shallow Copy
            //int[] arr1 = { 1, 2,3 };
            //int[] arr2 = new int[3];

            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());

            //arr1 = arr2;

            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());
            //arr1[0] = 1000;

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);
            #endregion

            #region Deep Copy 
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = new int[3];

            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());

            //arr1 = (int[])arr2.Clone();

            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());
            //arr1[0] = 1000;

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);
            #endregion

            #endregion

            #region Array Of Reference Type 

            #region Immutable Reference Type [String]
            //string[] names01 = { "Omar", "Amr" };
            //string[] names02 = new string[3];

            //Console.WriteLine(names01.GetHashCode());
            //Console.WriteLine(names02.GetHashCode());

            #region Shallow Copy
            //names01 = names02;
            //Console.WriteLine(names01.GetHashCode());
            //Console.WriteLine(names02.GetHashCode());

            //names01[0] = "Sama";
            //Console.WriteLine(names01[0]);
            //Console.WriteLine(names02[0]);
            #endregion

            #region Deep Copy
            //names02 = (string[])names01.Clone();
            //Console.WriteLine(names01.GetHashCode());
            //Console.WriteLine(names02.GetHashCode());

            //names01[0] = "Sama";
            //Console.WriteLine(names01[0]);
            //Console.WriteLine(names02[0]);
            #endregion

            #endregion

            #region Mutable Reference Type [stringbuilder]
            //StringBuilder[] names01 = new StringBuilder[1];
            //names01[0] = new StringBuilder("Omar");

            //StringBuilder[] names02 = new StringBuilder[2];


            //Console.WriteLine(names01.GetHashCode());
            //Console.WriteLine(names02.GetHashCode());
            #region Shallow Copy
            //names02 = names01;

            //Console.WriteLine(names01.GetHashCode());
            //Console.WriteLine(names02.GetHashCode());
            //names01[0].Append("Salma");
            //Console.WriteLine(names01[0]);
            //Console.WriteLine(names02[0]);
            #endregion

            #region Deep Copy
            //names02 = (StringBuilder[])names01.Clone();

            //Console.WriteLine(names01.GetHashCode());
            //Console.WriteLine(names02.GetHashCode());
            //names01[0].Append("Salma");
            //Console.WriteLine(names01[0]);
            //Console.WriteLine(names02[0]);
            #endregion

            #endregion

            #endregion

            #endregion

            #region Built in Interfaces + Copy Ctor

            #region ICloneable
            //Employee emp01 = new Employee() { Id = 1 , Name= "Ali", Salary = 2000};
            //Employee emp02 = new Employee() { Id =2 , Name= "Ahmed", Salary = 50000};

            //emp02 = (Employee)emp01.Clone();
            //emp02 = new Employee(emp01);

            ////emp01 = emp02;
            //Console.WriteLine(emp01);
            //Console.WriteLine(emp02);
            //emp01.Name = "nada";
            //Console.WriteLine(emp01);
            //Console.WriteLine(emp02);
            #endregion

            #region IComparable
            //Employee[] employees =
            //{
            //    new Employee(){Id = 10, Name="Ali", Salary =8000},
            //    new Employee(){Id = 5, Name="Omar", Salary =50000},
            //    new Employee(){Id = 8, Name="Ahmed", Salary =1000},
            //    new Employee(){Id = 1, Name="Nada", Salary =60000},
            //};
            //Array.Sort(employees);
            //Array.Reverse(employees);

            //foreach (Employee employee in employees) {
            //    Console.WriteLine(employee);
            //}
            #endregion

            #region IComparer

            //Employee[] employees =
            //{
            //    new Employee(){Id = 10, Name="Ali", Salary =8000},
            //    new Employee(){Id = 5, Name="Omar", Salary =50000},
            //    new Employee(){Id = 8, Name="Ahmed", Salary =1000},
            //    new Employee(){Id = 1, Name="Nada", Salary =60000},
            //};
            //Array.Sort(employees, new EmployeeNameComparer());
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion
            #endregion

            #region Abstraction
            //Shape shape = new Shape(); //invalid
            //Shape shape = new Rectangle(4, 5);
            //Shape shape2 = new Square(4);

            //Rectangle rec = new Rectangle(4, 5);
            //ProcessShape(rec);
            //ProcessShape(shape2);


            #region Class Test That inherits abstract class and implements the interface

            #region Refernce from Abstract Class 
            //Shape shape = new Test();
            #region accessing abstract class members
            //shape.Dim01 = 1;
            //shape.Dim02 = 1;
            //Shape.X = 5;

            //Console.WriteLine(shape.Preimeter);
            //shape.CalcArea();
            //shape.MyMethodShape();
            #endregion

            #region Accessing Interface Members  //invalid

            //Console.WriteLine(shape.MyPreoperty);
            //shape.MyMethod();
            //shape.MyMethod02();
            #endregion

            #region Accessing Test Members
            //shape.TestMethod();
            #endregion

            #endregion

            #region Refernce from Interface
            IType type = new Test();
            #region Accessing Interface Members 

            //Console.WriteLine(type.MyProperty);
            //type.MyMethod();
            //type.MyMethod02("");
            #endregion

            #region accessing abstract class members 

            //type.Dim01 
            //type.Dim02
            #endregion

            #region Accessing Test Members 
            //type.TestMethod();
            #endregion

            #endregion

            #region Refernce from Test Class
            //Test test = new Test();
            #region Accessing Test Members 
            //test.TestMEthod();
            //test.MyProperty = 10;
            #endregion

            #region Accessing Interface Members
            //test.MyMethod();
            //Console.WriteLine(test.MyProperty);
            //test.MyMethod02(""); //default implemented method
            #endregion

            #region accessing abstract class members 
            //test.Dim01 = 1;
            //test.Dim02 = 1;
            //Test.X = 1;
            //Console.WriteLine(test.Preimeter);
            //test.CalcArea();

            //test.MyMethodShape();
            #endregion
            #endregion
            #endregion

            #endregion
        }
    }
}
