using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace MyFirstAzureWebAppSnyder.Models
{
    public class Contact
    {
    // EF Core will configure the database to generate this value
    [Key]
    [Column("id")]
    public int ContactId { get; set; }

    [Required(ErrorMessage = "Please enter a name.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter a phone number.")]
    
    public string Phone { get; set; }

    [Required(ErrorMessage = "Please enter an address.")]

    public string Address { get; set; }

    public string Slug =>
        Name?.Replace(' ', '-').ToLower() + '-' + Address?.ToString();
    }
}