using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL_POC.sakila;
using Microsoft.AspNetCore.Mvc;
using EntityGraphQL;
using EntityGraphQL.Schema;

namespace GraphQL_POC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly sakilaContext _dbContext;
        private readonly MappedSchemaProvider<sakilaContext> _schemaProvider;
        public ValuesController(sakilaContext dbContext, MappedSchemaProvider<sakilaContext> schemaProvider)
        {
            this._dbContext = dbContext;
            this._schemaProvider = schemaProvider;
        }
        //[HttpGet]
        //public ActionResult<string> Get( )
        //{

        //    return "hello";
        //}
        [HttpGet]
        public ActionResult<QueryResult> Get(string query)
       {

            
            var results = _dbContext.QueryObject(new QueryRequest { Query = query }, _schemaProvider);
            // gql compile errors show up in results.Errors
            return results;
        }

        //[HttpPost]
        // public void Post([FromBody] string value)
        // {
        // }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
