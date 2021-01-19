using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Professor
    {
        public Professor() { }

        public Professor(int id, string name)
        {
            this.Id = id;
            this.Name = name;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Diciplina> Diciplina { get; set; }
    }
}