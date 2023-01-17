using DataLayer.Implementations;
using DataLayer.Interfaces;

namespace DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        private readonly SampleDbContext _dbContext;

        private IPersonRepository _personRepository;

        public UnitOfWork(SampleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IPersonRepository PersonRepository
        {
            get
            {
                if (_personRepository == null)
                {
                    _personRepository = new PersonRepository(_dbContext);
                }
                return _personRepository;
            }
        }

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