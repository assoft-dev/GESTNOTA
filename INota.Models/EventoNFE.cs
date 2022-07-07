using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INota.Models
{
    public class EventoNFE
    {
        public int idEvento { get; set; }

        public int idDocumento { get; set; }
        public virtual Documento documento{ get; set; }

        public string Descricao { get; set; }

        public string Protocolo { get; set; }

        public int Sequencia { get; set; }

        public string XmlEnvio { get; set; }

        public string XmlResposta { get; set; }

        public DateTime? DataHoraRecibo { get; set; }



    }
}
