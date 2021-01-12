using KTJ_RevenueBudget.DIFactory;
using KTJ_RevenueBudget.Model.DML;
using KTJ_RevenueBudget.Model.DTO;
using KTJ_RevenueBudget.Repository.BLL;
using KTJ_RevenueBudget.Repository.DAL;
using KTJ_RevenueBudget.Repository.DML;
using KTJ_RevenueBudget.ViewModel.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTJ_RevenueBudget.Model.BLL
{
    [DependencyInjection]
    public class BoardBLO: IBoardBLO
    {
        private IBoardDAO iBoardDAO;
        private IDapperDMO iDapperDMO;
        public BoardBLO(IBoardDAO _iBoardDAO, IDapperDMO _iDapperDMO)
        {
            iBoardDAO = _iBoardDAO;
            iDapperDMO = _iDapperDMO;
        }

        public List<Board> GetAll()
        {
            string SQL = @"SELECT * FROM Board";

            object Param = new { };

            InDapper Dapper = iDapperDMO.DAPPER(SQL.ToString(), Param);

            return iBoardDAO.GetAll(Dapper);
        }
    }
}
