using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Prototype
{
    public class Person
    {
        public string name;
        public DateTime dateOfBirth;
        public Address address;
        public Person spouse;

        public Person()
        {

        }

        public Person(Person person)
        {
            
        }

        //Deep Copy
        public Person GetClone()
        {
            Person _person = (Person)this.MemberwiseClone();
            _person.address = this.address.GetClone();

            _person.spouse = (Person)this.spouse.MemberwiseClone();
            _person.spouse.address = this.spouse.address.GetClone();

            return _person;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Age: " + (DateTime.Today.Year - this.dateOfBirth.Year));
            Console.WriteLine("Address: H-{0}, Road-{1}, PC-{2}, Dist-{3}", this.address.houseNo, this.address.streetNo, this.address.postCode, this.address.district);
            Console.WriteLine("Spouse name: {0}, Spouse dist: {1}", this.spouse.name, this.spouse.address.district);
        }
    }

    public class Address
    {
        public string houseNo;
        public string streetNo;
        public string postCode;
        public string district;

        public Address GetClone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}
