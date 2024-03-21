using MongoDB.Driver;
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
    public partial class FrmListas : Form
    {
        public FrmListas()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmFuncionarios("", Operacao.Adicionar))
                frm.ShowDialog();
            
            var funcionarios = new Funcionarios();
            funcionarios.Name = "Francisco da Silva";
            funcionarios.Documents = "23434567898";
            funcionarios.Ocupation = "Ajudante Geral";

            var collectionFuncionarios = Conn.AbrirColecaoFuncionarios();

            collectionFuncionarios.InsertOne(funcionarios);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var collectionFuncionarios = Conn.AbrirColecaoFuncionarios();

            var listasFuncionarios = collectionFuncionarios.Find(p => true).ToList();

            dataGridView1.DataSource = listasFuncionarios;

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
