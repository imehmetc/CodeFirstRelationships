using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelationships.Entities
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>(); // ya buraya yazılır ya da class'ın içinde "= new List<Department>();" şeklinde yazılır. // Veritabanında M-N türünden yeni bir tablo oluşturulması için her iki tarafa da List<T> tipinde navigation prop eklenir
    }
}
