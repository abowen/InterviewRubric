using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewRubric.Shared
{
    public class AppState
    {
        public RubricQuestion[] RubricQuestions;
        public List<RubricQuestion> SelectedRubricQuestions = new List<RubricQuestion>();
    }
}
