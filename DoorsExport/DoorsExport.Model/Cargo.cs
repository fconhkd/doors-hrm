using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoorsExport.Model
{
    /// <summary>
    /// Cargo a qual o colaborador esta relacionado
    /// </summary>
    /// <remarks>TABFPCARG</remarks>
    public class Cargo
    {
        /// <summary>
        /// Codigo utilizado internamente no sistema
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Descrição/Nome do cargo
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Codigo da ocupação
        /// </summary>
        /// <remarks>Relacionado a tabela de ocupações <see cref="CBO.Codigo"/></remarks>
        public int CBO { get; set; }
    }
}
