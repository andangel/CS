using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A02抽象类练习一
{
   abstract class 形状
    {
       private double _r;
       private double _l;
       private double _w;

       public double R {
           get { return _r; }
           set { _r = value; }
       }
       public double L {
           get { return _l;}
           set { _l = value; }
       }
       public double W {
           get { return _w; }
           set { _w = value; }
       }
       public 形状() { }

       public abstract double 求面积(); 
       public abstract double 求周长();
    }
}
