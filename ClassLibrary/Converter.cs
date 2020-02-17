using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IConverter
    {
        string Transform(int p1, int p2, string num);
    }

    public class Converter : IConverter
    {
        public string Transform(int p1, int p2, string num)
        {
            string res = Convert.ToString(p1) + Convert.ToString(p2) + num;

            return res;
        }
    }
}
