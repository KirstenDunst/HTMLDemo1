using System;
namespace 事件
{
    public class Cat
    {

        public delegate void CatMiaoDelegate();

        //猫  叫一声
        public void Miao()
        {
            Console.WriteLine("****************Miao*****************");
            Console.WriteLine("猫 喵一声");
            Mouse.Run();
            Dog.Wang();
            Neighbor.Awake();
            Stealer.Hide();

            //Baby.Cry();
            //耦合


        }

        public event CatMiaoDelegate CatMiaoHandler;

        public void MiaoEvent(){
            Console.WriteLine("****************MiaoEvent*****************");
            Console.WriteLine("另外一只猫 喵一声");

            if(CatMiaoHandler!= null){
                CatMiaoHandler.Invoke();
            }
        }
    }
}
