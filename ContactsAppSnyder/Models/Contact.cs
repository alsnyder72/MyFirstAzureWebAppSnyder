using System.ComponentModel.DataAnnotations;

namespace ContactsAppSnyder.Models
{
    public class Contact
    {
        //EF will instruct the database to automatically generate this value
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter an name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a o=phone number.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter an address.")]
        public string? Address { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Address?.Replace(' ','-').ToLower().ToString();
    }
}
