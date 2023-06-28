using System.Globalization;

namespace ContaBancaria {
    internal class ContaBancaria {

        public string Nome { get; set; }
        public double Saldo { get; private set; }
        public int Id { get; private set; }

        public ContaBancaria (int id, string nome) {
            Id = id;
            Nome = nome;
        }

        public ContaBancaria(int id, string nome, double saldo) : this(id, nome) {
            Saldo = saldo;   
        }

        public double GetSaldo( ) {
            return Saldo;
        }

        public void Deposito(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo -= 5 + valor;
        }

        public override string ToString( ) {
            return "Conta "
                + Id
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }








    }
}
