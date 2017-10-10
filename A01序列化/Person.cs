using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 序列化
{
    /// <summary>
    /// Serializable 可序列化类标识
    /// </summary>
    [Serializable]
    class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age 
        {
            get { return _age; }
            set { _age = value; }
        }
        public Person() { }
        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, int age)
            : this(name)
        {
            this.Age = age;
        }
    }
}
