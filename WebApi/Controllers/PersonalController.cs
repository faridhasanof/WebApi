using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class PersonalController : ApiController
    {
        public List<Personal> GetPersonals()
        {
            return PersonalList.pers;
        }
        public Personal GetPersonal(int id)
        {
            Personal ischi = PersonalList.pers.Find(o => o.id == id);
            return ischi;
        }
    }
}
