using CommunityToolkit.Mvvm.ComponentModel;
using MySuperLeakyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperLeakyApp.ViewModels
{
    public partial class AnyPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<Person> _people;

        [ObservableProperty]
        private string _title;

        [ObservableProperty]
        private string _description;

        public AnyPageViewModel(string title, string description)
        {
            _title = title;
            _description = description;
            _people = Person.GenerateTestSet();
        }
    }


}
