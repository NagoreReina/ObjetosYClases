using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso5
{
    class Cifras
    {
        public int MyNum { get; set; }

        public Cifras(int myNum)
        {
            MyNum = myNum;
        }
        public bool EsPar()
        {
            if (MyNum%2 == 0)
            {
                return true;
            }
            return false;
        }
        public string Divisores()
        {
            string text = "";
            for (int i = 1; i < MyNum; i++)
            {
                if (MyNum%i == 0)
                {
                    text += $" {i} ";
                }
            }
            return text;
        }
        public int SumaDigitos()
        {
            string num = MyNum.ToString();
            char[] allNums = num.ToCharArray();
            if (allNums.Length == 1)
            {
                return MyNum;
            }
            else
            {
                int n = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    n += Convert.ToInt32(allNums[i].ToString());
                }
                return n;
            }
        }
    }
}
