using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace INota.Service.WCF
{
    public interface INfeService
    {
		#region Public Methods and Operators

		[OperationContract]
		void NfeCancelar(long id, string motivo);

		[OperationContract]
		void NfeEnviarCartaCorrecao(long id, string correcao);

		[OperationContract]
		void NfeEnviarEmail(long id);

		[OperationContract]
		bool NfeEnviar(long id);

		[OperationContract]
		void NfeExportarPdfDisco(long id);

		[OperationContract]
		void NfeExportarXmlDisco(long id);

		[OperationContract]
		void NfeInutilizarNumeracao(
			int codigoFilial,
			int serie,
			int numeroInicial,
			int numeroFinal,
			string motivo);

		[OperationContract]
		void NfeStatusServico(int filial);

		#endregion
	}
}
