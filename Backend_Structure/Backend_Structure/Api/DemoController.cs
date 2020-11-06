using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Structure.Api
{
    /// <summary>
    /// 設定API路由
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DemoController : ControllerBase
    {

    }
}