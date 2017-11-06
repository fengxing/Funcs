using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MutexDemo
{
    class Program
    {
        public static Mutex m = new Mutex(true, "Text");
        static void Main(string[] args)
        {
            try
            {
                if (args.Contains("a"))
                {
                    while (true)
                    {
                        Log("a");
                    }
                }
                else
                {
                    while (true)
                    {
                        Log("b");
                    }
                }
            }
            catch (Exception ex)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\MutexTestError.txt", true);
                sw.WriteLine(ex.Message);
                sw.Flush();
                sw.Close();
            }
        }


        public static void Log(string p)
        {
            m.WaitOne();
            System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\MutexTest.txt", true);
            sw.WriteLine(p + DateTime.Now.ToString());
            sw.Flush();
            sw.Close();
            m.ReleaseMutex();
        }
    }
}
