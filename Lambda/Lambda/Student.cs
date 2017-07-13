using System;
using System.Collections.Generic;

namespace Lambda
{
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class Data
    {
        public static List<Student> StudentList = new List<Student>()
        {
            new Student()
            {
                Name = "蛮小满",
                Age = 35
            },
			new Student()
			{
				Name = "蛮吉",
				Age = 8
			},
			new Student()
			{
				Name = "李星云",
				Age = 18
			},
			new Student()
			{
				Name = "罗小黑",
				Age = 5
			},
			new Student()
			{
				Name = "我的方式",
				Age = 25
			},

        };
    }
}
