using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcLib
{
    public class MyCalc
    {
        public int Sum(int label1, int textbox1)
        {
            return label1 + textbox1;

        }
        public int Min(int label2, int textbox2)
        {
            return label2 - textbox2;
        }

        public int Del(int label3, int textbox3)
        {
            return label3 / textbox3;
        }
        public int Ymn(int label4, int textbox4)
        {
            return label4 * textbox4;
        }
    }
}
