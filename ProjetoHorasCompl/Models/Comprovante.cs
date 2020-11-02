using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHorasCompl.Models
{
    public class Comprovante
    {
        public int Id { get; set; }
        public string CmpDescricao { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Data do início é um campo obrigatório.")]
        public DateTime CmpDataInicio { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Data do fim é um campo obrigatório.")]
        public DateTime CmpDataFim { get; set; }
        [Required(ErrorMessage = "Quantidade de horas é um campo obrigatório.")]
        public int CmpQtdHoras { get; set; }
        public Aluno CmpAluId { get; set; }
        public TipoComprovante CmpTipoComprovantes { get; set; }

        public Comprovante()
        {
        }

        public Comprovante(int id, string cmpDescricao, DateTime cmpDataInicio, DateTime cmpDataFim, int cmpQtdHoras, Aluno cmpAluId, TipoComprovante cmpTipoComprovantes)
        {
            Id = id;
            CmpDescricao = cmpDescricao;
            CmpDataInicio = cmpDataInicio;
            CmpDataFim = cmpDataFim;
            CmpQtdHoras = cmpQtdHoras;
            CmpAluId = cmpAluId;
            CmpTipoComprovantes = cmpTipoComprovantes;
        }
    }
}
