using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.SQL;
using TechnicalTest.SQL.Models;
using ExtendedNumerics;
using Microsoft.EntityFrameworkCore;

namespace TechnicalTest.SQL
{
    public class DataSQL
    {

        public static List<Drinks> GetDrinks()
        {
            using (TechnicalTestContext ctx = new TechnicalTestContext())

            {
                return ctx.Drinks.OrderBy(c => c.Name).ToList();
            }

        }
        public static List<Instructions> GetInstructions(int drinkId)
        {
            using (TechnicalTestContext ctx = new TechnicalTestContext())

            {
                return ctx.Instructions.Where(i => i.DrinkId == drinkId).OrderBy(c => c.InstructionOrder).ToList();
            }

        }
        public static string GetDrinkNameById(int drinkId)
        {
            using (TechnicalTestContext ctx = new TechnicalTestContext())

            {
                return ctx.Drinks.Where(i => i.DrinkId == drinkId).Select(d => d.Name).First();
            }

        }
    }
}
