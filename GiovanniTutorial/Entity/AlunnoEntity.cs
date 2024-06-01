using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GiovanniTutorial.Entity
{
    public class Alunno
    {
        public Alunno()
        {
            
        }
        public Alunno(string name, string lastName)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            LastName = lastName;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }
        public string Name { get; set; } = string.Empty;
     

        public string LastName { get; set; } = string.Empty;
    }
}
