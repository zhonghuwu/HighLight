using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hightlight
{
    class Highlight
    {
        public string ExcuteHight(string str, string hstr)
        {
            int beg = 0;
            while (beg < str.Length)
            {

                int hbeg = beg, mark = 0;
                while (mark < hstr.Length && beg < str.Length)
                {
                    if (str[beg] != hstr[mark++])//找到第一个匹配的字符
                    {
                        if (mark == hstr.Length)
                        {
                            beg++;
                            break;
                        }
                        continue;

                    }
                    hbeg++;
                    while (mark < hstr.Length && hbeg < str.Length)
                    {
                        if (str[hbeg] == hstr[mark])
                        {
                            hbeg++;
                            mark++;
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (hbeg - beg > 1)//找到匹配
                    {
                        //在beg和hbeg之前插入高亮标识
                        str = str.Insert(beg, "<font color=#c60a00>");
                        hbeg = hbeg + "<font color=#c60a00>".Length;
                        str = str.Insert(hbeg, "</font>");
                        hbeg = hbeg + "</font>".Length;
                        beg = hbeg;
                        break;
                    }
                    else
                    {
                        beg = hbeg;
                        continue;
                    }


                }


            }


            return str;

        }
    }
}
