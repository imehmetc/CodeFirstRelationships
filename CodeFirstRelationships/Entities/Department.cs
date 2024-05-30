using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelationships.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Part> Parts { get; set; } = new List<Part>(); // Veritabanında M-N türünden yeni bir tablo oluşturulması için her iki tarafa da List<T> tipinde navigation prop eklenir
    }
}
