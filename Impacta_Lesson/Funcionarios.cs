using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta_Lesson
{
    [BsonIgnoreExtraElements]
    public class Funcionarios
    {
        
        public Funcionarios()
        {
            Key = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsActive = true;
        }   

            
        public string Key { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Documents { get; set; }
        public string Ocupation { get; set; }
    }
}
