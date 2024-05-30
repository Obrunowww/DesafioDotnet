using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio.Entities
{
    public class Atividade
    {
        public int Id { get; set; }
        public required string Titulo { get; set; }
        public required string Descrição { get; set; }
        public required DateTime Data{ get; set; }
        public StatusEnum Status { get; set; }
    }
}