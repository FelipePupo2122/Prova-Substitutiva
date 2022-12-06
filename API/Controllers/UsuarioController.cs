using System.Collections.Generic;
using System.Linq;
using api.Models;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly Context _context;
        public UsuarioController(Context context) =>
            _context = context;

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Usuario Usuario)
        {
            _context.Usuarios.Add(Usuario);
            _context.SaveChanges();
            return Created("", Usuario);
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            List<Usuario> Usuario = _context.Usuario.ToList();
            return Usuarios.Count != 0 ? Ok(Usuarios) : NotFound();
        }

        
    }
}