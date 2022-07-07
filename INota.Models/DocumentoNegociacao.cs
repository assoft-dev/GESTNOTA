using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INota.Models
{
    /// <summary>
    /// DADOS DA NEGOCIACAO DO DOCUMENTO
    /// </summary>
    public class DocumentoNegociacao
    {
        //[Key]
        public int idDocumentoNegociacao { get; set; }
        
        public long idDocumento { get; set; }
        [ForeignKey("idDocumento")]
        public virtual Documento documento { get; set; }
        public int Parcela { get; set; }
        public string NumeroCheque { get; set; }
        public string BancoCheque { get; set; }
        public string AgenciaCheque { get; set; }
        public Nullable<System.DateTime> DataEmissao { get; set; }
        public Nullable<System.DateTime> DataVencimento { get; set; }

        public decimal Valor { get; set; }

        public string NumeroAutorizacaoCartao { get; set; }
        public string ContaCheque { get; set; }
        public Nullable<int> NumeroParcelasCredito { get; set; }

        public int idTipoPagamento { get; set; }
        [ForeignKey("idTipoPagamento")]
        public virtual TipoPagamento tipoPagamento { get; set; }

        

    }
}
