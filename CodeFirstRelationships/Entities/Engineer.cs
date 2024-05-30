using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelationships.Entities
{
    public class Engineer // Mühendis
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Many to Many
        public List<CarEngineer> CarEngineers { get; set; }

        public override string ToString()
        {
            return Id + ": " + FirstName + " " + LastName;
        }
    }
}
