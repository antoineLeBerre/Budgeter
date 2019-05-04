using Microsoft.EntityFrameworkCore;

namespace Budgeter.Data
{
    public class BudgeterContext: DbContext
    {
        public BudgeterContext(DbContextOptions<BudgeterContext> options)
            :base(options)
        {
            
        }
    }
}