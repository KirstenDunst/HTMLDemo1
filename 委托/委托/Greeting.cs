using System;
namespace 委托
{

	public delegate void SayHiHandle(string name);


    public class Greeting
    {
		public static void SayHi(string name,PeopleType type){
            if(type == PeopleType.Chinese){
				Console.WriteLine("早上好，{0}", name);
            }
            else if(type == PeopleType.American){
                Console.WriteLine("Morning，{0}", name);
            }
           
        }

        //列一个枚举
        public enum PeopleType{
            Chinese,
            American
        }



        //逻辑分离，解除耦合

        //这样写的方法不会造成数据之间的影响，每一个都是一个方法，
        //而上面的判断在这里逻辑比较简单，没有什么问题，比较复杂的逻辑就有可能出现问题
        public static void SayHiDelegate(string name,SayHiHandle sayHi){
            sayHi(name);
        }
		public static void SayHiChinese(string name)
		{
            Console.WriteLine("早上好，{0}", name);
		}
		public static void SayHiAmerican(string name)
		{
			Console.WriteLine("Morning，{0}", name);
		}


        //我们的代码要做到对扩展开放，对修改封闭（即：尽量通过扩展的方式添加东西，而不是通过修改的方式，应为修改是不稳定的）
    }
}
