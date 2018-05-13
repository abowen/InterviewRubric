using InterviewRubric.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewRubric.Server.Controllers
{
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<RubricQuestion> RubricQuestions()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new RubricQuestion
            {
                Question = DateTime.Now.AddDays(index).ToShortDateString() + " question",
                Low = "Low " + rng.Next(-20, 55),
                Medium = Summaries[rng.Next(Summaries.Length)],
                High = "High",
                Difficulty = (Difficulty)rng.Next(0, 2),
                Minutes = rng.Next(1, 3)
            });
        }
    }
}
