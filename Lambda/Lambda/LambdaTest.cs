using System;
namespace Lambda
{
    //Lambda表达式实质上就是一个匿名方法，只不过是写的方法上有些奇怪，就是来实例化委托的
    //Lambda表达式一定要有委托（）
    public delegate void NoReturn(int x, int y);


    public delegate int WithReturn(int x);


    public class LambdaTest
    {
        public static void Show()
        {
            NoReturn method0 = new NoReturn(ShowSomething);
            //上面的简写，也可以写成下面的方式
            NoReturn method1 = ShowSomething;

            //匿名方法使用和上面的传入有同样的使用，比较老1.0版本中
            NoReturn method2 = new NoReturn(
                delegate(int x, int y) {
                Console.WriteLine("delegate");
            }
            );


			NoReturn method3 = new NoReturn(
				(int x, int y) =>//lambda表达式（“=>”左边是参数列表，右边是方法体）
				{
					Console.WriteLine("delegate");
				}
			);


			NoReturn method4 = new NoReturn(
				(x, y) =>//委托的严格限制
                {
                    Console.WriteLine("delegate");
                }
			);


			NoReturn method5 = new NoReturn(
				(x,y) =>//委托的严格限制
				Console.WriteLine("delegate")//如果方法体只有一行，可以去掉大括号和分号
			);

			//这里我们省去new NoReturn方法，其实在实现的过程中，他是默认会调用这个方法的
			NoReturn method6 =(x, y) =>Console.WriteLine("delegate");










            WithReturn method7 = new WithReturn(ShowSomething3);
            //Lambda表达式写法
            WithReturn method8 = (int x) => { return 1; };
			//终极写法
			WithReturn method9 = x => 1;


            //Action 一个没有参数，没有返回值的委托
            //它的lambda表达式可以写成下面这个样子。表示：无参数，无返回值
            Action act1 = () => { };

            //Action带参数的委托写法，最多可以有16个参数，无返回值的委托（这些都可以使用action来写）
            Action<string,int,DateTime> act2 = (x,y,z) => Console.WriteLine("12334455");

            //无参数带返回值的委托的写法
            Func<int> fun1 = () => { return 1; };

            //有参数输入，前面的表示输入参数的类型(最多有16个)，最后一个表示返回参数的类型
            Func<string,DateTime,long,double,string> fun2 = (x,y,z,c) => { return "1"; };

            //总结就是系统给出的不带返回值的委托就是用Action,带返回值的委托我们就可以使用系统的Func








			method6(3, 4);

        }

        private static void ShowSomething(int x, int y){
            Console.WriteLine("ShowSomething");
        }
		private static void ShowSomething1(int x, int y)
		{
			Console.WriteLine("ShowSomething");
		}
		private static void ShowSomething2(int x, int y)
		{
			Console.WriteLine("ShowSomething");
		}
        private static int ShowSomething3(int x)
		{
			Console.WriteLine("ShowSomething3");
            return 1;
		}

    }
}
