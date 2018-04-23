using DoorsExport.Data.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorsExport.UI
{
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();
            atualizarGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var col = new ColaboradorBusiness().Get(113);
            //var fabiano = new ColaboradorBusiness().Get(113,5375);

            //var cargos = new CargoBusiness().Get();
            //var cbos = new CboBusiness().Get();
            //var locais = new LocalDeTrabalhoBusiness().Get(113);
            //var sindicatos = new SindicatoBusiness().Get();

            var numero = int.Parse(numericUpDown1.Value.ToString());
            new EmpresaBusiness().Savelocal(numero);

            atualizarGridView();
            numericUpDown1.Value = 0;

        }

        void atualizarGridView()
        {
            using (var empBuss = new EmpresaBusiness())
            {
                dataGridView1.DataSource = empBuss.GetLocal();
            }
        }
    }
}
