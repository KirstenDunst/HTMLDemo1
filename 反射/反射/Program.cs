﻿using System;
//using Runmou.Dal;

//这个是dotnet提供给我们的一个反射的类库（可以帮助我们动态的解析dal，动态的使用），今天是我们使用一下动态的加载
using System.Reflection;
using Runmou.Interface;
using System.Configuration;

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





			////反射
			////1.需要把Runmou.Dal文件夹内部的bin->Debug->里面的Runmou.Dal.pdb和Runmou.Dal.dll两个文件复制到反射->bin->Debug->里面

			////2.动态加载dll(如果这里报错，留意检查第一步的文件重新编译的时候给去除了)
			//Assembly assembly = Assembly.Load("Runmou.Dal");

			//Console.WriteLine("\n**************************Module模块的**************************\n");
			////获取他的所有的模块
			//Module[] modules = assembly.GetModules();
			//foreach (Module module in modules)
			//{
			//	Console.WriteLine(module.Name);
			//}

			//Console.WriteLine("\n**************************Type 类**************************\n");
			////获取他的所有类型
			//Type[] types = assembly.GetTypes();
			//foreach (Type type in types)
			//{
			//	Console.WriteLine(type.Name);
			//}
			////根据关键字找到具体的某一个类
			//Type typeHelper = assembly.GetType("Runmou.Dal.SelserverHelper");
   //         //初始化SqlserverHelper的对象(反射的方法创建一个对象)
			//Object oHelper = Activator.CreateInstance(typeHelper);
            ////通过接口管理的方式调取方法
            //IHelper iHelper = (IHelper)oHelper;
            //iHelper.Query();






            Console.WriteLine("\n**************************可配置可扩展的**************************\n");
			//第一步，需要在App.config的配置文件里面添加配置（添加文件选择Misc-Application Configuration File，生成App.config文件）：
			/*<appSettings>
			 * <add key = "IHelperConfig" value="Runmou.Dal,Runmou.Dal.SelserverHelper" />
             * </appSettings>
             */
			//第二步：读取文件。添加系统的一个引用类System.Configuration
			//第三步:读取
			string IHelperConfig = ConfigurationManager.AppSettings["IHelperConfig"];
			//第四步：动态加载dll
            Assembly assembly = Assembly.Load(IHelperConfig.Split(',')[0]);
            Type typeHelper = assembly.GetType(IHelperConfig.Split(',')[1]);//找出具体类型
			Object oHelper = Activator.CreateInstance(typeHelper);//创建对象
			IHelper iHelper = (IHelper)oHelper;//转换对象
			iHelper.Query();//调用方法
            /*我们在需要替换的时候只需要修改配置环境（App.config）里面的东西,（前提要记得把编译生成的dll文件拷贝到这个文件路径下）
             * 比如使用新建一个Runmou.Dal.Mysql新类的时候，我们只需要修改为
             * <add key = "IHelperConfig" value="Runmou.Dal.Mysql,Runmou.Dal.Mysql.MysqlHelper" />
             */



			//保证控制台不会跳走
			Console.Read();
        }

    }
}
