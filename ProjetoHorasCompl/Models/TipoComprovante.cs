using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHorasCompl.Models
{
    public class TipoComprovante
    {
        public int Id { get; set; }
        public string TipNome { get; set; }

        public TipoComprovante()
        {
        }

        public TipoComprovante(int id, string tipNome)
        {
            Id = id;
            TipNome = tipNome;
        }
    }
}
