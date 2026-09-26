namespace basic_system_poo
{
    public abstract class Person
    {
        string Name{get;set;}
        string Cpf{get;set;}

        protected Person(string name, string cpf)
        {
            Name = name;
            Cpf = cpf;
        }
        public abstract void Detaill();
    }
}