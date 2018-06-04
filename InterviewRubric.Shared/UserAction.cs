using System;

namespace InterviewRubric.Shared
{
    public class UserAction
    {
        public Action<RubricQuestion> Action { get; set; }
        public string Text { get; set; }
    }
}
