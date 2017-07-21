using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace StressTest
{
    public class Debug
    {
        [Conditional("DEBUG")]
        public static void Check(bool b)
        {
            if (!b)
            {
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }

                else
                {
                    throw new Exception();
                }
            }
        }

        [Conditional("DEBUG")]
        public static void Check(bool b, string msg)
        {
            if (!b)
            {
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }

                else
                {
                    throw new Exception(msg);
                }
            }
        }

        public static void Verify(bool b)
        {
#if DEBUG

            if (!b)
            {
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }

                else
                {
                    throw new Exception();
                }
            }

#endif
        }

        public static void Verify(bool b, string msg)
        {
#if DEBUG

            if (!b)
            {
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }

                else
                {
                    throw new Exception(msg);
                }
            }

#endif
        }
    }
}
