namespace basic_system_poo.Models
{
    public class Teacher : Person
    {
        public double Salario { get; }

        public Teacher(string name, string cpf, double salario) : base(name, cpf)
        {
            Salario = salario;
        }
    }
}