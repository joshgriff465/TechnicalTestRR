using ExtendedNumerics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest.SQL.Models
{
    public class Drinks
    {
        [Key]
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public string ImageLink { get; set; }
        public bool Availability { get; set; }


    }

}
