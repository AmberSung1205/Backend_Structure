using KTJ_RevenueBudget.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTJ_RevenueBudget.Repository.BLL
{
    public interface IBoardBLO
    {
        List<Board> GetAll();
    }
}
