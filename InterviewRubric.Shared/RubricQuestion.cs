namespace InterviewRubric.Shared
{
    public class RubricQuestion
    {
        public string Question { get; set; }
        public string Low { get; set; }
        public string Medium { get; set; }
        public string High { get; set; }
        public Difficulty Difficulty { get;set; }
        public int Minutes { get; set; }
        public bool Selected { get; set; }

        public override string ToString()
        {
            return $"{Selected} : {Question}";
        }
    }
}
