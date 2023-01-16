using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

    }
}
