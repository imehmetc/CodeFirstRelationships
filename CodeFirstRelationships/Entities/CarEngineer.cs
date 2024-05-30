using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelationships.Entities
{
    public class CarEngineer // Cross table 
    {
        // Default Convention'da Cross Table entity'si açmasakta olur.
        public int Id { get; set; } // Eğer composite key verirsek aynı kişi aynı arabada daha sonra birdaha çalışamaz. Ancak bu tabloya Id tanımlarsak tekrar çalışabilir.
        public int CarId { get; set; } // Foreign Key
        public int EngineerId { get; set; } // Foreign Key
        public int NumberOfDays { get; set; }

        // Many to Many.
        public Car Cars { get; set; } // Navigation Property
        public Engineer Engineers { get; set; } // Navigation Property

        /*
                                                                  M-N İçin Yapılacaklar

           * Many to Many tipinde sınıf açılır. (Bu örnekte CarEngineer entity'si)
           * Primary key ekledik. (Eklemeden diğer foreign key'lerle composite key de yapılabilir.) (Sonra)
           * İçerisine, ilişkide olan sınıflar cinsinden foreign key ve navigation proplar eklenir (tekil).
           * Many to Many'nin ilişkide oldugu bütün sınıflara, yukarıda oluşturduğumuz many to many tipinde liste eklenir (navigation prop). Bu örnek için Car Entity'sindeki => public List<CarEngineer> CarEngineers { get; set; } ve Engineer Entity'sindeki => public List<CarEngineer> CarEngineers { get; set; }
           * Son olarak Context Sınıfına DbSet'ler tanımlanmalıdır.
        

        */
    }
}
