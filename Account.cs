using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basic_system_poo
{
    public class Account
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Cpf { get; set; }
        public Account(int id, string name, int cpf) 
        {
    this.Id = id;
    this.Name = name;
    this.Cpf = cpf;
   
        }
        public void Detaill()
        {
            System.Console.WriteLine($"My name is {Name} its number of account {Id}, and cpf {Cpf}");
        }
    }
}