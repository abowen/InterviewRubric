using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewRubric.Shared
{
    public class AppState
    {
        public event Action OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();

        public void SetInitialState(RubricQuestion[] questions)
        {
            RubricQuestions = questions.ToList();
            UnselectedRubricQuestions = questions.ToList();
            SelectedRubricQuestions = new List<RubricQuestion>();
        }

        public List<RubricQuestion> RubricQuestions;
        public List<RubricQuestion> SelectedRubricQuestions;
        public List<RubricQuestion> UnselectedRubricQuestions;

        public string[] Technologies = new string[]
        {
            ".NET",
            "C#",
            "JavaScript",
            "React",
            "CSS",
            "Cloud"
        };

        public void AddQuestion(RubricQuestion question)
        {
            RubricQuestions.Add(question);
            UnselectedRubricQuestions.Add(question);
            NotifyStateChanged();   
        }

        public void SelectQuestion(RubricQuestion question)
        {
            if (UnselectedRubricQuestions.Contains(question))
            {
                UnselectedRubricQuestions.Remove(question);
                SelectedRubricQuestions.Add(question);
                NotifyStateChanged();
            }
        }

        public void UnselectQuestion(RubricQuestion question)
        {
            if (SelectedRubricQuestions.Contains(question))
            {
                SelectedRubricQuestions.Remove(question);
                UnselectedRubricQuestions.Add(question);
                NotifyStateChanged();
            }
        }

        public void MoveUpQuestion(RubricQuestion question)
        {
            var index = SelectedRubricQuestions.IndexOf(question);
            if (index > 0)
            {
                SelectedRubricQuestions.Remove(question);
                SelectedRubricQuestions.Insert(index-1, question);
                NotifyStateChanged();
            }
        }

        public void MoveDownQuestion(RubricQuestion question)
        {
            var index = SelectedRubricQuestions.IndexOf(question);
            if (index > -1 && index < (SelectedRubricQuestions.Count-1))
            {
                SelectedRubricQuestions.Remove(question);
                SelectedRubricQuestions.Insert(index + 1, question);
                NotifyStateChanged();
            }
        }
    }
}
