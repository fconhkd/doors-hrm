using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoorsExport.Model
{
    /// <summary>
    /// Sindicato é uma agremiação não política segundo a norma legal brasileira
    /// </summary>
    /// <remarks>Tabela TABFPSIND</remarks>
    public class Sindicato
    {
        /// <summary>
        /// Codigo utilizado internamente no sistema
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Descricao / Nome do sindicatos
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Numero no cadastro nacional de PJ
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        /// Telefone
        /// </summary>
        public int Ddd { get; set; }
        public string Telefone { get; set; }

        /// <summary>
        /// Endereço
        /// </summary>
        public string TipoEndereco { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int Municipio { get; set; }
        public string CEP { get; set; }

    }
}
