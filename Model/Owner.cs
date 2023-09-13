using ViberBank.Model.Abstract.User;

namespace ViberBank.Model
{
    internal class Owner : Person
    {

        public Owner(string name, int age, CPF cpf, Address address) : base(name, age, cpf, address)
        {
            this.name       = name;
            this.age        = age;
            this.cpf        = cpf;
            this.address    = address;
        }
    }
}
