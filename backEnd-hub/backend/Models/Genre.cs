using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Server.Circuits;

namespace backend.Models
{
    public class Genre
    {

        [Key]
        public int genre_id { get; set; }
        [Required]
        [MaxLength(100)]
        public string name { get; set; } = string.Empty; // No-nullable, inicializado

        public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>(); // No-nullable, inicializado
        public virtual ICollection<Series> Series { get; set; } = new List<Series>(); // No-nullable, inicializado
    }

}