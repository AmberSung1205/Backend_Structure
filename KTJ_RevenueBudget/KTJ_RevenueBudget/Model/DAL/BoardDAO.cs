using Dapper;
using KTJ_RevenueBudget.DIFactory;
using KTJ_RevenueBudget.Model.DTO;
using KTJ_RevenueBudget.Repository.DAL;
using KTJ_RevenueBudget.ViewModel.In;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace KTJ_RevenueBudget.Model.DAL
{
    [DependencyInjection]
    public class BoardDAO: IBoardDAO
    {
        private readonly SqlConnection _connString;
        public BoardDAO(IConfiguration configuration)
        {
            _connString = new SqlConnection(configuration.GetConnectionString("RevenueBudgetDB"));
            _connString.Open();
        }


        public List<Board> GetAll(InDapper item)
        {
            var result = _connString.Query<Board>(item.SQL, item.Param).ToList();
            //關閉連線字串
            _connString.Dispose();
            return result;
        }


    }
}
