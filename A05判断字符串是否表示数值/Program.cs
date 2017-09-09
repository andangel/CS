using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A05判断字符串是否表示数值
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "108";
            bool result = int.TryParse(s, out int i); //i now = 108
        }
    }
}
