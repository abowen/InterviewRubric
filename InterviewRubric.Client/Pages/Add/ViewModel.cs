using InterviewRubric.Shared;
using System.Threading.Tasks;

namespace InterviewRubric.Client.Pages.Add
{
    public class ViewModel
    {
        private readonly AppState appState;

        public RubricQuestion RubricQuestion { get; set; }

        public ViewModel(AppState appState)
        {
            this.appState = appState;
            RubricQuestion = new RubricQuestion();
        }

        public void Submit()
        {
            appState.AddQuestion(RubricQuestion);
            RubricQuestion = new RubricQuestion();
        }
    }
}
