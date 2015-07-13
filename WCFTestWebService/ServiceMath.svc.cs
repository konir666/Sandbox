﻿using Business;
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceAddition : IServiceAddition
    {

        public int Addition(int value1, int value2)
        {
            MathService mathService = new MathService();
            return mathService.Addition(value1, value2);
        }
    }
}
