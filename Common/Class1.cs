namespace Common
{
    public class Class1
    {
        #region A Attr
        //private int x;
        //internal int y;
        //public int z;

        //private protected int a;
        //protected int b;
        //internal protected int c;
        

        //remove protected 
        #endregion
        public void Test()
        {
            #region Before inheritance
            TypeA typeA =  new TypeA();

            //typeA.x = 1 //invalid private
            typeA.y = 1; 
            typeA.z = 1;
            //typeA.a = 1; //invalid
            //typeA.b = 1; //invalid
            typeA.c = 1; //valid
            #endregion

            #region Type B Attributes
            ////x = 1; //invalid // not inherited
            //y = 2; //valid //internal is inherited inside the same project as [internal]
            //z = 3; //valid //public is inherited anywhere [public]
            //a = 4; //valid //private protected is inherited inside the same project [private] 
            //b = 5; //valid //protected is inherited anywhere [private] 
            //c = 6; //valid //internal protected is inherited inside the same project [internal] 
            #endregion

            //TypeB typeB = new TypeB();
            //typeB.y = 1; 
            //typeB.z = 1;

            ////typeB.a = 1;
            ////typeB.b = 1;
            //typeB.c = 1;
        }
    }
}
