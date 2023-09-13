global using System;

namespace ViberBank.Model.Abstract.User
{
    internal class Address
    {
        private string street;
        private string city;
        private string district;
        private int number;

        public Address(string street, string city, string district, int number)
        {
            this.city = city;
            this.street = street;
            this.number = number;
            this.district = district;
        }

        public string getStreet() { return this.street; }
        public string getCity() { return this.city; }
        public string getDistrict() { return this.district; }
        public int getNumber() { return this.number; }

    }
}
