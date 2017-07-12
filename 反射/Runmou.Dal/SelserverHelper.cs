using System;
using Runmou.Interface;

namespace Runmou.Dal
{
    public class SelserverHelper:IHelper
    {

        public SelserverHelper(){
            Console.WriteLine("这里开始构建SelserverHelper");
        }


        public void Query(){
            Console.WriteLine("SelserverHelper Query");
        }
    }

}
