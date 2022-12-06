using System;

namespace API.Models
{
    public class Imc
    {
        public Imc() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public int Altura { get; set; }
        public int Peso { get; set; }
        public int? DataNascimento { get; set; }
        public int classificacao { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
