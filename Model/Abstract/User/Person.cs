using System;

namespace ViberBank.Model.Abstract.User
{
    internal abstract class Person
    {
        protected string name;
        protected int age;
        protected CPF cpf;
        protected Address address;

        public Person(string name, int age, CPF cpf, Address address)
        {
            this.name       = name;
            this.age        = age;
            this.cpf        = cpf;
            this.address    = address;
        }

        public string Name { get => this.name;  }
        public int Age { get => this.age; }
    }
}
