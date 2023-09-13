namespace ViberBank.Model.Bank
{
    internal class Account : Operations
    {
        private Owner owner;

        private decimal balance = 0.0M;
        public Account(Owner owner)
        {
            this.owner = owner;
        }

        public override void addBalance(decimal balance)
        {
            if (balance <= 0.0M)
            {
               throw new Exception("Somente valores positivos são permitidos");
            }

            this.balance += balance;
            Console.WriteLine($"R${balance} foi adicionado à sua conta!!\n Saldo atual R${this.balance}.");
        }

        public override void removeBalance(decimal balance)
        {
            if (balance <= 0.0M)
            {
                throw new Exception("Somente valores positivos são permitidos");
            } else if (this.balance < balance)
            {
                throw new Exception("Saldo insuficiente para retirada!!");
            }

            this.balance -= balance;
            Console.WriteLine($"R${balance} foi retirado de sua conta!!!\n Saldo atual R${this.balance}.");
        }

        public override void transferBalance(decimal balance, Account account_to_transfer)
        {
            if (balance <= 5.0M)
            {
               throw new Exception("O mínimo para transferência é de R$5,00");
            } else if (this.balance < balance)
            {
                throw new Exception("Saldo insuficiente para transferência!!");
            }

            this.removeBalance(balance);
            account_to_transfer.addBalance(balance);

            Console.WriteLine($"Saldo de R${balance} transferido com sucesso!!!\n Saldo atual R${this.balance}.");
        }
    }
}
