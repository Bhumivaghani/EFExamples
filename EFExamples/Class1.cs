using System;
using System.Collections.Generic;
/// <summary>
/// Summary description for Class1
/// </summary>
namespace EFExamples
{
    class Patient
    {
        public Patient()
        {
            Visits = new List<Visit>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public AnimalType AnimalType { get; set; }
        public DateTime FirstVisit { get; set; }
        public List<Visit> Visits { get; set; }
    }
    class Visit
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public String ReasonForVisit { get; set; }
        public String Outcome { get; set; }
        public Decimal Weight { get; set; }
        public int PatientId { get; set; }
    }
    class AnimalType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
    }
}
