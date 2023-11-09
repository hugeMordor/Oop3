using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLab
{
    internal class ProgramConverter: IConvertible
    {
        public string ConvertToCSharp(string code)
        {
            return "This is now CS code";
        }

        public string ConvertToVB(string code)
        {
            return "This is now VB code";
        }
    }
}
