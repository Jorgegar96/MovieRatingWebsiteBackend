using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MovieRatingBackend.Models
{
    public partial class Watchlist
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("imdbID")]
        [StringLength(100)]
        public string ImdbId { get; set; }
        [Column("userID")]
        [StringLength(100)]
        public string UserId { get; set; }
        [Column("poster")]
        [StringLength(500)]
        public string Poster { get; set; }
        [Column("title")]
        [StringLength(1000)]
        public string Title { get; set; }
        [Column("eventdate")]
        [StringLength(100)]
        public string Eventdate { get; set; }
    }
}
