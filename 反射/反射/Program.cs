using System;
//using Runmou.Dal;

//这个是dotnet提供给我们的一个反射的类库（可以帮助我们动态的解析dal，动态的使用），今天是我们使用一下动态的加载
using System.Reflection;
using Runmou.Interface;

namespace 反射
{

	//反射的原理是基于 metadata（元数据）

	class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

			//         //普通做法（引入类库，创建对象调用方法）
			////这里我们在使用SqlserverHelper类的时候会又有提示（需要我们复制来SqlserverHelper类名之后右键resolve一下）
			//SelserverHelper sqlserverHelper = new SelserverHelper();
            //sqlserverHelper.Query();





			//反射
			//1.需要把Runmou.Dal文件夹内部的bin->Debug->里面的Runmou.Dal.pdb和Runmou.Dal.dll两个文件复制到反射->bin->Debug->里面

			//2.动态加载dll(如果这里报错，留意检查第一步的文件重新编译的时候给去除了)
			Assembly assembly = Assembly.Load("Runmou.Dal");

			Console.WriteLine("\n**************************Module模块的**************************\n");
			//获取他的所有的模块
			Module[] modules = assembly.GetModules();
			foreach (Module module in modules)
			{
				Console.WriteLine(module.Name);
			}


			Console.WriteLine("\n**************************Type 类**************************\n");
			//获取他的所有类型
			Type[] types = assembly.GetTypes();
			foreach (Type type in types)
			{
				Console.WriteLine(type.Name);
			}
			//根据关键字找到具体的某一个类
			Type typeHelper = assembly.GetType("Runmou.Dal.SelserverHelper");
            //初始化SqlserverHelper的对象(反射的方法创建一个对象)
			Object oHelper = Activator.CreateInstance(typeHelper);

            IHelper iHelper = (IHelper)oHelper;
            iHelper.Query();




			//保证控制台不会跳走
			Console.Read();
        }

    }
}
