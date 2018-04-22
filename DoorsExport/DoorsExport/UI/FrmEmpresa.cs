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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var numero = int.Parse(numericUpDown1.Value.ToString());
            var result = new EmpresaBusiness().Get(numero);
        }

        void atualizarGridView()
        {
            using (var empBuss = new EmpresaBusiness())
            {
                dataGridView1.DataSource = empBuss.GetLocalAll();
            }
        }
    }
}
