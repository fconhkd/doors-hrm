using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace DoorsExport
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //using (var conexaoFireBird = FirebirdDAO.GetInstancia().GetConexao())
            //{
            //    try
            //    {
            //        conexaoFireBird.Open();

            //        string mSQL = @"SELECT 
            //                          TABFPFUNC.EMPRE_FUNC,
            //                          TABGREMPR.RAZAO_EMPR,
            //                          TABFPFUNC.CODIG_FUNC,
            //                          TABFPFUNC.NOMEF_FUNC,
            //                          TABFPFUNC.DTADM_FUNC,
            //                          TABFPFUNC.CARGO_FUNC,
            //                          TABFPCARG.DESCR_CARG,
            //                          TABFPCARG.NOCBO_CARG,
            //                          TABFPCBO.DESCR_CBO,
            //                          TABFPFUNC.SINDI_FUNC,
            //                          TABFPSIND.DESCR_SIND,
            //                          TABFPFUNC.LOCAL_FUNC,
            //                          TABFPLOCA.DESCR_LOCA,
            //                          TABFPFUNC.LCNAS_FUNC,
            //                          LCNAS_DESC.DESCR_MUNI,
            //                          LCNAS_DESC.ESTAD_MUNI,
            //                          TABFPFUNC.MUNIC_FUNC,
            //                          TABGRMUNI_1.DESCR_MUNI,
            //                          TABGRMUNI_1.ESTAD_MUNI,
            //                          TABFPFUNC.TPEND_FUNC,
            //                          TABFPFUNC.ENDER_FUNC,
            //                          TABFPFUNC.NUMER_FUNC,
            //                          TABFPFUNC.COMPL_FUNC,
            //                          TABFPFUNC.BAIRR_FUNC,
            //                          TABFPFUNC.NOCEP_FUNC,
            //                          TABFPFUNC.NODDD_FUNC,
            //                          TABFPFUNC.NOTEL_FUNC,
            //                          TABFPFUNC.DTNAS_FUNC,
            //                          TABFPFUNC.CIVIL_FUNC,
            //                          TABFPFUNC.DEFIC_FUNC,
            //                          TABFPFUNC.SEXOF_FUNC,
            //                          TABFPFUNC.NUMCP_FUNC,
            //                          TABFPFUNC.SERCP_FUNC,
            //                          TABFPFUNC.ESTCP_FUNC,
            //                          TABFPFUNC.NOCPF_FUNC,
            //                          TABFPFUNC.NOPIS_FUNC,
            //                          TABFPFUNC.NORGF_FUNC,
            //                          TABFPFUNC.TITUL_FUNC,
            //                          TABFPFUNC.ZONAF_FUNC,
            //                          TABFPFUNC.SECAO_FUNC,
            //                          TABFPFUNC.BANCO_FUNC,
            //                          TABFPFUNC.AGENC_FUNC,
            //                          TABFPFUNC.CONTA_FUNC,
            //                          TABFPFUNC.TIPCC_FUNC
            //                        FROM
            //                          TABFPFUNC
            //                          INNER JOIN TABFPCARG ON(TABFPFUNC.CARGO_FUNC = TABFPCARG.CODIG_CARG)
            //                          INNER JOIN TABFPCBO ON (TABFPCARG.NOCBO_CARG = TABFPCBO.CODIG_CBO)
            //                          INNER JOIN TABFPSIND ON(TABFPFUNC.SINDI_FUNC = TABFPSIND.CODIG_SIND)
            //                          INNER JOIN TABGREMPR ON(TABFPFUNC.EMPRE_FUNC = TABGREMPR.CODIG_EMPR)
            //                          INNER JOIN TABFPLOCA ON(TABFPFUNC.EMPRE_FUNC = TABFPLOCA.EMPRE_LOCA)
            //                                              AND(TABFPFUNC.LOCAL_FUNC = TABFPLOCA.CODIG_LOCA)
            //                          INNER JOIN TABGRMUNI TABGRMUNI_1 ON(TABFPFUNC.MUNIC_FUNC = TABGRMUNI_1.CODIG_MUNI)
            //                          INNER JOIN TABGRMUNI LCNAS_DESC ON(TABFPFUNC.LCNAS_FUNC = LCNAS_DESC.CODIG_MUNI)
            //                        WHERE
            //                          TABFPFUNC.EMPRE_FUNC IN(113, 216, 223, 281, 282, 313, 331, 332, 374, 375, 411, 490, 496, 628, 645, 665, 672)";

            //        FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
            //        FbDataAdapter da = new FbDataAdapter(cmd);

            //        DataTable dtEmployee = new DataTable();
            //        da.Fill(dtEmployee);
            //        this.dataGridView1.DataSource = dtEmployee;
            //    }
            //    catch (FbException fbex)
            //    {
            //        MessageBox.Show("Erro de acesso ao Firebird : " + fbex.Message, "Erro");
            //    }
            //    finally
            //    {
            //        conexaoFireBird.Close();
            //    }
            //}
        }

    }
}
