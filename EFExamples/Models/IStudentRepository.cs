using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFExamples.Models
{
    public interface IStudentRepository 
    {
        IEnumerable<Student> Students { get; set; }
    }
} 