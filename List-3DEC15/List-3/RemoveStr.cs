using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_3
{
    class RemoveStr
    {
        public static void removeChar(string s, char c)
        {
            int j, count = 0, n = s.Length;
            char[] t = s.ToCharArray();
            for (int i = j = 0; i < n; i++)
            {
                if (s[i] != c)
                {
                    t[j++] = s[i];
                }
                else
                {
                    count++;
                }
            }
            while (count > 0)
            {
                t[j++] = '\0';
                count--;
            }
            Console.Write(t);
        }
    }
}