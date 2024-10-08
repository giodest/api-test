﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace esercizio1api.Entity
{
    public class AlunnoEntity
    {
        		
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Anno { get; set; } = string.Empty;              
        public string? ClasseId { get; set; }
        public ClasseEntity? ClasseEntity { get; set; } 
    }
}
