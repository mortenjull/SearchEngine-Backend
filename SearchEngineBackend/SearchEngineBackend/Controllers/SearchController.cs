using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SearchEngineBackend.Controllers
{
    [Route("api/[controller]")]
    public class SearchController : Controller
    {
        public SearchController()
        {

        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Search()
        {
            

            return Ok("connected");
        }
    }
}