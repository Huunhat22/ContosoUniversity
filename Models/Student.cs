using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name="First Name")]
        [StringLength(50)]
        public string FristMidName { get; set; }

        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name ="Full Name")]
        [StringLength(50,MinimumLength =1)]
        public string FullName
        {
            get
            {
                return LastName + ", " + FristMidName;
            }
        }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
