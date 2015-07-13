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
    /// Webservice Interface for Math services
    /// </summary>
    [ServiceContract]
    public interface IServiceAddition
    {
        [OperationContract]
        int Addition(int value1, int value2);
    }
}
