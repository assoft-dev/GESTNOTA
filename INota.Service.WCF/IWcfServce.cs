using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace INota.Service.WCF
{
    public interface IWcfService : INfeService
    {
		[OperationContract]
		void InstalarCertificado(byte[] certificado, string senha);

		[OperationContract]

		IEnumerable<X509CertificateDescription> ListarCertificados();

		[OperationContract]
		bool TestarExportacaoArquivo(string path);

		[OperationContract]
		void TestarImpressao(string printerName);

		[OperationContract]
		string TestarEmail(string smtp, string user, string password, bool useSsl, string emailTo, int? port);

	}

	public class X509CertificateDescription
	{
		#region Fields

		private string name;

		#endregion

		#region Public Properties

		public string Name
		{
			get
			{
				if (!string.IsNullOrEmpty(this.name))
				{
					var split = this.name.Split(',');
					if (split.Length > 0)
					{
						return split[0].Replace("CN=", string.Empty);
					}
				}

				return this.name;
			}

			set
			{
				this.name = value;
			}
		}

		public DateTime NotAfter { get; set; }
		public string SerialNumber { get; set; }

		#endregion
	}


}
