using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelationships.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Car> Cars { get; set; } // Navigation Property. Bir insanın birden fazla arabası olabileceğinden koleksiyon tipinde tanımladık.

        public override string ToString()
        {
            return Id + ": " + FirstName + " " + LastName;
        }

    }
}
