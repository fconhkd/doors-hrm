using Dapper;
using DoorsExport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorsExport.Data.DAO
{
    /// <summary>
    /// Centralizar o acesso a dados de <see cref="Colaborador"/>
    /// </summary>
    internal class ColaboradorDAO
    {
        /// <summary>
        /// Obter um colaborador
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="codigo"></param>
        /// <returns></returns>
        internal Colaborador Get(int empresa, int codigo)
        {
            var query = @"SELECT 
                                TABFPFUNC.EMPRE_FUNC AS EMPRESA,
                                TABFPFUNC.CODIG_FUNC AS CODIGO,
                                TABFPFUNC.NOMEF_FUNC AS NOME,
                                TABFPFUNC.DTADM_FUNC AS ADMISSAO,
                                TABFPFUNC.CARGO_FUNC AS CARGO,
                                TABFPFUNC.SINDI_FUNC AS SINDICATO,
                                TABFPFUNC.LOCAL_FUNC AS LOCAL,
                                TABFPFUNC.CUSTO_FUNC AS CENTROCUSTO,
                                TABFPFUNC.TPEND_FUNC AS TIPOENDERECO,
                                TABFPFUNC.ENDER_FUNC AS ENDERECO,
                                TABFPFUNC.NUMER_FUNC AS NUMEROENDERECO,
                                TABFPFUNC.COMPL_FUNC AS COMPLEMENTO,
                                TABFPFUNC.BAIRR_FUNC AS BAIRRO,
                                TABFPFUNC.MUNIC_FUNC AS MUNICIPIO,
                                TABFPFUNC.NOCEP_FUNC AS CEP,
                                TABFPFUNC.NODDD_FUNC AS DDD,
                                TABFPFUNC.NOTEL_FUNC AS TELEFONE,
                                TABFPFUNC.DTNAS_FUNC AS DATANASCIMENTO,
                                TABFPFUNC.NACIO_FUNC AS NACIONALIDADE,
                                TABFPFUNC.LCNAS_FUNC AS LOCALNASCIMENTO,
                                TABFPFUNC.CIVIL_FUNC AS ESTADOCIVIL,
                                TABFPFUNC.SEXOF_FUNC AS SEXO,
                                TABFPFUNC.NOCPF_FUNC AS CPF,
                                TABFPFUNC.NOPIS_FUNC AS PIS,
                                TABFPFUNC.NORGF_FUNC AS RG,
                                TABFPFUNC.AGENC_FUNC AS AGENCIA,
                                TABFPFUNC.BANCO_FUNC AS BANCO,
                                TABFPFUNC.CONTA_FUNC AS CONTA,
                                TABFPFUNC.OBSER_FUNC AS OBS,
                                TABFPFUNC.TITUL_FUNC AS TITULOELEITOR,
                                TABFPFUNC.ZONAF_FUNC AS ZONA,
                                TABFPFUNC.SECAO_FUNC AS SECAO,
                                TABFPFUNC.NUMCP_FUNC AS CTPS,
                                TABFPRESC.DTRES_RESC AS RESCISAO
                            FROM
                                TABFPFUNC
                                LEFT OUTER JOIN TABFPRESC ON (TABFPFUNC.EMPRE_FUNC = TABFPRESC.EMPRE_RESC)
                                AND (TABFPFUNC.CODIG_FUNC = TABFPRESC.FUNCI_RESC)
                            WHERE
                                TABFPFUNC.EMPRE_FUNC = @Empresa and
                                TABFPFUNC.CODIG_FUNC = @Codigo";

            using (var db = ConnectionDAO.GetInstancia().GetFirebirdConnection())
            {
                return db.Query<Colaborador>(query, new { @Empresa = empresa, @Codigo = codigo }).FirstOrDefault();
            } 
        }
        
        /// <summary>
        /// Retorna uma lista de colaboradores demitidos
        /// </summary>
        /// <param name="dataDemissao">data a ser pesquisada</param>
        /// <returns></returns>
        internal IList<Colaborador> GetByDemissao(DateTime dataDemissao)
        {
            var query = @"SELECT 
                                TABFPFUNC.EMPRE_FUNC AS EMPRESA,
                                TABFPFUNC.CODIG_FUNC AS CODIGO,
                                TABFPFUNC.NOMEF_FUNC AS NOME,
                                TABFPFUNC.DTADM_FUNC AS ADMISSAO,
                                TABFPFUNC.CARGO_FUNC AS CARGO,
                                TABFPFUNC.SINDI_FUNC AS SINDICATO,
                                TABFPFUNC.LOCAL_FUNC AS LOCAL,
                                TABFPFUNC.CUSTO_FUNC AS CENTROCUSTO,
                                TABFPFUNC.TPEND_FUNC AS TIPOENDERECO,
                                TABFPFUNC.ENDER_FUNC AS ENDERECO,
                                TABFPFUNC.NUMER_FUNC AS NUMEROENDERECO,
                                TABFPFUNC.COMPL_FUNC AS COMPLEMENTO,
                                TABFPFUNC.BAIRR_FUNC AS BAIRRO,
                                TABFPFUNC.MUNIC_FUNC AS MUNICIPIO,
                                TABFPFUNC.NOCEP_FUNC AS CEP,
                                TABFPFUNC.NODDD_FUNC AS DDD,
                                TABFPFUNC.NOTEL_FUNC AS TELEFONE,
                                TABFPFUNC.DTNAS_FUNC AS DATANASCIMENTO,
                                TABFPFUNC.NACIO_FUNC AS NACIONALIDADE,
                                TABFPFUNC.LCNAS_FUNC AS LOCALNASCIMENTO,
                                TABFPFUNC.CIVIL_FUNC AS ESTADOCIVIL,
                                TABFPFUNC.SEXOF_FUNC AS SEXO,
                                TABFPFUNC.NOCPF_FUNC AS CPF,
                                TABFPFUNC.NOPIS_FUNC AS PIS,
                                TABFPFUNC.NORGF_FUNC AS RG,
                                TABFPFUNC.AGENC_FUNC AS AGENCIA,
                                TABFPFUNC.BANCO_FUNC AS BANCO,
                                TABFPFUNC.CONTA_FUNC AS CONTA,
                                TABFPFUNC.OBSER_FUNC AS OBS,
                                TABFPFUNC.TITUL_FUNC AS TITULOELEITOR,
                                TABFPFUNC.ZONAF_FUNC AS ZONA,
                                TABFPFUNC.SECAO_FUNC AS SECAO,
                                TABFPFUNC.NUMCP_FUNC AS CTPS,
                                TABFPRESC.DTRES_RESC AS RESCISAO
                            FROM
                                TABFPFUNC
                                LEFT OUTER JOIN TABFPRESC ON (TABFPFUNC.EMPRE_FUNC = TABFPRESC.EMPRE_RESC)
                                AND (TABFPFUNC.CODIG_FUNC = TABFPRESC.FUNCI_RESC)
                            WHERE
                                TABFPRESC.DTRES_RESC = @DataDemissao";

            using (var db = ConnectionDAO.GetInstancia().GetFirebirdConnection())
            {
                return db.Query<Colaborador>(query, new { @DataDemissao = dataDemissao }).ToList();
            }
        }

        /// <summary>
        /// Retorna uma lista de colaboradores admitidos em uma data
        /// </summary>
        /// <param name="dataAdmissao">data da admissão</param>
        /// <returns></returns>
        internal IList<Colaborador> GetByAdmissao(DateTime dataAdmissao)
        {
            var query = @"SELECT 
                                TABFPFUNC.EMPRE_FUNC AS EMPRESA,
                                TABFPFUNC.CODIG_FUNC AS CODIGO,
                                TABFPFUNC.NOMEF_FUNC AS NOME,
                                TABFPFUNC.DTADM_FUNC AS ADMISSAO,
                                TABFPFUNC.CARGO_FUNC AS CARGO,
                                TABFPFUNC.SINDI_FUNC AS SINDICATO,
                                TABFPFUNC.LOCAL_FUNC AS LOCAL,
                                TABFPFUNC.CUSTO_FUNC AS CENTROCUSTO,
                                TABFPFUNC.TPEND_FUNC AS TIPOENDERECO,
                                TABFPFUNC.ENDER_FUNC AS ENDERECO,
                                TABFPFUNC.NUMER_FUNC AS NUMEROENDERECO,
                                TABFPFUNC.COMPL_FUNC AS COMPLEMENTO,
                                TABFPFUNC.BAIRR_FUNC AS BAIRRO,
                                TABFPFUNC.MUNIC_FUNC AS MUNICIPIO,
                                TABFPFUNC.NOCEP_FUNC AS CEP,
                                TABFPFUNC.NODDD_FUNC AS DDD,
                                TABFPFUNC.NOTEL_FUNC AS TELEFONE,
                                TABFPFUNC.DTNAS_FUNC AS DATANASCIMENTO,
                                TABFPFUNC.NACIO_FUNC AS NACIONALIDADE,
                                TABFPFUNC.LCNAS_FUNC AS LOCALNASCIMENTO,
                                TABFPFUNC.CIVIL_FUNC AS ESTADOCIVIL,
                                TABFPFUNC.SEXOF_FUNC AS SEXO,
                                TABFPFUNC.NOCPF_FUNC AS CPF,
                                TABFPFUNC.NOPIS_FUNC AS PIS,
                                TABFPFUNC.NORGF_FUNC AS RG,
                                TABFPFUNC.AGENC_FUNC AS AGENCIA,
                                TABFPFUNC.BANCO_FUNC AS BANCO,
                                TABFPFUNC.CONTA_FUNC AS CONTA,
                                TABFPFUNC.OBSER_FUNC AS OBS,
                                TABFPFUNC.TITUL_FUNC AS TITULOELEITOR,
                                TABFPFUNC.ZONAF_FUNC AS ZONA,
                                TABFPFUNC.SECAO_FUNC AS SECAO,
                                TABFPFUNC.NUMCP_FUNC AS CTPS,
                                TABFPRESC.DTRES_RESC AS RESCISAO
                            FROM
                                TABFPFUNC
                                LEFT OUTER JOIN TABFPRESC ON (TABFPFUNC.EMPRE_FUNC = TABFPRESC.EMPRE_RESC)
                                                         AND (TABFPFUNC.CODIG_FUNC = TABFPRESC.FUNCI_RESC)
                            WHERE
                                TABFPRESC.DTADM_FUNC = @DataAdmissao";

            using (var db = ConnectionDAO.GetInstancia().GetFirebirdConnection())
            {
                return db.Query<Colaborador>(query, new { @DataAdmissao = dataAdmissao }).ToList();
            }
        }

        /// <summary>
        /// Obter todos os colaboradores de uma empresa
        /// </summary>
        /// <param name="empresa">codigo da empresa</param>
        /// <returns></returns>
        internal IList<Colaborador> GetAll(int empresa)
        {
            var query = @"SELECT 
                                TABFPFUNC.EMPRE_FUNC AS EMPRESA,
                                TABFPFUNC.CODIG_FUNC AS CODIGO,
                                TABFPFUNC.NOMEF_FUNC AS NOME,
                                TABFPFUNC.DTADM_FUNC AS ADMISSAO,
                                TABFPFUNC.CARGO_FUNC AS CARGO,
                                TABFPFUNC.SINDI_FUNC AS SINDICATO,
                                TABFPFUNC.LOCAL_FUNC AS LOCAL,
                                TABFPFUNC.CUSTO_FUNC AS CENTROCUSTO,
                                TABFPFUNC.TPEND_FUNC AS TIPOENDERECO,
                                TABFPFUNC.ENDER_FUNC AS ENDERECO,
                                TABFPFUNC.NUMER_FUNC AS NUMEROENDERECO,
                                TABFPFUNC.COMPL_FUNC AS COMPLEMENTO,
                                TABFPFUNC.BAIRR_FUNC AS BAIRRO,
                                TABFPFUNC.MUNIC_FUNC AS MUNICIPIO,
                                TABFPFUNC.NOCEP_FUNC AS CEP,
                                TABFPFUNC.NODDD_FUNC AS DDD,
                                TABFPFUNC.NOTEL_FUNC AS TELEFONE,
                                TABFPFUNC.DTNAS_FUNC AS DATANASCIMENTO,
                                TABFPFUNC.NACIO_FUNC AS NACIONALIDADE,
                                TABFPFUNC.LCNAS_FUNC AS LOCALNASCIMENTO,
                                TABFPFUNC.CIVIL_FUNC AS ESTADOCIVIL,
                                TABFPFUNC.SEXOF_FUNC AS SEXO,
                                TABFPFUNC.NOCPF_FUNC AS CPF,
                                TABFPFUNC.NOPIS_FUNC AS PIS,
                                TABFPFUNC.NORGF_FUNC AS RG,
                                TABFPFUNC.AGENC_FUNC AS AGENCIA,
                                TABFPFUNC.BANCO_FUNC AS BANCO,
                                TABFPFUNC.CONTA_FUNC AS CONTA,
                                TABFPFUNC.OBSER_FUNC AS OBS,
                                TABFPFUNC.TITUL_FUNC AS TITULOELEITOR,
                                TABFPFUNC.ZONAF_FUNC AS ZONA,
                                TABFPFUNC.SECAO_FUNC AS SECAO,
                                TABFPFUNC.NUMCP_FUNC AS CTPS,
                                TABFPRESC.DTRES_RESC AS RESCISAO
                            FROM
                                TABFPFUNC
                                LEFT OUTER JOIN TABFPRESC ON (TABFPFUNC.EMPRE_FUNC = TABFPRESC.EMPRE_RESC)
                                AND (TABFPFUNC.CODIG_FUNC = TABFPRESC.FUNCI_RESC)
                            WHERE
                                TABFPFUNC.EMPRE_FUNC = @Empresa";

            using (var db = ConnectionDAO.GetInstancia().GetFirebirdConnection())
            {
                return db.Query<Colaborador>(query, new { @Empresa = empresa }).ToList();
            }
        }

    }
}
