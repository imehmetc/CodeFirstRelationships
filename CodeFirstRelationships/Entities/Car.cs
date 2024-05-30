using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelationships.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }

        // One to One
        public int? LicensePlateId { get; set; } // Bu property Foreign Key olarak işaretlenecek. Entity Framework, Foreign Key olacağını şöyle anlar: Önce ilişkili olacağı Class adı sonra da Id kelimesi => <ClassNameId>

        // Foreign Key ekledikten sonra ayrıca ilişkide bulunduğu sınıf türünde bir de "Navigation Property" yazılır
        // Navigation Property: Sınıflar arası geçişi sağlayan özelliklerdir.

        // Foreign Key ataması için (eklerken veya güncellerken) sadece Foreign Key olan özelliğe atama yapsak yeterli olur.

        public LicensePlate LicensePlate { get; set; } // Navigation Property. Bunu yazmamızın amacı Car.LicensePlate dendiğinde direk olarak o sınıfın özelliklerine ulaşabiliyoruz. Car class'ındaki ve LicesePlate class'ındaki Navigation Propertyler tekil olduğundan (List<> tipinde olmadığından) bunun UNIQUE olması gerektiğini anlar ve veritabanı kısmında UNIQUE KEY olarak işaretler. Böylelikle 1-1 bir ilişki oluşmuş olur.

        /*
                                                                 1-1 İçin Yapılacaklar

            * Foreign Key olacak olan sınıfa karşı taraf <ClassNameId> ismiyle Foreign Key Property'si eklenir(Car sınıfındaki => public int LicensePlateId { get; set; }) ve yine karşı taraf cinsinden Navigation Property eklenir (Car sınıfındaki => public LicensePlate LicensePlate { get; set; }).
            * 1-1 olduğu için Navigation Property tekildir. (List tipinde değildir.)
            * Daha sonra karşı sınıfa ise sadece yine zıt taraf cinsinden bir Navigation Property eklenir. (LicensePlate sınıfındaki => public Car Car { get; set; })
            * Son olarak Context Sınıfına DbSet'ler tanımlanmalıdır.
         
         */


        // One to Many

        public int? PersonId { get; set; } // Foreign Key
        public Person Person { get; set; } // Navigation Property. Bir arabanın tek bir sahibi olabileceğinden tekil tanımladık.

        /*
                                                                   1-M İçin Yapılacaklar

            * Foreign Key eklenecek sınıfa foreign key eklenir(Default Convension'da <ClassNameId>). Bu örnekte Car Entity'sindeki => public int? PersonId { get; set; } ve yine Navigation Property eklenir Bu örnekte Car Entity'sindeki => public Person Person { get; set; } (Tekil). Her arabanın bir tane sahibi olacağından Car entity'sindeki Person navigation property'si tekil olarak oluşturulur.
            * Karşı tarafa da (Foreign Key olmayan) sadece karşı taraf cinsinden Navigation Property eklenir. Bu örnekte Person Entity'sindeki => public List<Car> Cars { get; set; } (Liste). Bir kişinin birden fazla arabası olabileceğinden Person entitysinde Car navigation property'si ICollection veya Liste tipinde oluşturulur.
            * Son olarak Context Sınıfına DbSet'ler tanımlanmalıdır.
         
         
         */

        // Many to Many
        public List<CarEngineer> CarEngineers { get; set; }

        public override string ToString()
        {
            return Id + ": " + Brand + " " + Color;
        }


    }
}
