using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DemoBlog.Extensions;
using Microsoft.AspNetCore.Authorization;
using DemoBlog.Security;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoBlog.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        [Authorize(Policy = Values.TokenPolicy)]
        public IEnumerable<string> Get()
        {
            Response.HttpContext.Session.Set<bool>("MaSession", true);
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            bool sessionValue = Response.HttpContext.Session.Get<bool>("MaSession");
            return "value";
        }
    }
}
