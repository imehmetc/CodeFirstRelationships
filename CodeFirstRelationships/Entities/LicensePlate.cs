using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelationships.Entities
{
    public class LicensePlate // Araba Plakası
    {
        public int Id { get; set; } // Id yazıldığında bu kolonun Primary Key olduğunu ve Identity(1,1) olduğunu kendisi belirler. Buna Convention(Gelenek) denir. Eğer geleneklerden farklı bir isim verilmek istenirse ozaman data annotation veya fluent API ile konfigürasyon yapmamız gereklidir.
        public string Number { get; set; }

        public Car Car { get; set; } // Bu sınıftan'da Car sınıfına ulaşmak için sadece Navigation Property'si yazılır.

        public override string ToString()
        {
            return Id + ": " + Number;
        }
    }
}
