using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Episode
    {
        [Key]
        public int episode_id { get; set; }
        [Required]
        public int series_id { get; set; }
        [Required]
        [MaxLength(200)]
        public string title { get; set; } = string.Empty; // No-nullable, inicializado
        public string? description { get; set; } // Nullable
        public DateTime releaseDate { get; set; }
        [Required]
        public int episode_number { get; set; }
        public string? poster_url { get; set; } // Nullable
        public string? video_url { get; set; } // Nullable

        [ForeignKey("series_id")]
        public virtual Series Series { get; set; } = null!; // No-nullable, inicializado con null-forgiving operator
    }

}