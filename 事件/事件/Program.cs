using System;

namespace 事件
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("事件Event的使用！");

            MyEvent myEvent = new MyEvent();


            myEvent.DoSomethingHandlerEvent += new DoSomething(ShowSomething);
            myEvent.DoSomethingHandlerEvent += ShowSomething;
            myEvent.DoSomethingHandlerEvent += ShowSomething;
            myEvent.DoSomethingHandlerEvent -= ShowSomething;
            myEvent.InvokeEvent();


            myEvent.DoSomethingHandlerDelegate += new DoSomething(ShowSomething);
			myEvent.DoSomethingHandlerDelegate += ShowSomething;
			myEvent.DoSomethingHandlerDelegate += ShowSomething;

            myEvent.DoSomethingHandlerDelegate = new DoSomething(ShowSomething);
			myEvent.DoSomethingHandlerDelegate -= ShowSomething;
            myEvent.InvokeDelgate();


            Console.Read();
        }

        private static void ShowSomething(){
            Console.WriteLine("ShowSomething");
        }
    }
}
