using KTJ_RevenueBudget.ViewModel.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTJ_RevenueBudget.Repository.DML
{
    public interface IDapperDMO
    {
        InDapper DAPPER(string SQL, object Param);
    }
}
