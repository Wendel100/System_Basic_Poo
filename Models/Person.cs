namespace basic_system_poo.Models
{
    public abstract class Person
    {
        public string Name { get; }
        public string Cpf { get; }

        protected Person(string name, string cpf)
        {
            Name = name;
            Cpf = cpf;
        }

    }
}