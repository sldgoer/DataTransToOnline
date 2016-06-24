using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QueryFromInternal
{
    public class QueryInternal
    {
        public QueryInternal(){}

        LinqToJMGJJFactDataContext ltjdc = new LinqToJMGJJFactDataContext();

        public IEnumerable<lxb_EX_GDBS_SBResult> QuerySBData(DateTime begindate,DateTime enddate)
        {
            var bjresult = from r in ltjdc.lxb_EX_GDBS_SB(begindate, enddate)
                           select r;
            return bjresult;

        }

    }
}
