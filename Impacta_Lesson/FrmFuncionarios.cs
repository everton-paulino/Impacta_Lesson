using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impacta_Lesson
{
    public partial class FrmFuncionarios : Form
    {
        private Funcionarios _funcionario = new Funcionarios();
        private Operacao _operacao = new Operacao();
        public FrmFuncionarios( string key, Operacao operacao )
        {
            InitializeComponent();

            _funcionario.Key = key;
            _operacao = operacao;

            Despachante();
        }

        private void Despachante()
        {
            if (_operacao == Operacao.Adicionar)
            {
                
            }
        }
    }
}
