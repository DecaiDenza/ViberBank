namespace ViberBank.Model.Bank
{
    internal abstract class Operations
    {
        abstract public void addBalance(decimal balance);

        abstract public void removeBalance(decimal balance);

        abstract public void transferBalance(decimal balance, Account account_to_transfer);
    }
}
