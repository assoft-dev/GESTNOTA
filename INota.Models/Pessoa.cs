using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INota.Models
{
    /// <summary>
    /// CLASSE REPRESENTANDO AS PESSOAS QUE SÃO TRANSACIONADAS NO SISTEMA
    /// </summary>
    public class Pessoa
    {
        public int id { get; set; }

        public string NomerazaoPessoa { get; set; } // nomerazao_pessoa
        public string NomefantasiaPessoa { get; set; } // nomefantasia_pessoa
        public string CpfcnpjPessoa { get; set; } // cpfcnpj_pessoa
        public System.DateTime? NascimentoPessoa { get; set; } // nascimento_pessoa
        public string ContatoPessoa { get; set; } // contato_pessoa
        public string EmailPessoa { get; set; } // email_pessoa
        public string IdentidadePessoa { get; set; } // identidade_pessoa
        public string OrgaoidentidadePessoa { get; set; } // orgaoidentidade_pessoa
        public string CaixapostalPessoa { get; set; } // caixapostal_pessoa
        public string CepPessoa { get; set; } // cep_pessoa
        public string ComplementoPessoa { get; set; } // complemento_pessoa

        #region Endereço de Cobrança
        public string CobenderecoPessoa { get; set; } // cobendereco_pessoa
        public string CobbairroPessoa { get; set; } // cobbairro_pessoa
        public string CobcomplementoPessoa { get; set; } // cobcomplemento_pessoa
        public string CobcaixapostalPessoa { get; set; } // cobcaixapostal_pessoa
        public string CobcepPessoa { get; set; } // cobcep_pessoa
        #endregion



        #region Endereço de Entrega
        public string EntenderecoPessoa { get; set; } // entendereco_pessoa
        public string EntbairroPessoa { get; set; } // entbairro_pessoa
        public string EntcomplementoPessoa { get; set; } // entcomplemento_pessoa
        public string EntcaixapostalPessoa { get; set; } // entcaixapostal_pessoa
        public string EntcepPessoa { get; set; } // entcep_pessoa
        #endregion

    }
}
