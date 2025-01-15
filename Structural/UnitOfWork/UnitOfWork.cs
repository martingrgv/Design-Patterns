using UnitOfWork.Interfaces;

namespace UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private List<TEntity> GetSet<TEntity>() where TEntity : IEntity => new();

        public void Add<TEntity>(TEntity entity) where TEntity : IEntity
        {
            GetSet<TEntity>().Add(entity);
        }

        public void AddRange<TEntity>(List<TEntity> entities) where TEntity : IEntity
        {
            GetSet<TEntity>().AddRange(entities);
        }

        public Task FindAsync<TEntity>(int id)  where TEntity : IEntity
        {
            return Task.FromResult(GetSet<TEntity>().FirstOrDefault(e => e.Id == id));
        }

        public void Remove<TEntity>(TEntity entity) where TEntity : IEntity
        {
            GetSet<TEntity>().Remove(entity);
        }

        public Task SaveChangesAsync()
        {
            Console.WriteLine("Saved changes");

            return Task.CompletedTask;
        }
    }
}
