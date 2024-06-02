using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace GiovanniTutorial.Entity
{
    public class AlunnoEntity
    {
        /*
        public AlunnoEntity()
        {
            
        }
        public AlunnoEntity(string name, string lastName, string anno, string classe)
        {
            Id = Id;
            Name = name;
            LastName = lastName;
            Anno = anno;
            Classe = classe;
        }*/

		
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Anno { get; set; } = string.Empty;
        public ClasseEntity? Classe { get; set; }
    }
}
