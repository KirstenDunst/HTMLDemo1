using System;

namespace 事件
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("事件Event的使用！");


            MyEvent myEvent = new MyEvent();
            myEvent.DoSomethingHandler += new DoSomething(ShowSomething);
            myEvent.DoSomethingHandler += ShowSomething;
            myEvent.DoSomethingHandler += ShowSomething;

            myEvent.DoSomethingHandler -= ShowSomething;
            myEvent.Invoke();



            Console.Read();
        }

        private static void ShowSomething(){
            Console.WriteLine("ShowSomething");
        }
    }
}
