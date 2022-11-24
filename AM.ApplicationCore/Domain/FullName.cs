using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class FullName
    {
        [MinLength(3, ErrorMessage = "saisire ou moins 3 caractére")]
        [MaxLength(25, ErrorMessage = "saisire ou maximum 25 caractére")]

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
