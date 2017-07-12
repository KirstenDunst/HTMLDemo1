using System;
using Runmou.Interface;

namespace Runmou.Dal.Mysql
{
	public class  MysqlHelper : IHelper
	{

		public MysqlHelper()
		{
			Console.WriteLine("这里开始构建SelserverHelper");
		}


		public void Query()
		{
			Console.WriteLine("SelserverHelper Query");
		}
	}
}
