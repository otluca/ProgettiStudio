using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiVari
{
    class StackTraceTest
    {
        public static void ExceptionFromStaticMethod ()
        {
            RiseException();
        }

        public void DirectException()
        {
            RiseException();
        }

        public void NestedException()
        {
            DirectException();
        }

        public void ReThrownException()
        {
            try {
                DirectException();
            }
            catch {
                throw;
            }
        }



        static void RiseException()
        {
            throw new Exception("This is an exception");
        }

    }
}
