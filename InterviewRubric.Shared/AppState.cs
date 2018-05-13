using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace InterviewRubric.Shared
{
    public class AppState
    {
        public event Action OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();

        public void SetInitialState(RubricQuestion[] questions)
        {
            RubricQuestions = questions;
            UnselectedRubricQuestions = questions.ToList();
            SelectedRubricQuestions = new List<RubricQuestion>();
        }

        public IEnumerable<RubricQuestion> RubricQuestions;
        public List<RubricQuestion> SelectedRubricQuestions;
        public List<RubricQuestion> UnselectedRubricQuestions;

        public void AddQuestion(RubricQuestion question)
        {
            Console.WriteLine($"Add : {question}");
            if (UnselectedRubricQuestions.Contains(question))
            {
                UnselectedRubricQuestions.Remove(question);
                SelectedRubricQuestions.Add(question);
                NotifyStateChanged();
                Console.WriteLine($"Added : {question}");
            }
        }

        public void RemoveQuestion(RubricQuestion question)
        {
            if (SelectedRubricQuestions.Contains(question))
            {
                SelectedRubricQuestions.Remove(question);
                UnselectedRubricQuestions.Add(question);
                NotifyStateChanged();
            }
        }
    }
}
