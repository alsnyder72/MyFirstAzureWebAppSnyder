using System.ComponentModel.DataAnnotations;

namespace MyFirstAzureWebAppSnyder.Models
{
    public class Genre
    {
        public string GenreId { get; set; }

        [Required(ErrorMessage = "Please enter a genre.")]
        public string Name { get; set; }
    }

}
