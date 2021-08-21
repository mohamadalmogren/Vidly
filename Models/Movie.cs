﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Genres Genres { get; set; }
        [Required]
        [Display(Name="Genre")]
        public int GenresId { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        
        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }

    }
}