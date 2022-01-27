using ListaCursos.Interfaces;
using ListaCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ListaCursos.Providers
{
    public class WebApiCoursesProvider : ICoursesProvider
    {
        private readonly IHttpClientFactory httpClientFactory;

        public WebApiCoursesProvider(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public Task<(bool IsSucess, int? id)> AddAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public async  Task<ICollection<Course>> GetAllAsync()
        {
            var client =  httpClientFactory.CreateClient("coursesService") ;
            var response = await client.GetAsync("api/courses");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
               
               var results = JsonSerializer.Deserialize<ICollection<Course>> (  content,
                   new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                return results;
            }
            return null;
        }


        public  Task<Course> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Course>> SearchAsync(string search)
        {
            var client = httpClientFactory.CreateClient("coursesService");
            var response = await client.GetAsync("api/courses");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                var results = JsonSerializer.Deserialize<ICollection<Course>>(content,
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                return results;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(int id, Course course)
        {
            var client = httpClientFactory.CreateClient("coursesService");
            var body = new StringContent(JsonSerializer.Serialize(course));
            var response = await client.PutAsync("api/courses/{id}",
                                                 body);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                var results = JsonSerializer.Deserialize<ICollection<Course>>(content,
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                return true;
            }
            return false ;
        }
    }
}
