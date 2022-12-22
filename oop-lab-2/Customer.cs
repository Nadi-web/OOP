using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public partial class Customer
    {
        static int amount;

        public readonly int Id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patr { get; set; }
        public string Address { get; set; }
        public int CardNumber { get; set; }
        public float Balance { get; set; }
        public static int GetAmountOfCreatedObjects()
        {
            return amount;
        }

        public void AddCash(float value)
        {
            this.Balance += value;
        }

        public bool RemoveCash(float value)
        {
            if (this.Balance - value >= 0)
            {
                this.Balance -= value;
                return true;
            }
            return false;
        }


        public Customer() : this("", "", "", 0) { }
        public Customer(string name, string surname, string patr, int cardNumber)
        {
            this.Name = name;
            this.Patr = patr;
            this.Surname = surname;
            this.CardNumber = cardNumber;
            amount++;
        }
        public Customer(string name, string surname, string patr, int cardNumber, string Addr = "Homeless")
        {
            this.Name = name;
            this.Patr = patr;
            this.Surname = surname;
            this.CardNumber = cardNumber;
            amount++;
        }
        static Customer()
        {
            amount = 0;
        }
    }


    public partial class Customer
    {
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                if (obj is Customer)
                {
                    if (this.Name == ((Customer)obj).Name && this.Surname == ((Customer)obj).Surname)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
