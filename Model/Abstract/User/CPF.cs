using System;
using System.Text.RegularExpressions;

namespace ViberBank.Model.Abstract.User
{
    internal class CPF
    {
        private string cpf;

        public CPF(string cpf)
        {
            this.cpf = cpf;
            if (!this.Validate())
            {
                throw new Exception("CPF Inválido");
            }
        }

        public string Cpf { get => cpf;  }

        public bool Validate()
        {
            MatchCollection matches = new Regex("([0-9]{3})+([0-9]{3})+([0-9]{3})+([0-9]{2})").Matches(this.cpf);

            return matches.Count != 1 ? false : true;
        }
    }
}
