using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MySqlEntityF_COdeFirst.Models
{
    public class Audit
    {
        [Key]
        public Guid Id { get; set; }
        public string ChangeType { get; set; }
        public string ObjectType { get; set; }
        public string FromJson { get; set; }
        public string ToJson { get; set; }
        public DateTime DateCreated { get; set; }
        public string TableName { get; set; }
        public string IdentityJson { get; set; }
      
    }
}