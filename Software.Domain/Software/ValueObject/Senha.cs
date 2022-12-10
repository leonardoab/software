using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Domain.Software.ValueObject
{
    public class Senha
    {
        public Senha(string codigo)
        {

            if (codigo.Length > 8)
            {
                this.Codigo = codigo;
            }
            else
            {
                throw new ArgumentNullException("Senha tem que ter no minimo 8 caracters");

            }
        }

        public string Codigo { get; set; }



        // aplicar criptografica e regras de formacao de senha forte
    }
}
