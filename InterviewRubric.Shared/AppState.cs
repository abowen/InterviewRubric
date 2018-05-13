using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace InterviewRubric.Shared
{
    public class AppState
    {
        public IEnumerable<RubricQuestion> RubricQuestions;
        public IEnumerable<RubricQuestion> SelectedRubricQuestions => RubricQuestions?.Where(rq => rq.Selected);
    }
}
