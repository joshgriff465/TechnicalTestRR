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
    public class Instructions
    {
        [Key]
        public int InstructionId { get; set; }
        public int DrinkId { get; set; }
        public string InstructionDetails { get; set; }
        public int InstructionOrder { get; set; }
        public string InstructionImage { get; set; }



    }
}
