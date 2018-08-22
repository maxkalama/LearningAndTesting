using System;

namespace DynamicClassLibrary
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Repository
    {
        Person _person = new Person { Name = "Adam", Age = 21 };

        public object GetPerson()
        {
            return _person;
        }

        public object GetPersonWrappedInAnonymusType()
        {
            return new { Person = _person };
        }
    }
}
