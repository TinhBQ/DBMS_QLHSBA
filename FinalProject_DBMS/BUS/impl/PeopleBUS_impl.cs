using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BUS.impl
{
    public class PeopleBUS_impl
    {
        private QLHSBAEntities db = new QLHSBAEntities();
        public void Create(Person obj)
        {
            if (obj.GetType().Equals(typeof(Person)))
            {
                Person newPerson = (Person)obj;
                db.People.Add(newPerson);
                db.SaveChanges();
            }
        }

        public void Delete(Person obj)
        {
            if (obj.GetType().Equals(typeof(Person)))
            {
                Person person = (Person)obj;
                db.People.Remove(person);
                db.SaveChanges();
            }
        }

        public List<Person> getAll()
        {
            List<Person> people = db.People.ToList();
            return people;
        }

        public Person getById(string id)
        {
            Person person = db.People.Where(p => p.peopleID.Equals(id)).FirstOrDefault();
            return person;
        }

        public Person getByName(string name)
        {
            Person person = db.People.Where(p => p.lastName.Equals(name)).FirstOrDefault();
            return person;
        }

        public List<Person> Search(Person person)
        {
            List<Person> findings = db.People.Where(p => p.firstName.Contains(person.firstName)
                                                    || p.lastName.Contains(person.lastName)
                                                    || p.sex.Equals(person.sex)
                                                    || p.birthDay == person.birthDay
                                                    || p.address.Equals(person.address)
                                                    || p.phone.Equals(person.phone))
                                    .ToList();
            return findings;
        }

        public void Update(Person obj)
        {
            if (obj.GetType().Equals(typeof(Person)))
            {
                Person newPerson = (Person)obj;
                db.People.AddOrUpdate(newPerson);
                db.SaveChanges();
            }
        }
    }
}
