using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace DTS_CSharp_NangCao
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Tạo 1 contructor có tham số để tiện cho việc khởi tạo nhanh đối tượng Person với các giá trị cho sẵn
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        // Ovveride phương thức tostring để khi cần có thể in thông tin của object ra cho nhanh
        public override string ToString()
        {
            return "Name: " + name + " | Age: " + age;
        }
    }
}