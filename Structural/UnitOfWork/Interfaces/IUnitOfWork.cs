namespace UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        public void Add<TEntity>(TEntity entity) where TEntity : IEntity;
        public void AddRange<TEntity>(List<TEntity> entities) where TEntity : IEntity;
        public Task FindAsync<TEntity>(int id) where TEntity : IEntity;
        public void Remove<TEntity>(TEntity entity) where TEntity : IEntity;
        public Task SaveChangesAsync();
    }
}
