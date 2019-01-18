using MASGlobal.Domain.DTO;
using RestSharp;
using System.Collections.Generic;
using System.Configuration;

namespace MASGlobal.Services
{
    public class EmployeeRepository
    {
        public List<EmployeeDTO> GetEmployees(int id = 0)
        {
            string urlWebAPI = ConfigurationManager.AppSettings["InternalMASGlobalWebAPI"];
            string resource = ConfigurationManager.AppSettings["InternalResource"];

            var client = new RestClient(urlWebAPI);
            var request = new RestRequest(resource, Method.GET);

            if (id != 0)
            {
                resource = ConfigurationManager.AppSettings["InternalResourceId"];

                request.Resource = resource;
                request.AddParameter("id", id);
            }

            var response = client.Execute<List<EmployeeDTO>>(request).Data;

            return (List<EmployeeDTO>)response;
        }
    }
}