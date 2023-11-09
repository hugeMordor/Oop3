using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramConverter[] converters = new ProgramConverter[2];
            converters[0] = new ProgramConverter();
            converters[1] = new ProgramHelper();

            foreach(var converter in converters)
            {
                if(converter is ICodeChecker)
                {
                    string input = converter.ConvertToCSharp("codenotCS");
                    bool isWorking = ((ICodeChecker)converter).CodeCheckSyntax(input, "CS");
                    Console.WriteLine("Is working:" + Convert.ToString(isWorking));
                }
                else
                {
                    Console.WriteLine("ICodeChecker is not working at: " + Convert.ToString(converter.GetType()));
                }
            }
            Console.ReadKey();
        }
    }
}
