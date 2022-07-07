using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INota.Models
{
    /// <summary>
    /// CLASSE DO GERENCIMENTO ELETRONICO DO DOCUMENTO
    /// 
    /// O SERVICO IRA MONITORIAR ESSA TABELA, E VERIFICAR PELO STATUS AS NOTAS PENDENTES DE ENVIO
    /// 
    /// </summary>
    public class DocumentoEletronico
    {

        public string ChaveAcesso { get; set; }

        //[Key]
        public long IdDocumentoEletronico { get; set; }

        public int idDocumento { get; set; }
        [ForeignKey("idDocumento")]
        /// <summary>
        /// DOCUMENTO VINCULADO AO PROCESSO
        /// </summary>
        public virtual Documento documento { get; set; }

        public string ProtocoloAutorizacao { get; set; }

        public DateTime? DataAutorizacao { get; set; }

        public string ProtocoloCancelamento { get; set; }

        public DateTime? DataCancelamento { get; set; }


        /// <summary>
        /// AMBIENTE DO DOCUMENTO
        /// 1 PARA PRODUCAO
        /// 2 PARA HOMOLOCAÇÃO
        /// </summary>
        public int Ambiente { get; set; }

        public string DigestValue { get; set; }
        public string XmlAutorizacao { get; set; }
        public string XmlAutorizacaoResposta { get; set; }
        public string XmlAutorizacaoRetorno { get; set; }
        public string XmlAutorizacaoRetornoResposta { get; set; }
        public string XmlCancelamento { get; set; }
        public string XmlCancelamentoResposta { get; set; }
        public string XmlProcessado { get; set; }

        
        public StatusDocumentoEletronico Status { get; set; }
        public FormaEmissao FormaEmissao { get; set; }
        public int? Numero { get; set; }
        public string Erros { get; set; }
        public bool Erro { get; set; }
        public string MotivoCancelamento { get; set; }
        public string MotivoContingencia { get; set; }
        public DateTime? DataContingencia { get; set; }
        public string ReciboEnvio { get; set; }
        public string MensagemAtual { get; set; }

    }
}
