using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MovieRatingBackend.Models
{
    public partial class Comment
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
        [Column("username")]
        [StringLength(100)]
        public string Username { get; set; }
        [Column("comment")]
        [StringLength(1000)]
        public string Comment1 { get; set; }
        [Column("eventdate")]
        [StringLength(100)]
        public string Eventdate { get; set; }
    }
}
