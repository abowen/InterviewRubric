namespace InterviewRubric.Shared
{
    public class RubricQuestion
    {
        // TODO: Move strings to Markdown
        public string Question { get; set; }
        public string Low { get; set; }
        public string Medium { get; set; }
        public string High { get; set; }
        public Difficulty Difficulty { get;set; }
        public int Minutes { get; set; }

        public override string ToString()
        {
            return $"{Question} : {Minutes}";
        }
    }
}
