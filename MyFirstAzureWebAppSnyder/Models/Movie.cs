﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace MyFirstAzureWebAppSnyder.Models
{
    public class Movie
    {
        // EF Core will configure the database to generate this value
        [Key]
        [Column("id")]
        public int MovieId { get; set; }
        
        [Required(ErrorMessage = "Please enter a name.")] 
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1889, 2999, ErrorMessage = "Year must be after 1889.")] 
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a genre.")]
        public string GenreId { get; set; }
        public Genre? Genre { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")] 
        public int? Rating { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
    }
}
