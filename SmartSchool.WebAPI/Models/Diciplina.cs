using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Diciplina
    {
        public Diciplina() {}
        public Diciplina(int id, string name, int professorId) 
        {
            this.Id = id;
                this.Name = name;
                this.ProfessorId = professorId;
               
        }
                public int Id { get; set; }
        public string Name { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; } 
        public IEnumerable<AlunoDiciplina> AlunoDiciplina { get; set; }
        
        
    }
}