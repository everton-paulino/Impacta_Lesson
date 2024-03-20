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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var funcionarios = new Funcionario();
            funcionarios.Name = "Francisco da Silva";
            funcionarios.Documents = "23434567898";
            funcionarios.Ocupation = "Ajudante Geral";

            var cli = new MongoClient(Conn.Server);
            var db = cli.GetDatabase(Conn.Db);
            var collectionFuncionarios = db.GetCollection<Funcionario>
                (Conn.collectionFuncionarios);

            collectionFuncionarios.InsertOne(funcionarios);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
