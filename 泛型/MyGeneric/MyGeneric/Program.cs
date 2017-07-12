using System;

namespace MyGeneric
{
    //
    //泛型
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int iValue = 123;
            long lValue = 456789;

            Console.WriteLine("***********************ShowInt,ShowLong************************\n");
            MethodShow.ShowInt(iValue);
            MethodShow.ShowLong(lValue);

            Console.WriteLine("\n***********************ShowObject************************\n");
            MethodShow.ShowObject(iValue);
            MethodShow.ShowObject(lValue);


            Console.WriteLine("\n***********************ShowGeneric************************\n");
            ////我们在使用的过程中标准的写法应该是这样的：
            //MethodShow.ShowGeneric<int>(iValue);
            //MethodShow.ShowGeneric<long>(lValue);
            ////这样写的话会报错，类型不匹配
            //MethodShow.ShowGeneric<int>(lValue);

            MethodShow.ShowGeneric(iValue);
            MethodShow.ShowGeneric(lValue);




            Console.WriteLine("\n***********************SayHiShow<T>(T tParameter) where T :People************************\n");
            Chinese chinese = new Chinese()
            {
                Changcheng = "万里长征",
                Kuaizi = "筷子",
                Id = 11,
                Age = 30,
                Name = "Eleven"
             };
            MethodShow.SayHiShow<People>(chinese);






            Console.Read();
        }
    }

    public class MethodShow{
        
        //int参数
        public static void ShowInt(int iParameter){
            Console.Write("这里是MethodShow ShowInt {0} 类型为{1}",iParameter,iParameter.GetType());
        }

		//long参数
        public static void ShowLong(long lParameter)
		{
			Console.Write("这里是MethodShow ShowLong {0} 类型为{1}", lParameter, lParameter.GetType());
		}

        //将上面的两个类型合并成下面的一个参数传入处理
		//object参数
        //object类型是任何类型的父类
        //c#语言是面向对象的语言（特性：继承，封装，多态）
        //任何父类出现的地方都可以用子类来代替
        public static void ShowObject(object oParameter)
		{
			Console.Write("这里是MethodShow Showobject {0} 类型为{1}", oParameter, oParameter.GetType());
		}

        //使用object的缺陷：
        //1.我们在使用object的时候实际上是有一个装箱和拆箱的过程。首先把任意类型装入object类型，然后在方法中再解析出原有类型，这样就会有一些消耗性能。
        //2.我们无法在运行的时候知道他的类型，有可能会报错




        //泛型
        //使用占位符T只有在使用的时候在能知道他的类型（就没有装箱和拆箱的过程）
        public static void ShowGeneric<T>(T tParameter)
		{
			Console.Write("这里是MethodShow ShowGeneric {0} 类型为{1}", tParameter, tParameter.GetType());
		}





		//这里使用泛型约束（在泛型方法的后面添加约束where T :People，这样我们就可以约束T是people类型）
		public static void SayHiShow<T>(T tParameter) where T : People
		{
			tParameter.SayHi();
			Console.WriteLine("{0} {1} {2}", tParameter.Id, tParameter.Name, tParameter.Age);
		}

		public static void SayHiShowObject(Object oParameter)
		{
			//Console.WriteLine(oParameter.);
		}




    }




    public class People{
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void SayHi(){
            Console.WriteLine("{0}说：早上好！",this.Name);
        }
    }

    public class Chinese:People
	{
        public string Kuaizi { get; set; }
        public string Changcheng { get; set; }
	}







}
