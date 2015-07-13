using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFTestWebService
{
    /// <summary>
    /// Webservice Interface for person operations
    /// </summary>
    [ServiceContract]
    public interface IServicePerson
    {

        [OperationContract]
        void AddPerson(Person person);

        [OperationContract]
        void RemovePerson(Person person);

        [OperationContract]
        IList<Person> GetPersonList();

    }
}