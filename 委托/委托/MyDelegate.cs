using System;
namespace 委托
{
	
    public delegate void NoParaNoReturnOutClass();//1.委托的声明(也可以写在类的外面)

	public class MyDelegate
    {
        //1.委托的声明
        private delegate void NoParaNoReturn();//无参数无返回值的委托
        private delegate void WithParaNoReturn(string name, int id, DateTime now);//有参数无返回值的委托
        private delegate int NoParaWithReturn();//无参数有返回值的委托
        private delegate MyDelegate WithParaWithReturn();//有参数有返回值的委托




        //2.委托的实例化
        public static void Show()
        {
            NoParaNoReturn method = new NoParaNoReturn(ShowSomething);
            //3.委托的实例调用
            method.Invoke();
            //也可以这样写
            method();
        }

        private static void ShowSomething()
        {
            Console.WriteLine("这里是ShowSomeThing");
        }


	}

}
