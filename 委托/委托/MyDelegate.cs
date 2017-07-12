using System;
using System.Threading;

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
			#region 第一次
			//NoParaNoReturn method = new NoParaNoReturn(ShowSomething);
			////3.委托的实例调用
			//method.Invoke();
			////也可以这样写
			//method();
			#endregion 第一次


			#region 第二次
			NoParaWithReturn noParaWithReturnMethod = new NoParaWithReturn(GetSomething);
            //Console.WriteLine("noParaWithReturnMethod.Invoke()结果是{0}",noParaWithReturnMethod.Invoke());
            //Console.WriteLine("noParaWithReturnMethod()结果是{0}", noParaWithReturnMethod());

            //多播委托
            noParaWithReturnMethod += GetSomething;//按顺序添加到方法列表
            noParaWithReturnMethod += GetSomething;
            noParaWithReturnMethod += GetSomething;
            noParaWithReturnMethod += GetSomething;

            noParaWithReturnMethod -= GetSomething;//从方法列表的尾部去掉且只取掉一个完全匹配
            //多播委托执行返回数据是多次执行方法后最后一次的结果返回
			Console.WriteLine("noParaWithReturnMethod.Invoke()结果是{0}",noParaWithReturnMethod.Invoke());
			Console.WriteLine("noParaWithReturnMethod()结果是{0}", noParaWithReturnMethod());
			#endregion 第二次




			//



		}

        private static void ShowSomething()
        {
            Console.WriteLine("这里是ShowSomeThing");
        }


        public static int GetSomething()
        {
            Console.WriteLine("这里是GetSomething");

            Thread.Sleep(1200);
            return 11;//DateTime.Now.Millisecond;//获取当前时间的秒
        }
	}

}
