using InterviewRubric.Shared;
using Microsoft.EntityFrameworkCore;

namespace InterviewRubric.Server.Data
{
    public class RubricContext : DbContext
    {
        public RubricContext(DbContextOptions<RubricContext> options)
            : base(options)
        { }

        public DbSet<RubricQuestion> RubricQuestions { get; set; }
    }
}
