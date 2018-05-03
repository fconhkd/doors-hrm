using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoorsExport.Model
{
    /// <summary>
    /// Local de trabalho, relacionado a cada empresa
    /// </summary>
    /// <remarks>Tabela TABFPLOCA</remarks>
    public class LocalDeTrabalho
    {
        /// <summary>
        /// Identificador unico de cada local
        /// </summary>
        /// <remarks>O mesmo que concatenr a Empresa e Codigo</remarks>
        [BsonId]
        public long Id { get; set; }

        /// <summary>
        /// Codigo da empresa relacionada
        /// </summary>
        /// <remarks>mesmo que <see cref="Empresa.Codigo"/></remarks>
        [BsonIndex]
        public int Empresa { get; set; }

        /// <summary>
        /// Codigo utilizado internamente, unico para cada empresa
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Descrição do local
        /// </summary>
        public string Descricao { get; set; }


    }
}
