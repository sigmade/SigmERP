using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SigmERP.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string PersonId { get; set; }

        [Display(Name = "Дата приема")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Дата увольнения")]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }

        [Display(Name = "Место работы")]
        public string WorkplaceId { get; set; }

        [Display(Name = "Ставка")]
        public string Rate { get; set; }

        [Display(Name = "Сотрудник")]
        public Person Person { get; set; }
        public Workplace Workplace { get; set; }

        // public ICollection<Workplace> Workplace { get; set; }

    }
}
