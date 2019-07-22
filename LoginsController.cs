using CRUDINWEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUDINWEBAPI.Controllers
{
    public class LoginsController : ApiController
    {
        angularEntities OE = new angularEntities();
        public IQueryable<login> Get()
        {
            return OE.logins; // @@@@AFTER THIS METHOD ADD REFERENCE
        }
        //....api/Departments/1
        public login Get(int id)
        {
            login login = OE.logins.Find(id);
            return login;
        }

        //....api/Departments/1
        public void Put(int id, login log)
        {
            OE.Entry(log).State = EntityState.Modified;
            OE.SaveChanges();
        }

        //....api/Departments/1
        public void Delete(int id)
        {
            login log = OE.logins.Find(id);
            OE.logins.Remove(log);
            OE.SaveChanges();
        }

        //....api/Departments/
        public void Post(login log)
        {
            OE.logins.Add(log);
            OE.SaveChanges();
        }

    }
}
