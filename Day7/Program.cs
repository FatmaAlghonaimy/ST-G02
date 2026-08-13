using Day7.Partial;
using Day7.Static;
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace Day7
{
    //enum struct interface class
    //public delegate int StringFuncDelegate(string s);
    //public delegate bool Pred(int s);
    //class , methods 

    //public class InvalidEmailExcpetion : Exception
    //{
    //    public InvalidEmailExcpetion(string message): base(message)
    //    {
            
    //    }
    //}
    internal class Program
    {
        //public static void ValidateEmail(string email)
        //{
        //    if(string.IsNullOrEmpty(email)|| !email.Contains("@"))
        //    {
        //        throw new InvalidEmailExcpetion("Invlaid email address");
        //    }
            
        //}
        static void Main(string[] args)
        {
            #region Static Modifier
            //Utility u1 = new Utility();
            //Console.WriteLine( u1.MeterToCM(15));
            //Console.WriteLine( u1.CalcCircleArea(3));

            //Utility u2 = new Utility();
            //Console.WriteLine(u2.MeterToCM(15));
            //Console.WriteLine(u2.CalcCircleArea(3));

            //Console.WriteLine( Utility.MeterToCM(15));
            //Console.WriteLine( Utility.CalcCircleArea(3));
            //Console.WriteLine(Utility.pi);
            #region Static Methods
            #endregion
            #region Static Fields and Property

            #endregion

            #endregion

            #region Class Other Modifiers
            //Employee employee = new Employee();
            //employee.Name = "Nada";
            //employee.Age = 10;
            //employee.MyProperty = 15;
            //employee.Print();
            #endregion

            #region Delegates

            #region Concept
            //reference to function
            //c# oop 

            // accept function as a paramter 
            // void print(function)

            // return function??

            // function print(function)

            // refernce to a function

            // event driven programming 

            //StringFuncDelegate? stringFuncDelegate;//= new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChar);

            //stringFuncDelegate = StringFunctions.GetCountOfUpperCaseChar;

            //stringFuncDelegate += StringFunctions.GetCountOfLowerCaseChar;
            //stringFuncDelegate -= StringFunctions.GetCountOfLowerCaseChar;
            //stringFuncDelegate -= StringFunctions.GetCountOfUpperCaseChar;

            //////syntax sugar

            ////string name = "Fatma";
            ////name = new string("fatma");

            //int result = stringFuncDelegate?.Invoke("HeLLO From ITi") ?? -1;
            //Console.WriteLine(result);
            #endregion

            #region Built in 
            //predicate return bool , accept 1 param

            //Predicate<int> predicate = TestBuiltinDelegates.CheckPositive;
            //bool result = predicate.Invoke(-1); Console.WriteLine(result);


            ////Func  return sth , 0 or more parameters
            //Func<string> func = TestBuiltinDelegates.Print;
            //string message = func.Invoke();
            //Console.WriteLine(message);

            //Func<int, string> func2 = TestBuiltinDelegates.Casting;
            //string message2 = func2(15);
            //Console.WriteLine(message2);


            ////action return void , 0 or more param
            //Action<string> action = TestBuiltinDelegates.Print;

            //Action action1 = TestBuiltinDelegates.Print;
            //action1.Invoke();
            //action.Invoke("message");
            #endregion

            #region Anonymous method
            //Action action = delegate { Console.WriteLine("Hello"); };
            //action.Invoke();
            //action();

            //Action<string> action1 = delegate(string name) { Console.WriteLine(name); };
            //action1.Invoke("Name");
            //action1("Name2");

            //Predicate<int> predicate = delegate(int num) { return num >0; };
            #endregion

            #region Lambda Expression
            //modern way of anonymous method , used with linq queries

            //Action action = () => Console.WriteLine("Hello");
            //action.Invoke();
            //action();

            //Action<string> action1 = name => Console.WriteLine(name);
            //action1.Invoke("Name");
            //action1("Name2");

            //Func<int, int, int> func = (num1, num2) => { return num1 + num2; };
            //int result =func(1, 3);
            //Console.WriteLine(result);
            #endregion
            #endregion

            #region Collections
            //non generic c#2
            #region Non Generic
            #region ArrayList
            //array of objects not fixed size 

            //ArrayList arrayList = new ArrayList();

            //Console.WriteLine(arrayList.Capacity);
            //Console.WriteLine(arrayList.Count);
            //Console.WriteLine("---------------");
            //add eleemt
            //arrayList.Capacity = 5;
            #region Add
            //arrayList.Add(1);  //boxing

            //Console.WriteLine(arrayList.Capacity); //can hold?
            //Console.WriteLine(arrayList.Count); //data
            //Console.WriteLine("---------------");

            //arrayList.Add(2);  //boxing arrayList.Add(1);  //boxing
            //arrayList.Add(3);  //boxing arrayList.Add(1);  //boxing
            //arrayList.Add(4);  //boxing arrayList.Add(1);  //boxing


            //Console.WriteLine(arrayList.Capacity); //can hold?
            //Console.WriteLine(arrayList.Count); //data
            //Console.WriteLine("---------------");

            //arrayList.Add(5);  //boxing arrayList.Add(1);  //boxing
            //arrayList.Add(6);  //boxing arrayList.Add(1);  //boxing

            //Console.WriteLine(arrayList.Capacity); //can hold?  *2
            //Console.WriteLine(arrayList.Count); //data
            //Console.WriteLine("---------------");

            //arrayList.AddRange(new[] { 10, 20, 30, 40 });

            //Console.WriteLine(arrayList.Capacity); //can hold?  *2
            //Console.WriteLine(arrayList.Count); //data
            //Console.WriteLine("---------------");

            //foreach (var item in arrayList) {
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Insert
            //count
            //arrayList.Insert(0, 10000); //10000 1
            //Console.WriteLine(arrayList.Capacity); //5
            //Console.WriteLine(arrayList.Count); //2
            //Console.WriteLine("---------------");
            //arrayList.InsertRange(1, new int[] { 50, 60, 70, 80 });

            //Console.WriteLine(arrayList.Capacity); //5
            //Console.WriteLine(arrayList.Count); //4
            //Console.WriteLine("---------------");
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            //10000  80
            #region Remove
            //arrayList.Remove(50);
            //arrayList.RemoveAt(0);
            //arrayList.RemoveRange(1, 3);
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region Contains
            //bool flag = arrayList.Contains(60);
            //Console.WriteLine(flag);
            #endregion

            #endregion
            #endregion

            #region Generic
            //list 
            #region List
            //List<int> list = new List<int>();

            ////Console.WriteLine(list.Capacity);
            ////Console.WriteLine(list.Count);

            //list.Add(1);
            ////Console.WriteLine(list.Capacity);
            ////Console.WriteLine(list.Count);
            ////Console.WriteLine("----------------");

            //list.AddRange( 2, 3, 4,5);
            ////Console.WriteLine(list.Capacity);
            ////Console.WriteLine(list.Count);

            //list.Insert(0, 1000);
            //list.InsertRange(0, 1000, 2000 ,3000);
            //foreach (int i in list) {
            //    Console.WriteLine(i);
            //}

            //list.Remove(1);
            //list.RemoveAt(3);
            //list.RemoveRange(0, 3);
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(list.Capacity);
            //Console.WriteLine(list.Count);
            //int firstElement = list[0];
            //list[4] = 1000;
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //list.Contains(1000);
            //add

            //ReadOnlyCollection<int> roc= list.AsReadOnly();
            //roc[0] = 1000;

            //Console.WriteLine( list.IndexOf(1000));
            //Console.WriteLine( list.LastIndexOf(1000));


            #region Method

            //List<int> numbers = new List<int>() { -10, 20, 30, 2, 6, 7, 5 };
            //bool result = numbers.Exists(x => x % 2 == 0);
            //Console.WriteLine(result);

            //int num = numbers.FindIndex(x => x % 2 == 0);
            //int num2 = numbers.FindLastIndex(x => x % 2 == 0);
            //Console.WriteLine(num2);
            //List<int> result = numbers.FindAll(x => x % 2 == 0);
            //foreach (int i in result) {
            //    Console.WriteLine(i);
            //}

            //numbers.ForEach(x => Console.WriteLine( ++x));
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int count = numbers.RemoveAll(x => x % 3 == 0);
            //Console.WriteLine(count);

            //bool falg  = numbers.TrueForAll(x => x > 0);
            //Console.WriteLine(falg);
            #endregion
            #endregion

            #region Stack

            ////lifo
            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            ////Console.WriteLine(stack.Capacity);
            ////Console.WriteLine(stack.Count);

            //int num =stack.Pop();
            //Console.WriteLine(num);

            //Console.WriteLine("-------------");
            //Console.WriteLine(stack.Capacity);
            //Console.WriteLine(stack.Count);

            //Console.WriteLine(stack.Peek());
            #endregion

            #region Queue
            //FiFo

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Peek());
            #endregion

            #region LinkedList
            //doubly linked list
            //item , pointer next pointer previous 

            //LinkedList<int> linkedlist =  new LinkedList<int>();
            //LinkedListNode<int> node1 =  linkedlist.AddFirst(1);
            //LinkedListNode<int> node2 =  linkedlist.AddLast(1000);
            //LinkedListNode<int> node3 =  linkedlist.AddAfter(node2, 8000);

            //foreach(int item in linkedlist)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion
            #endregion

            #region var and dynamic

            #region var
            //implicilty types variable 
            //compile time

            //linq qyeies , anonymous types
            //var x = 20;
            //x = 10;
            //x = false;
            //var y = null;
            //var x;
            #endregion

            #region dynamic
            //performance overhead 
            //dynamic x = null;
            //x = "Fatma";
            //x = 20;
            #endregion

            #endregion

            #region Exception Handling

            //try
            //{
            //    ////expected throw excpetion
            //    //int num1 = 10; int num2 = 0;
            //    //int result = num1 / num2;

            //    int[] arr = new int[3];
            //    Console.WriteLine(arr[10]);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: Unexpected behaviour");
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("This block will always execute");
            //}
            #region Custom Exception
            //try
            //{
            //    ValidateEmail("email");
            //    // database statement
            //}
            //catch(InvalidEmailExcpetion e)
            //{
            //    //rollback transaction
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region Inner Exception
            //try
            //{
            //    try
            //    {
            //        int[] num = { 1, 2, 3 };
            //        num[15] = 10;
            //    }
            //    catch (IndexOutOfRangeException exe)
            //    {
            //        throw new Exception("Error Happened", exe);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.InnerException?.Message);
            //}
            #endregion

            #endregion

        }
    }
}
