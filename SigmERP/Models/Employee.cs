using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SigmERP.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string PersonId { get; set; }
        [Display(Name = "Дата приема")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Display(Name = "Дата увольнения")]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }
        public string WorkplaceId { get; set; }
        public string Rate { get; set; }

        public Person Person { get; set; }

    }
}
