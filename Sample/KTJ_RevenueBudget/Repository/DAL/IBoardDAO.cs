using KTJ_RevenueBudget.Model.DTO;
using KTJ_RevenueBudget.ViewModel.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTJ_RevenueBudget.Repository.DAL
{
    public interface IBoardDAO
    {
        List<Board> GetAll(InDapper item);
    }
}
