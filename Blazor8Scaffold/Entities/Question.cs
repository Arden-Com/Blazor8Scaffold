using System.ComponentModel.DataAnnotations;

namespace Blazor8Scaffold.Entities
{
    public class Question
    {
        public int Id { get; set; }
        
        [StringLength(100)]
        public string Text { get; set; } = string.Empty;

        [StringLength(100)]
        public string Answer1 { get; set; } = string.Empty;
        public bool CorrectAnswer1 { get; set; } = false;

        [StringLength(100)]
        public string Answer2 { get; set; } = string.Empty;
        public bool CorrectAnswer2 { get; set; } = false;

        [StringLength(100)]
        public string Answer3 { get; set; } = string.Empty;
        public bool CorrectAnswer3 { get; set; } = false;

        [StringLength(100)]
        public string Answer4 { get; set; } = string.Empty;
        public bool CorrectAnswer4 { get; set; } = false;

        [StringLength(200)]
        public string Feedback { get; set; } = string.Empty;

    }
}
