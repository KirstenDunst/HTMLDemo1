using System;
namespace 事件
{

    //
    public delegate void DoSomething();

    public class MyEvent
    {
        //委托的一个变量
        public  DoSomething DoSomethingHandlerDelegate;
        //事件：就是一个委托的变量，然后再加上了关键字event修饰
        public event DoSomething DoSomethingHandler;


        //委托是一种类型
        //事件是委托的一个实例


        //People就是一种类型 而Eleven就是people的一个实例
        private People people = new People()
        {
            Id = 11,
            Name = "Eleven"
        };



        public  void  Invoke(){
            if(DoSomethingHandler != null){
                DoSomethingHandler.Invoke();
            }
        }



    }




    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
