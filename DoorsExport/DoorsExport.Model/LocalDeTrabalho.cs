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
        /// Codigo da empresa relacionada
        /// </summary>
        /// <remarks>mesmo que <see cref="Empresa.Codigo"/></remarks>
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
