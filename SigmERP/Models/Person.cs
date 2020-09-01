using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SigmERP.Models
{
    public class Person
    {
        [Display(Name = "Код")]
        public string Id { get; set; }
        [Display(Name = "ФИО")]
        public string Name { get; set; }
        [Display(Name = "ИНН")]
        public string TaxNumber { get; set; }
        [Display(Name = "СНИЛС")]
        public string SocNumber { get; set; }
        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateBirth { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Вид документа")]
        public string TypeDocument { get; set; }
        [Display(Name = "Серия")]
        public string SeriesDoc { get; set; }
        [Display(Name = "Номер")]
        public string NumDoc { get; set; }
        [Display(Name = "Дата выдачи")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateDoc { get; set; }
        [Display(Name = "Кем выдан")]
        public string Authority { get; set; }
        [Display(Name = "Код подразделения")]
        public string AuthorityCode { get; set; }
        [Display(Name = "Пол")]
        public string Sex { get; set; }
        public string Email { get; set; }
        [Display(Name = "Телефон")]
        public string Phone { get; set; }
        [Display(Name = "Место рождения")]
        public string BirthPlace { get; set; }

    }
}
