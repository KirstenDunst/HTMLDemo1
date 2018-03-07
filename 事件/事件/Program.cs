using System;

namespace 事件
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("事件Event的使用！");

            //MyEvent myEvent = new MyEvent();


            //         myEvent.DoSomethingHandlerEvent += new DoSomething(ShowSomething);
            //         myEvent.DoSomethingHandlerEvent += ShowSomething;
            //         myEvent.DoSomethingHandlerEvent += ShowSomething;

            //         //myEvent.DoSomethingHandlerEvent();  //不允许外面直接调用事件
            ////myEvent.DoSomethingHandlerEvent = new DoSomething(ShowSomething); //不允许外面直接对事件赋值

            //         //只能+=或者-=动作
            //         myEvent.DoSomethingHandlerEvent -= ShowSomething;
            //         myEvent.InvokeEvent();


            //         myEvent.DoSomethingHandlerDelegate += new DoSomething(ShowSomething);
            //myEvent.DoSomethingHandlerDelegate += ShowSomething;
            //myEvent.DoSomethingHandlerDelegate += ShowSomething;
            //         //可以直接调用
            //         myEvent.DoSomethingHandlerDelegate();
            //         //委托重新定义，能够重新赋值
            //         //myEvent.DoSomethingHandlerDelegate = new DoSomething(ShowSomething);
            //myEvent.DoSomethingHandlerDelegate -= ShowSomething;
            //myEvent.InvokeDelgate();



            Cat cat = new Cat();

            cat.Miao();

            cat.CatMiaoHandler += Dog.Wang;
            cat.CatMiaoHandler += Mouse.Run;
            cat.CatMiaoHandler += Neighbor.Awake;
            cat.CatMiaoHandler += Stealer.Hide;
            //对新的事件方法，只用在这里添加就可以了，方便顺序修改和添加


            //而之前的耦合性比较高，修改起来会比较麻烦
            cat.MiaoEvent();




            Console.Read();
        }

        private static void ShowSomething(){
            Console.WriteLine("ShowSomething");
        }
    }
}
