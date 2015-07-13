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
    /// Webservice for Math Services
    /// </summary>
    public class ServiceAddition : IServiceAddition
    {

        public int Addition(int value1, int value2)
        {
            MathService mathService = new MathService();
            return mathService.Addition(value1, value2);
        }
    }
}
