using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLab
{
    internal class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public bool CodeCheckSyntax(string code, string language)
        {
            if(language == "CS")
            {
                Console.WriteLine("Its CS");
            }
            else if(language == "VB")
            {
                Console.WriteLine("Its VB");
            }
            else
            {
                Console.WriteLine("Not working");
                return false;
            }

            Console.WriteLine("Working");
            return true;
        }
    }
}
