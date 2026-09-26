namespace basic_system_poo.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Cpf { get; set; }

         public float Saldo;

        public Account(int id, string name, int cpf)
        {
            this.Id = id;
            this.Name = name;
            this.Cpf = cpf;
        }
        public float Depositar(float valor)
        {
            Saldo += valor;
            return Saldo;
        }
        
        public float Sacar(float valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            return Saldo;
        }

    }
}