using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class SqlListClass
    {
        const int MaxSize = 100;
        private int length;
        public int ListLength
        {
            get { return length; }
        }
        public string[] data;
        public SqlListClass()
        {
            data = new string[MaxSize];
            length = 0;
        }

        public void CreateList(params string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                data[i] = s[i];
            }
            length = s.Length;
        }

        public bool GetItem(int num, ref string e)
        {
            if (num < 1 || num > length) return false;
            e = data[num - 1];
            return true;
        }
        public string DispList()
        {
            string s = null;
            if (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    s += " ";
                    s += data[i];
                }
                return s;
            }
            else
                return "空串";
        }

        public bool ListInsert(int num, ref string e)
        {
            if (num < 1 || num > length + 1)
            {
                return false;
            }
            else
            {
                for (int j = length; j >= num; j--)
                {
                    data[j] = data[j - 1];
                }
                data[num - 1] = e;
                length++;
                return true;
            }
        }

        public bool ListDelete(int num)
        {
            if (num < 1 || num > length + 1)
            {
                return false;
            }
            else
            {
                for (int j = num; j < length; j++)
                {
                    data[j - 1] = data[j];
                }
                length--;
                return true;
            }
        }
        public int LocItem(ref string e)
        {
            for (int i = 0; i < length; i++)
            {
                if (data[i] == e)
                {
                    return i + 1;
                }
            }
            return 0;
        }

    }
}
