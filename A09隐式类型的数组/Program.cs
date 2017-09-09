using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A09隐式类型的数组
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *可以创建隐式类型化的数组，其中数组实例的类型通过数组初始值设定项中指定的元素来推断。 针对隐式类型化变量的任何规则也适用于隐式类型化数组。 
             *有关详细信息，请参阅隐式类型局部变量。 
             *隐式类型化数组通常用于查询表达式、匿名类型、对象和集合初始值设定项。 
             *下列示例演示如何创建隐式类型化数组：  
             */
            var a = new[] { 1, 10, 100, 1000 }; // int[]
            var b = new[] { "hello", null, "world" }; // string[]

            // single-dimension jagged array
            int[][] c = new[]
            {
            new[]{1,2,3,4},
            new[]{5,6,7,8}
            };

            // jagged array of strings
            var d = new[]
            {
            new[]{"Luca", "Mads", "Luke", "Dinesh"},
            new[]{"Karen", "Suma", "Frances"}
            };
            foreach (var item in d)
            {
                Console.WriteLine("{0}",item);
            }
            /*
             * 对象初始值设定项中隐式类型化数组
                创建包含数组的匿名类型时，必须在类型的对象初始值设定项中隐式类型化数组。 
                在下列示例中，contacts 是匿名类型的隐式类型化数组，
                每个类型都包含名为 PhoneNumbers 的数组。 
                请注意，不可在对象初始值设定项中使用 var 关键字。 
             */
            var contacts = new[]
            {
                new {
                Name = " Eugene Zabokritski",
                PhoneNumbers = new[] { "206-555-0108", "425-555-0001" }
                },
                new {
                Name = " Hanying Feng",
                PhoneNumbers = new[] { "650-555-0199" }
                }
            };
        }
    }
}
