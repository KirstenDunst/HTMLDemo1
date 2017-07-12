using System;

namespace 委托
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //MyDelegate.Show();



            //普通
            Greeting.SayHi("许老师",Greeting.PeopleType.Chinese);
            Greeting.SayHi("Eleven",Greeting.PeopleType.American);

            ///委托
            SayHiHandle sayHiHandle = new SayHiHandle(Greeting.SayHiChinese);
            Greeting.SayHiDelegate("许老师",sayHiHandle);

            SayHiHandle sayHiHandleAmerican = new SayHiHandle(Greeting.SayHiAmerican);
			Greeting.SayHiDelegate("Eleven", sayHiHandleAmerican);


            Console.ReadKey();
        }
    }
}
