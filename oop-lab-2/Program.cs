using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Создать класс Customer: id, Фамилия, Имя, Отчество,
//Адрес, Номер кредитной карточки, баланс. Свойства и
//конструкторы должны обеспечивать проверку
//корректности. Добавить методы зачисления и списания сумм на счет.

// a) список покупателей в алфавитном порядке;
// b) список покупателей, у которых номер кредитной карточки
 // находится в заданном интервале

namespace lab_2
{
    class Program
    {
        int variable;
        public int Variable
        {
            get
            {
                return this.variable;
            }
            set
            {
                this.variable = value;
            }
        }

        public static void Main()
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer();
            customers[1] = new Customer("Nergal", "Adam", "Darski", 123, "Poland");
            customers[2] = new Customer("Joshs", "Smith", "Northlane", 321);

            Program.CardNumberBelongToRange(customers, 0, 150);

            Program.SortAndShow(customers);

            int A = 5;
            int B;

            Program.Foo(out B);
            Program.Boo(ref A);

            Console.WriteLine("Amount of created elements: " + Customer.GetAmountOfCreatedObjects());

            Console.ReadKey();
        }

        public static void CardNumberBelongToRange(Customer[] list, int leftBoard, int rightBoard)
        {
            foreach(var item in list)
            {
                if(item.CardNumber >= leftBoard && item.CardNumber <= rightBoard )
                {
                    Console.WriteLine(item.Name + " - CardNumber: " + item.CardNumber);
                }
            }
        }
        public static void SortAndShow(Customer[] list)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < list.Length - 1; i++)
                {
                    if (list[i].Name.CompareTo(list[i+1].Name) > 0)
                    {
                        string buf = list[i].Name;
                        list[i].Name = list[i + 1].Name;
                        list[i + 1].Name = buf;
                        flag = true;
                    }
                }
            }

            foreach(var item in list)
            {
                Console.WriteLine(item.Name + "\t" + item.Surname +"\t" + item.Patr);
            }
        }


        public static void Foo(out int value)
        {
            value = 2;
        }

        public static void Boo(ref int value)
        {
            value++;
        }
    }
}
