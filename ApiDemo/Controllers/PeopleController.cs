using ApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiDemo.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people=new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Bahaa", LastName = "Shamoon", Id = 1 });
            people.Add(new Person { FirstName = "Fady", LastName = "Adel", Id = 2 });
            people.Add(new Person { FirstName = "Peter", LastName = "Ezzat", Id = 3 });
            
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        { 
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

     

        // DELETE: api/People/5
        public void Delete(int id)
        {
            
        }
    }
}
