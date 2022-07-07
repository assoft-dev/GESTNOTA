using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INota.Models
{
    public class TipoPagamento
    {
        [Key]
        public int idTipoPagamento { get; set; }
        public string descricao { get; set; }
        public string abreviacao { get; set; }
    }
}
