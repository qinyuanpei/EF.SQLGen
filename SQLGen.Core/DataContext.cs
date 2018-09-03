using System;

namespace SQLGen
{
    public class DataContext: DbContext
    {
        public new DbSet<TEntity>
    }
}