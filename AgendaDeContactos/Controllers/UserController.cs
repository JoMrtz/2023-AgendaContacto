using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaDeContactos.Controllers
{
    [Route(template:"api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private AgendaContext _agendaContext;
        public UserController(AgendaContext agendaContext)
        {
            _agendaContext = agendaContext;
        }

        [HttpGet]
        public IActionResult GetUsuarios()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult EliminarUsuario()
        {
            return NoContent();
        }
        [HttpGet(template:"apellido")]
        public IActionResult GetUsuariosxApellido()
        {
            return Ok(_agendaContext.Users);
        }
        [HttpPost]
        public IActionResult SendUsuarios()
        {
            return Ok();
        }

    }
}
