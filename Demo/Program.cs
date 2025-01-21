namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region InterFace Vido 01

//IMyType myType = new IMyType(); // invalid 
//// You can not Crate an object From interface 

//IMyType myType1;
//// You can not Crate a reference From interface 
//// Clr Will Allocate 4 Bytes For Reference "MyType"
//// References "MyType" Refer To Null 
//// Reference "MyType" Can Refer To an object From Class Or Struct implement interface


//myType.Id = 1; // invalid -> meType Refer To Null 
//myType.Myfun(1); // invalid -> meType Refer To Null 
//myType.Print(); // invalid -> meType Refer To Null 


//MyType myType2 = new MyType();
//myType2.Id = 2; 
//myType2.Myfun(2);
//myType2.Print(); // invalid -> default implement Method


//IMyType myType3 = new MyType();
//// refer From Interface -> object from Class implement Interface 

//myType.Id = 10;
//myType3.Myfun(600); 

//Console.WriteLine()

#endregion 


                
        }
    }
}
