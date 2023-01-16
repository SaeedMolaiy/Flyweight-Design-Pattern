using DataLayer.Entities;

namespace DataLayer.Interfaces
{
    public interface IPersonRepository
    {
        public HashSet<Person> GetPeople();
        public Person GetPerson(int id);
        public bool AddPerson(Person person);
        public bool UpdatePerson(Person person);
        public bool DeletePerson(int personId);
        public bool DeletePerson(Person person);
    }
}
