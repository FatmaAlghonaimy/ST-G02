namespace Common
{
    public class Class1
    {
        public void Test()
        {
            TypeA typeA =  new TypeA();

            //typeA.x = 1 //invalid private
            typeA.y = 1; 
            typeA.z = 1; 
        }
    }
}
