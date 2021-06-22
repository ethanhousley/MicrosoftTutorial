using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MicrosoftTutorial.Models
{
    public class Person
    {
        [Key]
        public int UserID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

       
    }
}
