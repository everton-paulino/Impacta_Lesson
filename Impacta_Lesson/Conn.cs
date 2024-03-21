using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta_Lesson
{
    public class Conn
    {
        public static readonly string Server = "mongodb://localhost:27017";
        public static readonly string Db = "CertifiqueSe";
        public static readonly string collectionFuncionarios = "funcionarios";

        public static IMongoCollection<Funcionarios> AbrirColecaoFuncionarios()
        {
            var cli = new MongoClient(Server);
            var db = cli.GetDatabase(Db);
            return db.GetCollection<Funcionarios>(collectionFuncionarios);
        }
    }

    
}
