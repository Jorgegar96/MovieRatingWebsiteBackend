using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MovieRatingBackend.Models
{
    public partial class Reaction
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
        [Column("reaction")]
        [StringLength(10)]
        public string Reaction1 { get; set; }
        [Column("eventdate")]
        [StringLength(100)]
        public string Eventdate { get; set; }
    }
}
