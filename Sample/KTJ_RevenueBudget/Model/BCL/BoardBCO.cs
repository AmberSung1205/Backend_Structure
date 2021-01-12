using KTJ_RevenueBudget.DIFactory;
using KTJ_RevenueBudget.Model.DTO;
using KTJ_RevenueBudget.Repository.BCL;
using KTJ_RevenueBudget.Repository.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTJ_RevenueBudget.Model.BCL
{
    [DependencyInjection]
    public class BoardBCO: IBoardBCO
    {
        private IBoardBLO iBoardBLO;
        public BoardBCO(IBoardBLO _iBoardBLO)
        {
            iBoardBLO = _iBoardBLO;
        }

        public List<Board> GetAll()
        {
            return iBoardBLO.GetAll();
        }
    }
}
