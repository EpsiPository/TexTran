using Microsoft.EntityFrameworkCore;

namespace TextTran.Data.Access.Context
{
    public class TextTranContext : DbContext
    {
        public TextTranContext(DbContextOptions options)
            : base(options)
        {

        }

        //TODO: Use reflection to add DbSet<T> properties dynamically !
    }
}
