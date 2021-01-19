using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Aluno
    {
        public Aluno() { }
        public Aluno(int id, string name, string lastName, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.Phone = phone;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
       public IEnumerable<AlunoDiciplina> AlunoDiciplina { get; set; }


    }
}