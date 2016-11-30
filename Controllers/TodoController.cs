using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class TodoController : Controller
    {
        private readonly Data.ITodoRepository _todoRepository;

        //Injection de dépendance via le constructeur
        public TodoController(Data.ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }
        
        //
        // GET: /Api/Todo
        [HttpGet]
        [AllowAnonymous]
        public IList<Models.TodoItem> Get()
        {
            //TODO :retourner la liste des items depuis le todoRepository
        }

        //
        // POST: /Api/Todo
        [HttpPostAttribute]
        [AllowAnonymous]
        public IList<Models.TodoItem> Post([FromBody]Models.TodoItem newItem)
        {
            //TODO :ajouter le nouvel item au todoRepository puis retourner la liste des todo items
        }
    }
}
