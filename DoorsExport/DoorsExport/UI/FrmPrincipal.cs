using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DoorsExport.UI;
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
             
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frm2 = new FrmEmpresa();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void tsMenuSync_Click(object sender, EventArgs e)
        {
            var colaborador = new DoorsExport.Data.Business.ColaboradorBusiness().Get(113, 5375);
            
            var proxy = new ColaboradorSOAP.ColaboradorSoapClient();

            var result = proxy.ObterTodos(113);

            //var result = proxy.Inserir(new ColaboradorSOAP.Colaborador()
            //{
            //    EMPRESA = colaborador.EMPRESA,
            //    CODIGO = colaborador.CODIGO,
            //    ADMISSAO = colaborador.ADMISSAO,
            //    CARGO = colaborador.CARGO,
            //    SINDICATO = colaborador.SINDICATO,
            //    LOCAL = colaborador.LOCAL,
            //    CENTROCUSTO = colaborador.CENTROCUSTO,
            //    TIPOENDERECO = colaborador.TIPOENDERECO,
            //    ENDERECO = colaborador.ENDERECO,
            //    NUMEROENDERECO = colaborador.NUMEROENDERECO,
            //    COMPLEMENTO = colaborador.COMPLEMENTO,
            //    BAIRRO = colaborador.BAIRRO,
            //    MUNICIPIO = colaborador.MUNICIPIO,
            //    CEP = colaborador.CEP,
            //    DDD = colaborador.DDD,
            //    TELEFONE = colaborador.TELEFONE,
            //    DATANASCIMENTO = colaborador.DATANASCIMENTO,
            //    NACIONALIDADE = colaborador.NACIONALIDADE,
            //    LOCALNASCIMENTO = colaborador.LOCALNASCIMENTO,
            //    ESTADOCIVIL = colaborador.ESTADOCIVIL,
            //    SEXO = colaborador.SEXO,
            //    CPF = colaborador.CPF,
            //    PIS = colaborador.PIS,
            //    RG = colaborador.PIS,
            //    AGENCIA = colaborador.AGENCIA,
            //    BANCO = colaborador.BANCO,
            //    CONTA = colaborador.CONTA,
            //    OBS = colaborador.OBS,
            //    TITULOELEITOR = colaborador.TITULOELEITOR,
            //    ZONA = colaborador.ZONA,
            //    SECAO = colaborador.SECAO,
            //    CTPS = colaborador.CTPS,
            //    RESCISAO = colaborador.RESCISAO
            //});

        }
    }
}
