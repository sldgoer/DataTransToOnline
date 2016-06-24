using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryFromInternal;

namespace DataTransToOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            printdata();
        }

        static void printdata()
        {
            QueryInternal qi = new QueryInternal();
            var sb = qi.QuerySBData(new DateTime(2016, 6, 1), DateTime.Now.Date);
            foreach (var o in sb)
            {
                Type t=o.GetType();
                foreach (var p in t.GetProperties())
                {
                    return;
                }
            }
        }
    }
}
