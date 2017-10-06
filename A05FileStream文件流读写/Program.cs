using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace A05FileStream文件流读写
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./MyTest.txt";

            // Delete the file if it exists.
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            //Create the file.
            using (FileStream fs = File.Create(path))
            {
                AddText(fs, "对酒当歌，人生几何！\n");
                AddText(fs, "譬如朝露，去日苦多。\n");
                AddText(fs, "慨当以慷，忧思难忘。\n");
                AddText(fs, "何以解忧？唯有杜康。\n");
                AddText(fs, "青青子衿，悠悠我心。\n");
                AddText(fs, "但为君故，沉吟至今。\n");
                AddText(fs, "呦呦鹿鸣，食野之苹。\n");
                AddText(fs, "我有嘉宾，鼓瑟吹笙。\n");
                AddText(fs, "明明如月，何时可掇？\n");
                AddText(fs, "忧从中来，不可断绝。\n");
                AddText(fs, "越陌度阡，枉用相存。\n");
                AddText(fs, "契阔谈，心念旧恩。\n");
                AddText(fs, "月明星稀，乌鹊南飞。\n");
                AddText(fs, "绕树三匝，何枝可依？\n");
                AddText(fs, "山不厌高，海不厌深。\n");
                AddText(fs, "周公吐哺，天下归心。\n");

                //for (int i = 1; i < 120; i++)
                //{
                //    AddText(fs, Convert.ToChar(i).ToString());

                //}
            }

            //Open the stream and read it back.
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
        }
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}
