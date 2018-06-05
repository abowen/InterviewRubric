using InterviewRubric.Server.Data;
using InterviewRubric.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewRubric.Server.Controllers
{
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        public QuestionController(RubricContext context)
        {
            this.context = context;
        }
        
        private readonly RubricContext context;

        [HttpGet("[action]")]
        public IEnumerable<RubricQuestion> Get()
        {
            return context.RubricQuestions.ToArray();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add([FromBody]RubricQuestion question)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await context.RubricQuestions.AddAsync(question);
            await context.SaveChangesAsync();
            return CreatedAtAction("Add", null);
        }
    }
}
