using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01452091.Controllers
{
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int w = 0;
            if (m > 0 && n > 0 && (m + n) < 10)
            {
                return "There are " + w + " ways to get the sum 10.";
            }
            else if (m < 10)
            {
                w = m;
                return "There are " + w + " ways to get the sum 10.";
            }
            else if (n < 10)
            {
                w = n;
                return "There are " + w + " ways to get the sum 10.";
            }
            else return "0";
        }
    }
}
