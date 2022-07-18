using System.Collections.Generic;
using TechnicalTest.SQL.Models;

namespace TechnicalTest.Models
{
    public class HomeModel
    {
        public List<Drinks> drinkList { get; set; }

        public List<Instructions> instructionList { get; set; }
    }
}