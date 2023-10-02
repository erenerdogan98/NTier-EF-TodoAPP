using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Entities
{
    public class TodoLibrary
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("TITLE")]
        public string Title { get; set; }
        [DisplayName("Short Description")]
        public string BriefDescription { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Status")]
        public string StatusDescription { get; set; }
        [DisplayName("Importance")]
        public int Importance { get; set; }
        public DateTime Creationdate { get; set; }
        public int UserID { get; set; } // User sınıfındaki ID'ye referans verir.
        public virtual User User { get; set; }
    }
}
