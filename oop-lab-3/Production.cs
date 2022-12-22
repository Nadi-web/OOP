using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_3
{
    class Production
    {
        readonly int id;
        string name;
        string company;
        public Production(int Id, string Name, string Company)
        {
            this.id = Id;
            this.name = Name;
            this.company = Company;
        }
        public void printInfo()
        {
            Console.WriteLine("ID: {0}\nName: {1}\nCompany: {2}", id, name, company);
        }
    }
}
