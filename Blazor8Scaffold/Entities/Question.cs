namespace Blazor8Scaffold.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        
        public string Answer1 { get; set; } = string.Empty;
        public bool CorrectAnswer1 { get; set; } = false;
        
        public string Answer2 { get; set; } = string.Empty;
        public bool CorrectAnswer2 { get; set; } = false;
        
        public string Answer3 { get; set; } = string.Empty;
        public bool CorrectAnswer3 { get; set; } = false;

        public string Answer4 { get; set; } = string.Empty;
        public bool CorrectAnswer4 { get; set; } = false;

    }
}
