using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hightlight
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "足球";
            Console.WriteLine("原始字符串:  \n" + test);
            string hmark = "足球鞋";
            Console.WriteLine("输入查询词\n" + hmark);
            Highlight h = new Highlight();
            string result = h.ExcuteHight(test, hmark);
            Console.WriteLine("高亮后的结果:\n" + result);

            Console.ReadLine();
        }
    }
}
