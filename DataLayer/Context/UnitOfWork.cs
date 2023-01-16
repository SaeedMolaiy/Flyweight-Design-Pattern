using DataLayer.Interfaces;

namespace DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        private readonly SampleDbContext _dbContext;

        public UnitOfWork(SampleDbContext dbContext, IPersonRepository personRepository)
        {
            _dbContext = dbContext;
            PersonRepository = personRepository;
        }

        public IPersonRepository PersonRepository { get; }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}