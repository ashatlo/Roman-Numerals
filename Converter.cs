using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals
{
    public class Converter
    {
        public int Decimals { get; set; }
        public string Romans { get; set; }
      
        public Converter()
            {
            }
        public Converter(int Decimals, string Romans)
             
        {
            this.Decimals = Decimals;
            this.Romans = Romans;  
        }

    }
}
        