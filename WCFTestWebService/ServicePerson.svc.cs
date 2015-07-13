using Business;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFTestWebService
{
    /// <summary>
    /// Webservice for Person operations
    /// </summary>
    public class ServicePerson : IServicePerson
    {

        PersonService personService = new PersonService();

        public void AddPerson(Person person)
        {
            personService.Save(person);                    
        }

        public void RemovePerson(Person person)
        {
            personService.deletePerson(person);
        }

        public IList<Person> GetPersonList()
        {
            return personService.ReadAllPersons();
        }
    }
}
