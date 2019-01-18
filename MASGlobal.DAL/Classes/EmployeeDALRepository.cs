using MASGlobal.Domain.Base;
using MASGlobal.Domain.Interface;
using RestSharp;
using System.Collections.Generic;
using System.Configuration;

namespace MASGlobal.DAL.Classes
{
    public class EmployeeDALRepository : IEmployeeDALRepository
    {
        public List<Employee> GetEmployees()
        {
            string urlWebAPI = ConfigurationManager.AppSettings["ExternalMASGlobalWebAPI"];
            string resource = ConfigurationManager.AppSettings["ExternalResource"];

            var client = new RestClient(urlWebAPI);
            var request = new RestRequest(resource, Method.GET);

            var response = client.Execute<List<Employee>>(request).Data;

            return (List<Employee>)response;
        }
    }
}
