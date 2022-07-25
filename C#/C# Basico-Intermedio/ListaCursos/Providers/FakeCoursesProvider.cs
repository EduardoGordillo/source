using ListaCursos.Interfaces;
using ListaCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaCursos.Providers
{
    public class FakeCoursesProvider : Interfaces.ICoursesProvider
    {
        private readonly List<Course> repo = new List<Course>();

        public FakeCoursesProvider()
        {
            repo.Add(new Course()
            {
                Id = 1,
                Name ="Porque el aburrimiento es bueno",
                Author = "Verisatium",
                Description = "Como el aburrimiento ayuda a que seas mejor",
                Uri = "https://www.youtube.com/watch?v=zaclMkLXZMw",

            });
            repo.Add(new Course()
            {
                Id = 2,
                Name = "hola",
                Author = "Verisatium",
                Description = "Como el aburrimiento ayuda a que seas mejor",
                Uri = "https://www.youtube.com/watch?v=E-zHtpLf4mE",
            });

        }

        public Task<(bool IsSucess, int? id)> AddAsync(Course course)
        {
            course.Id = repo.Max(c => c.Id) + 1;
            
            repo.Add(course);
            return Task.FromResult((true, (int?)course.Id));
        }

        public Task<ICollection<Course>> GetAllAsync()
        {
            return Task.FromResult((ICollection < Course >) repo.ToList());
        }

        public Task<Course> GetAsync(int id)
        {
            return Task.FromResult(repo.FirstOrDefault(c => c.Id== id));
        }

        public Task<ICollection<Course>> SearchAsync(string search)
        {
            return Task.FromResult((ICollection<Course>)repo.Where(c => c.Name.ToLowerInvariant().Contains(search.ToLowerInvariant())).ToList());

        }

        public Task<bool> UpdateAsync(int id, Course course)
        {
            var courseToUpdate = repo.FirstOrDefault(c => c.Id == id);
            if(courseToUpdate != null)
            {
                courseToUpdate.Name = course.Name;
                courseToUpdate.Description = course.Description;
                courseToUpdate.Author = course.Author;
                courseToUpdate.Uri = course.Uri;
                return Task.FromResult(true);
            }
           return Task.FromResult(false);
        }
    }
}
