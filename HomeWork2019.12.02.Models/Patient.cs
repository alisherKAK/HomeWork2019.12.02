using HomeWork2019._12._02.AbstractModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWork2019._12._02.Models
{
    public class Patient : IEntity
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }
        [Key]
        [Column(Order = 2)]
        public string Iin { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Disease> Diseases { get; set; }

        public Patient()
        {
            Diseases = new List<Disease>();
        }
    }
}
