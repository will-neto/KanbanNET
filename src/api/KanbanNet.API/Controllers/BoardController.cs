using Microsoft.AspNetCore.Mvc;

namespace KanbanNet.API.Controllers
{
    [ApiController]
    [Route("api/boards")]
    public class BoardController : ControllerBase
    {

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Adicionar()
        {
            return Ok();
        }
    }
}
