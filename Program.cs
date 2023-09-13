using ViberBank.Model;
using ViberBank.Model.Bank;

Owner owner_1 = new("Lucas",
    25,
    new ViberBank.Model.Abstract.User.CPF("99924500722"),
    new ViberBank.Model.Abstract.User.Address("Rua do Progamador", "Visual Studio", "Clean Code", 75)
);

Owner owner_2 = new("Jonas",
    35,
    new ViberBank.Model.Abstract.User.CPF("21426596722"),
    new ViberBank.Model.Abstract.User.Address("Rua Malafaia", "São Paulo", "Nova Iguaçú", 235)
);

Account account_1 = new(owner_1);
Account account_2 = new(owner_2);

try
{
    account_1.addBalance(100.00M);
    account_1.removeBalance(20.25M);
    account_1.transferBalance(50.55M, account_2);

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}