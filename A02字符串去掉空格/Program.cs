using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02字符串去掉空格
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"     君不见，      黄河之   水天上来，         奔流到  海不复回。 
                                君不见，高堂 明      镜悲               白发，朝如青 丝暮成雪。                                      
                                人生         得意 须尽欢，      莫使  金樽   空对月。                             
                                天生我材    必有用，千金散            尽还复来。          
                                烹羊宰    牛且为乐，会须一饮三百杯。    
                                岑夫子，丹丘生，           将进酒，杯莫停。              
                                与君 歌  一曲，请 君为     我倾  耳听。               
                                钟鼓馔玉   不足贵，但愿长   醉不 复醒。             
                                古来圣 贤皆寂寞，惟有饮     者留 其名。     
                                陈王   昔时  宴平 乐，斗酒  十千 恣欢 谑。      
                                主人何为          言少钱，径须沽 取对 君酌。   
                                五花马，千金裘，呼 儿将出  换美 酒，与尔 同销       万古愁。      ";
            str = str.Trim();//移除左右空格,因为字符串不可变性.所以它会返回一个新的字符串
            while (str.IndexOf("  ") > -1)//判断是否包含两个空格
            {
                str = str.Replace("  ", " ");//如果有两个空格替换成一个空格
            }
            str = str.Replace(" ", "");//将一个空格替换为没有空格
            Console.WriteLine(str);
        }
    }
}
