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
        public event DoSomething DoSomethingHandlerEvent;

#region   //这个字段相互之间的代码不进行编译，隐藏起来了
        //委托是一种类型
        //事件是委托的一个实例


        //People就是一种类型 而Eleven就是people的一个实例
        private People people = new People()
        {
            Id = 11,
            Name = "Eleven"
        };
#endregion


        public  void  InvokeEvent(){
            Console.WriteLine("*****************InvokeEvent*****************");
            if(DoSomethingHandlerEvent != null){
                DoSomethingHandlerEvent.Invoke();
            }
        }
		public void InvokeDelgate()
		{
			Console.WriteLine("*****************InvokeDelgate*****************");
            if (DoSomethingHandlerDelegate != null)
			{
				DoSomethingHandlerDelegate.Invoke();
			}
		}


    }




    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
