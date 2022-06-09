using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Equl : IEqualityComparer<Person>
{
    public bool Equals(Person? x, Person? y)
    {
        if (string.Equals(x.ID, y.ID, StringComparison.OrdinalIgnoreCase)
            && string.Equals(x.Name, y.Name, StringComparison.OrdinalIgnoreCase)
            && (x.Age == y.Age))
        {
            return true;
        }
        return false;
    }

    public int GetHashCode(Person obj)
    {
        return obj.GetHashCode();
    }
}


class Person
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class MainAPP
{
    //static void Main()
    //{
    //    Person person1 = new Person()
    //    {
    //        ID = "1",
    //        Name = "홍길동",
    //        Age = 24,
    //    };
    //    Person person2 = new Person()
    //    {
    //        ID = "1",
    //        Name = "홍길동",
    //        Age = 23,
    //    };

    //    Console.WriteLine(new Equl().Equals(person1, person2));

    //}
}
