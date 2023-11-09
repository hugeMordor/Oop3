using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLab
{
    internal interface IConvertible
    {
        string ConvertToCSharp(string code);
        
        string ConvertToVB(string code);
    }
}
