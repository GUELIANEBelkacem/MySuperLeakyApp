using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace MySuperLeakyApp.Models
{
    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public string Age { get; set; } = string.Empty;
        public string ImageUrl => $"https://placehold.co/600x400?text={Name.First()}";

        public static List<Person> GenerateTestSet()
        {
            return new List<Person>()
        {
            new Person{Name = "Laura", Age = "15"},
            new Person{Name = "Michael", Age = "17"},
            new Person{Name = "Seb", Age = "98"},
            new Person{Name = "Marc", Age = "32"},
            new Person{Name = "Maria", Age = "69"},
            new Person{Name = "Lauriche", Age = "23"},
            new Person{Name = "Laurent", Age = "28"},
        };
        }
    }
}
