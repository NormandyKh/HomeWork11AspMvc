using System.ComponentModel.DataAnnotations;

namespace HomeWork11AspMvc.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? NoteText { get; set; }

        [Required]
        public DateTime CreatedAt { get; set;}

        public string? Tag { get; set; }
    }
}
