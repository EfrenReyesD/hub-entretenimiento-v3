using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace backend.Models
{
    public class User
    {
        [Key]
        public int user_id {get; set;}
        [Required]
        [MaxLength(100)]
        public string username {get; set;} = string.Empty;// Inicializado
        [Required]
        [EmailAddress]
        public string email {get; set;} = string.Empty; 
        [Required]
        public string password {get; set;} = string.Empty;    
        public string? perfilUrl {get; set;}         

        public virtual ICollection<Favorite> Favorites {get; set;} = new HashSet<Favorite>(); //inicializado, No nullable

    }
}