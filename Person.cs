using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAndBurgers
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private decimal money;
        private string[] address;

        public Person(decimal money, string firstName, string lastName, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address.Split(',');
            this.money = money;
        }
      
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public decimal Money { get => money; set => money = value; }
        public string[] Address { get => address; set => address = value; }

        //methods
        public void ShowPerson()
        {
            Console.WriteLine($"FirstName: {firstName} \nLastName: {lastName} \nMoney:{money} \nAddress\nStreet:{address[0]}, City:{address[1]}, State:{address[2]}, Zip:{address[3]}");
        }
    }
}

