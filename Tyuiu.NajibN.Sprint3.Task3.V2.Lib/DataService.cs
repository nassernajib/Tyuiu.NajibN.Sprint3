using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NajibN.Sprint3.Task3.V2.Lib
{
    public class DataService : ISprint3Task3V2
    {
        public int GetMaxCharCount(string value, char item)
        {
            int cout = 0;
            foreach (char chr in value)
            {
                if (chr == item)
                {
                    cout++;
                }
            }
            return (cout);
        }
    }
}
