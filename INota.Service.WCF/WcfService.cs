using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INota.Service.WCF
{
    public class WcfService : IWcfService
    {
        public void InstalarCertificado(byte[] certificado, string senha)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<X509CertificateDescription> ListarCertificados()
        {
            throw new NotImplementedException();
        }

        public void NfeCancelar(long id, string motivo)
        {
            throw new NotImplementedException();
        }

        public bool NfeEnviar(long id)
        {
            throw new NotImplementedException();
        }

        public void NfeEnviarCartaCorrecao(long id, string correcao)
        {
            throw new NotImplementedException();
        }

        public void NfeEnviarEmail(long id)
        {
            throw new NotImplementedException();
        }

        public void NfeExportarPdfDisco(long id)
        {
            throw new NotImplementedException();
        }

        public void NfeExportarXmlDisco(long id)
        {
            throw new NotImplementedException();
        }

        public void NfeInutilizarNumeracao(int codigoFilial, int serie, int numeroInicial, int numeroFinal, string motivo)
        {
            throw new NotImplementedException();
        }

        public void NfeStatusServico(int filial)
        {
            throw new NotImplementedException();
        }

        public string TestarEmail(string smtp, string user, string password, bool useSsl, string emailTo, int? port)
        {
            throw new NotImplementedException();
        }

        public bool TestarExportacaoArquivo(string path)
        {
            throw new NotImplementedException();
        }

        public void TestarImpressao(string printerName)
        {
            throw new NotImplementedException();
        }
    }
}
