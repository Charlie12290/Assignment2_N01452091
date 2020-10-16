using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01452091.Controllers
{
    public class J1Controller : ApiController
    {/// <summary>
     /// Customer choose the meal options, calculate total calories.
     /// </summary>
     /// <param name="burger">Burger options and corresponding calories value</param>
     /// <param name="drink">Drink options and corresponding calories value</param>
     /// <param name="side">Side options and corresponding calories value</param>
     /// <param name="dessert">Dessert options and corresponding calories value</param>
     /// <returns>Total meal calories</returns>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int bcal = 0; int drcal = 0; int scal = 0; int dscal = 0;

            if (burger == 1)
            {
                bcal = 461;
            }
            else if (burger == 2)
            {
                bcal = 431;
            }
            else if (burger == 3)
            {
                bcal = 420;
            }
            else if (burger == 4)
            {
                bcal = 0;
            }

            if (drink == 1)
            {
                drcal = 130;
            }
            else if (drink == 2)
            {
                drcal = 160;
            }
            else if (drink == 3)
            {
                drcal = 118;
            }
            else if (drink == 4)
            {
                drcal = 0;
            }

            if (side == 1)
            {
                scal = 100;
            }
            else if (side == 2)
            {
                scal = 57;
            }
            else if (side == 3)
            {
                scal = 70;
            }
            else if (side == 4)
            {
                scal = 0;
            }

            if (dessert == 1)
            {
                dscal = 167;
            }
            else if (dessert == 2)
            {
                dscal = 266;
            }
            else if (dessert == 3)
            {
                dscal = 75;
            }
            else if (dessert == 4)
            {
                dscal = 0;
            }
            //Total meal calories value
            int total = bcal + drcal + scal + dscal;
            //Message to customer
            string response = "Your total calorie count is " + total;
            return response;
        }
    }
}
