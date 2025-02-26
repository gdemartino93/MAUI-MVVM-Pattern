using MAUI_MVVM_Pattern.MVVM.Models;

namespace MAUI_MVVM_Pattern.MVVM.ViewModels
{
    public class PeopleViewModel
    {
        public List<Person> People { get; set; } = [];
        public PeopleViewModel()
        {
            People = new List<Person>
            {
                new Person{ Name = "Luca", LastName = "Rossi", Weight = 80, DateOfBirth = new DateTime(1993, 7, 12)},
                new Person{ Name = "Sara", LastName = "Bianchi", Weight = 90, DateOfBirth = new DateTime(1993, 7, 15)},
                new Person{ Name = "Marco", LastName = "Verdi", Weight = 77, DateOfBirth = new DateTime(1993, 7, 12)}
            };
        }
    }
}
