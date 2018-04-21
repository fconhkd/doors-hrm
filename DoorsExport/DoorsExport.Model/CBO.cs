using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoorsExport.Model
{
    /// <summary>
    /// Classificação Brasileira de Ocupações - CBO
    /// </summary>
    /// <remarks>TABFPCBO</remarks>
    public class CBO
    {
        /// <summary>
        /// Codigo da atividade/ocupação
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Descrição da atividade/ocupação
        /// </summary>
        public string Descricao { get; set; }
    }
}
