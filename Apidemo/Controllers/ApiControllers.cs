using System.Collections.Generic;
using Apidemo.Data;
using Apidemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Apidemo.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class ApiControllers : ControllerBase
    {
        private readonly MockApidemoRepo _repository = new MockApidemoRepo();
        [HttpGet]
        public ActionResult <IEnumerable<Api>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();

            return Ok(commandItems);
        }
        
        [HttpGet("{id}")]
        public ActionResult <Api> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}