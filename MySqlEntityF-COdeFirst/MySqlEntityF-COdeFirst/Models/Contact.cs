using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MySqlEntityF_COdeFirst.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Mail { get; set; }
        [DataType(DataType.PhoneNumber)]
        [MinLength(11,ErrorMessage ="Telefon Numaranız 11 haneden az olmamalıdır."), MaxLength(11,ErrorMessage = "Telefon Numaranız 11 haneden az olmamalıdır.")]
        public string Phone { get; set; }
    }
}