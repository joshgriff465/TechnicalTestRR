using System.Collections.Generic;
using TechnicalTest.SQL.Models;

namespace TechnicalTest.Models
{
    public class HomeModel
    {
        public List<Drinks> availableDrinkList { get; set; }
        public List<Drinks> unavailableDrinkList { get; set; }


        public List<Instructions> instructionList { get; set; }
    }
}