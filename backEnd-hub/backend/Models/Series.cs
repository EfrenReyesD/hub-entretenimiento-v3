using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Series
    {
        [Key]
        public int series_id { get; set; }
        [Required]
        [MaxLength(200)]
        public string title { get; set; } = string.Empty; // No-nullable, inicializado
        public string? description { get; set; } // Nullable
        public DateTime release_date { get; set; }
        public string? poster_url { get; set; } // Nullable
        public string? video_url { get; set; } // Nullable
        [Required]
        public int genre_id { get; set; }
        [ForeignKey("genre_id")]

        public Genre Genre { get; set; } = null!; // No-nullable, inicializado con null-forgiving operator
        public virtual ICollection<Episode> Episodes { get; set; } = new HashSet<Episode>(); // No-nullable, inicializado
        public virtual ICollection<Favorite> Favorites { get; set; } = new HashSet<Favorite>(); // No-nullable, inicializado
    }

}
