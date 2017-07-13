using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    public class LinqTest
    {
        public static void Show()
        {
            List<Student> studentList = new List<Student>();
            foreach (Student student in Data.StudentList)
            {
                if(student.Age < 26)
                {
                    studentList.Add(student);
                }
            }
            Console.WriteLine("*********************foreach*******************");

            foreach (Student student in studentList)
            {
                Console.WriteLine("Name={0} Age={1}",student.Name, student.Age);
            }




            //使用linq
            var studentLinq = from s in Data.StudentList
                              where s.Age < 26
                              select s;
			
            Console.WriteLine("*********************linq*******************");

            foreach (Student student in studentLinq)
			{
				Console.WriteLine("Name={0} Age={1}", student.Name, student.Age);
			}



            //lambda  传入一个student类型的参数，返回一个bool类型
            var lambda = Data.StudentList.Where<Student>(s => s.Age < 26);

            Enumerable.Where(Data.StudentList,s => s.Age < 26);
                      
			Console.WriteLine("*********************lambda*******************");

            foreach (Student student in lambda)
			{
				Console.WriteLine("Name={0} Age={1}", student.Name, student.Age);
			}



			//使用自定义的LiqExtend去实线linq的内部逻辑
			var lambdaExtend = Data.StudentList.WhereCustomer<Student>(s => s.Age < 26);

			Console.WriteLine("*********************lambdaExtend*******************");

			foreach (Student student in lambdaExtend)
			{
				Console.WriteLine("Name={0} Age={1}", student.Name, student.Age);
			}

        }
    }





    //linq的实现方法自定义理论实现方式
    public static class LiqExtend
    {
        public static IEnumerable<T> WhereCustomer<T>(this IEnumerable<T> tList, Func<T, bool> func) where T :Student
        {
            var linq = from s in tList
                       //where s.Age < 26
                    where func(s)
                       select s;
            return linq;
        }
    }





}
