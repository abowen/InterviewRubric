using System;

namespace InterviewRubric.Shared
{
    public class RubricQuestion
    {
        public Guid Id { get; set; }

        // TODO: Move strings to Markdown
        public string Question { get; set; }
        public QuestionCategory Category { get; set; }
        public QuestionType Type { get; set; }
        public QuestionDifficulty Difficulty { get; set; }

        public string Low { get; set; }
        public string Medium { get; set; }
        public string High { get; set; }
        public int Minutes { get; set; }
        public string Technology { get; set; }
        
        public override string ToString()
        {
            return $"{Question} : {Minutes}";
        }
    }
}
