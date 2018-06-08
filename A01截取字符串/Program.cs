using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A01截取字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "窗前明月光,疑似地上霜,举头望明月,低头思故乡";
            str = str.Substring(12);//截取从0到12个字符
            Console.WriteLine(str);
            str = str.Substring(1,2);//截取从指定位置到结束位置字符
            Console.WriteLine(str);
            string str1 = "AWS 提供全面的人工智能平台和服务，此类服务提供云原生的机器学习和深度学习技术来应对不同用例和需求";
            if (str1.StartsWith("AWS"))//是否是以AWS开通
            {
                Console.WriteLine(str1);
            }
            if (str1.EndsWith("AWS"))//是否以AWS结尾
            {
                Console.WriteLine(str1);
            }

        }
    }
}
