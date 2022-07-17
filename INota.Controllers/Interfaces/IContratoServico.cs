using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INota.Controllers.Interfaces
{
    /// <summary>
    /// INTERFACE PADRAO PARA CONEXAO ENTRE APLICATIVO E API
    /// </summary>
    public interface IContratoServico
    {
        int EmitirNotaFiscal();
        string ConsultarNotaFiscal();
        string ConsultarXMLCancelamento();
        string EmitirCartaCorrecaoPelaChave();
        string ConsultarCartaCorrecao();
        string ConsultarXMLCartaCorrecao();
        string InutilizarNumeracao();
        string ConsultarInutilizcaoNumeroNotaFiscal();
        string ConsultarXMLInutilizacao();

        
    }
}
