using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTJ_RevenueBudget.Model.DTO;
using KTJ_RevenueBudget.Repository.BCL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KTJ_RevenueBudget.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BoardApiController : ControllerBase
    {
        private IBoardBCO iBoardBCO;
        public BoardApiController(IBoardBCO _iBoardBCO)
        {
            iBoardBCO = _iBoardBCO;
        }

        [HttpGet]
        public string TestApi()
        {
            return "200";
        }

        [HttpGet]
        public List<Board> GetAll()
        {
            return iBoardBCO.GetAll();
        }
    }
}