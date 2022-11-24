using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }


        [DataType(DataType.DateTime)]
        [Display(Name ="Date of Birth")]

        public DateTime BirthDate { get; set; }
        [RegularExpression("@[1-9]{8}")]
        public string TelNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }
        public FullName FullName { get; set; }

        // public ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

        public override string ToString()
        {
            return "FirstName: " + FullName.FirstName + " LastName: " + FullName.LastName + " date of Birth: " + BirthDate;
        }
        //Le polymorphisme par signature
        //public bool CheckProfile(string firstName, string lastName)
        // {
        //     return FirstName==firstName && LastName==lastName;
        // }
        // public bool CheckProfile(string firstName, string lastName, string email)
        // {
        //     return FirstName==firstName && LastName==lastName && EmailAddress==email;
        // }
        public bool CheckProfile(string firstName, string lastName, string email = null)
        {
            if (email != null)
                return FullName.FirstName == firstName && FullName.LastName == lastName && EmailAddress == email;
            else
                return FullName.FirstName == firstName && FullName.LastName == lastName;
        }
        // Polymorphisme par héritge
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }
    }
}
