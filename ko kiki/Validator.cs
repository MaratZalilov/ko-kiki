using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ko_kiki;

public class Validator
    {
        public static bool Velodator(string str)
        {

            int count = 0;
            char[] chars = new char[] { '_', ' ' };
            for (int i = 0; i < str.Length; i++)
            {
                if (chars.Contains(str(i)))
                {
                    str=str.Remove(i);
                continue;
                }
                else if (char.IsDigit()
                {

                }
                
            }
            Console.WriteLine(str);
            return false;
        }
    }

