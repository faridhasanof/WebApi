using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi
{
    public class PersonalList
    {
        public static List<Personal> pers = new List<Personal>
        {
            new Personal
            {
                id=1000,
                name="Ibo",
                surname="Seyfo",
                birth_place="Salyan",
                age=20,
                salary=1500
            },
             new Personal
            {
                id=1001,
                name="Kenan",
                surname="Hesenov",
                birth_place="Goycay",
                age=20,
                salary=1800
            },
              new Personal
            {
                id=1002,
                name="Banu",
                surname="Xuduyeva",
                birth_place="Fuzuli",
                age=20,
                salary=2000
            }
        };-
    }
}