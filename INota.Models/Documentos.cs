using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace INota.Models
{
    /// <summary>
    /// teste
    /// </summary>
    public class Documento
    {
        public string Id { get; set; }
        public string ambienteEmissao { get; set; }
        public string naturezaOperacao { get; set; }
        public bool enviarPorEmail { get; set; }
        public Pedido pedido { get; set; }
        
        //public int idCliente { get; set; }
        //[ForeignKey("idCliente")]
        public virtual Pessoa cliente { get; set; }

        //public int idTransportador { get; set; }
        //[ForeignKey("idTransportador")]
        public virtual Pessoa transportador { get; set; }


        // Lista = Enviar Array
        public List<Iten> itens { get; set; }
        


        public string numero { get; set; }
        public string serie { get; set; }

        /// <summary>
        /// Data e hora de emissão
        /// </summary>
        public DateTime DataEmissao { get; set; }

        /// <summary>
        /// 55 para nfe
        /// </summary>
        public string Modelo { get; set; }

        
        public Nullable<System.DateTime> DataRecepcao { get; set; }


        public StatusDocumento StatusDocumento { get; set; }

        //DADOS DO VEICULO
        public string veiculo_uf { get; set; }
        public string veiculo_placa { get; set; }
    } 
}
