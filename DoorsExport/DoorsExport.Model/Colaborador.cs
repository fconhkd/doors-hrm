using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoorsExport.Model
{
    /// <summary>
    /// Funcionário ou empregado
    /// </summary>
    public class Colaborador
    {
        public int EMPRESA { get; set; }
        public int CODIGO { get; set; }
        public string NOME { get; set; }
        public DateTime ADMISSAO { get; set; }
        public int? CARGO { get; set; }
        public int? SINDICATO { get; set; }
        public int? LOCAL { get; set; }
        public string CENTROCUSTO { get; set; }
        public string TIPOENDERECO { get; set; }
        public string ENDERECO { get; set; }
        public string NUMEROENDERECO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string MUNICIPIO { get; set; }
        public string CEP { get; set; }
        public string DDD { get; set; }
        public string TELEFONE { get; set; }
        public DateTime? DATANASCIMENTO { get; set; }
        public int? NACIONALIDADE { get; set; }
        public int? LOCALNASCIMENTO { get; set; }
        public int? ESTADOCIVIL { get; set; }
        public string SEXO { get; set; }
        public string CPF { get; set; }
        public string PIS { get; set; }
        public string RG { get; set; }
        public int AGENCIA { get; set; }
        public int? BANCO { get; set; }
        public string CONTA { get; set; }
        public string OBS { get; set; }
        public string TITULOELEITOR { get; set; }
        public string ZONA { get; set; }
        public string SECAO { get; set; }
        public string CTPS { get; set; }
        public DateTime? RESCISAO { get; set; }
    }
}
