using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INota.Models
{
    public enum StatusDocumentoEletronico
    {
        Nenhum,
        ParaAutorizar,
        Autorizado,
        ParaCancelar,
        Cancelado,
        Denegado,
        AutorizadoFs
    }
}
