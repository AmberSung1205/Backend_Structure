
using KTJ_RevenueBudget.DIFactory;
using KTJ_RevenueBudget.Repository.DML;
using KTJ_RevenueBudget.ViewModel.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTJ_RevenueBudget.Model.DML
{
    [DependencyInjection]
    public class DapperDMO: IDapperDMO
    {
        public InDapper DAPPER(string SQL, object Param)
        {
            InDapper Dapper = new InDapper { SQL = SQL, Param = Param };

            return Dapper;
        }
    }
}
