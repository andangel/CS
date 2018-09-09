using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 复选框属性与事件
{
    /// <summary>
    /// CheckBox对象
    /// </summary>
   public class CheckObject
    {
        /// <summary>
        /// 无参构造函数可以使用ctor代码段插入
        /// </summary>
        public CheckObject()
        {

        }
        /// <summary>
        /// 方法可以使用 prop代码段插入
        /// </summary>
        public string Text  { get; set; }
        public bool IsChecked { get; set; }
    }

}
