using System.Collections.Generic;
using System.Linq;
using api.Models;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("api/imc")]
    public class ImcController : ControllerBase
    {
        private readonly Context _context;
        public ImcController(Context context) =>
            _context = context;

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Imc Imc)
        {
            _context.Imcs.Add(Imc);
            _context.SaveChanges();
            return Created("", Imc);
        }

        [HttpPut]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] Imc Imc)
        {
            _context.Imcs.Update(imc);
            _context.SaveChanges();
            return Created("", imc);
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            List<Imc> Imcs = _context.Imcs.Include(x => x.UsuarioId).Include.ToList();
            return Imc.Count != 0 ? Ok(Imc) : NotFound();
        }

    }
}