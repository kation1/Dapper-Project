using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Dapper_Project.Models
{
    public class CookieInfo
    {
        public string Username { get; set; }
        public List<int> AnsID { get; set; }
        public List<int> Vote { get; set; }

        // username&15|-1&25|0&5|-1&56|1  This is the format of the cookie

        public static void BakeCookie(string username)
        {
            //HttpContext.Response.Cookies.Append("username", username);
        }


        public static CookieInfo CookieMonster(string cookie)
        {
            string[] ingredients = cookie.Split('&');
            List<string> stuff = new List<string>();

            for (int i = 1; i < ingredients.Length; i++)
            {
                stuff.Add(ingredients[i]);
            }

            CookieInfo returnstuff = new CookieInfo()
            {
                Username = ingredients[0],
                AnsID = new List<int>(),
                Vote = new List<int>()
            };

            foreach (string thing in stuff)
            {
                string[] cat = thing.Split('|');
                returnstuff.AnsID.Add(int.Parse(cat[0]));
                returnstuff.Vote.Add(int.Parse(cat[1]));
            }

            return returnstuff;
        }



    }
}
