using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INota.Models
{
	/// <summary>
	/// ENUM COM A FORMA DE EMISSAO DO DOCUMENTO ELETRONICO
	/// </summary>
	public enum FormaEmissao
	{
		Desconhecido,
		Normal = 1,
		Contingencia_FS = 2,
		Contingencia_SCAN = 3,
		Contingencia_DPEC = 4,
		Contingencia_FSDA = 5,
		ContingênciaSVCAN = 6,
		ContingênciaSVCRS = 7,
		AutorizacaoSVCSP = 8,
		ContingênciaOfflineNFCe = 9
	}
}
