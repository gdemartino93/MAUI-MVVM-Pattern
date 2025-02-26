using MAUI_MVVM_Pattern.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_MVVM_Pattern.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; }
        public PersonViewModel()
        {
            Person = new Person
            {
                Name = "Luca",
                LastName = "Rossi",
                DateOfBirth = new DateTime(1993, 7, 12),
                Weight = 75,
                IsMad = true
            };
        }
    }
}
