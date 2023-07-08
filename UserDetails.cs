using APIBDDProject.Entities;
using APIBDDProject.Helper;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBDDProject
{
    public class UserDetails
    {
        public object? FirstName { get; internal set; }

        public ListUser GetUser()
        {
            var restClient = new RestClient("https://reqres.in/api");
            var restRequest = new RestRequest("/users?page=2", Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat=DataFormat.Json;
            IRestResponse response = (IRestResponse)restClient.Execute(restRequest);
            
            var content = response.Content;
            var users=JsonConvert.DeserializeObject<ListUser>(content);
            return users;
        }
    }
}
