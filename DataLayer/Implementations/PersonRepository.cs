using DataLayer.Context;
using DataLayer.Entities;
using DataLayer.Interfaces;

namespace DataLayer.Implementations
{
    public class PersonRepository : IPersonRepository
    {
        private readonly SampleDbContext _dbContext;

        public PersonRepository(SampleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public HashSet<Person> GetPeople()
        {
            return new HashSet<Person>(_dbContext.People);
        }

        public Person GetPerson(int id)
        {
            return _dbContext.People.Find(id);
        }

        public bool AddPerson(Person person)
        {
            try
            {
                _dbContext.People.Add(person);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePerson(Person person)
        {
            try
            {
                if (!_dbContext.People.Contains(person)) return false;

                _dbContext.People.Update(person);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePerson(int personId)
        {
            try
            {
                var person = GetPerson(personId);
                DeletePerson(person);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePerson(Person person)
        {
            try
            {
                _dbContext.People.Remove(person);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
