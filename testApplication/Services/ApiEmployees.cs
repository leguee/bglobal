using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using testApplication.Models;

namespace testApplication.Services
{
    public class ApiEmployees
    {

        /// <summary>
        /// Obtiene los employee devuelto de la api
        /// </summary>
        /// <returns></returns>
        public async Task<List<Employee>> GetEmployees()
        {
            List<Employee> list = new List<Employee>();

            try
            {
                HttpClient httpClient = new HttpClient();
                List<Employee> employees = new List<Employee>();

                var response = await httpClient.GetAsync("http://dummy.restapiexample.com/api/v1/employees");

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    employees = JsonConvert.DeserializeObject<List<Employee>>(result);
                    list = employees;
                }

            }
            catch (Exception e)
            {
                throw new Exception("Ha ocurrido un problema al intentar obtener las personas");
            }

            return list;
        }
    }
}
