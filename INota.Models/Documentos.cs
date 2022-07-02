using System.Collections.Generic;

namespace INota.Models
{
    public class Documentos
    {
        public string Id { get; set; }
        public string ambienteEmissao { get; set; }
        public string naturezaOperacao { get; set; }
        public bool enviarPorEmail { get; set; }
        public Pedido pedido { get; set; }
        public Cliente cliente { get; set; }

        // Lista = Enviar Array
        public List<Iten> itens { get; set; }
        public string informacoesAdicionais { get; set; }
    } 
}
