using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace my_new_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioItemsController : ControllerBase
    {
        // GET: api/FuncionarioItems
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/FuncionarioItems/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/FuncionarioItems
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/FuncionarioItems/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
