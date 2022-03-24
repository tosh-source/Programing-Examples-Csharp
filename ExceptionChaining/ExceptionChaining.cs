using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionChaining
{
    class ExceptionChaining
    {
        static void Main(string[] args)
        {
            try
            {
                FirstChainedMethod();
            }
            catch (Exception generalEx)
            {
                Console.WriteLine(generalEx.Message);
            }
        }

        private static void FirstChainedMethod()
        {
            try
            {
                SecondChainedMethod();
            }
            catch (InvalidOperationException invlidEx)
            {
                throw new InvalidOperationException("Test SECOND exception!" +
                                                    $"\n{invlidEx.Message}");
            }
        }

        private static void SecondChainedMethod()
        {
            //throw new NotImplementedException("Test FOUR exception!");  //If uncomment it, this exception will be caught directly by "Exception" class, not by "InvalidOperationException"!

            throw new InvalidOperationException("Test THIRD exception!");
        }
    }
}
