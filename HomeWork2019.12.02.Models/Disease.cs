using HomeWork2019._12._02.AbstractModels;
using System;

namespace HomeWork2019._12._02.Models
{
    public class Disease : IEntity
    {
        public int Id { get; set; }
        public string Specialist { get; set; }
        public string SpecialistFullName { get; set; }
        public string Diagnosis { get; set; }
        public string Complaints { get; set; }
        public DateTime VisitDate { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
