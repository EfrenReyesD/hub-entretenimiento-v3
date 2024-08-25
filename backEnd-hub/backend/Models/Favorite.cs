using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Favorite
    {
        [Key]
        public int favorite_id { get; set; }

        [Required]
        public int user_id { get; set; }
        public int? movie_id { get; set; } // Nullable, ya que puede estar asociado a una serie
        public int? series_id { get; set; } // Nullable, ya que puede estar asociado a una película

        [ForeignKey("user_id")]
        public User User { get; set; } = null!; // No-nullable, inicializado con null-forgiving operator
        [ForeignKey("movie_id")]
        public Movie? Movie { get; set; } // Nullable, porque puede no estar asociado a una película
        [ForeignKey("series_id")]
        public Series? Series { get; set; } // Nullable, porque puede no estar asociado a una serie
    }

}