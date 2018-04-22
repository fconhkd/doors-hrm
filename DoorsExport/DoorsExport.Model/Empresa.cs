using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoorsExport.Model
{
    /// <summary>
    /// Filial a qual os colaboradores estam ligados
    /// </summary>
    /// <remarks>TABGREMPR</remarks>
    public class Empresa
    {
        /// <summary>
        /// Codigo da Empresa
        /// </summary>
        [BsonId]
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
        /// Inscrição Estadual
        /// </summary>
        public string IE { get; set; }

        /// <summary>
        /// Controla o estado da empresa, se verdadeiro os dados serão sincronizados
        /// </summary>
        public bool Sincronizar { get; set; }
    }
}
