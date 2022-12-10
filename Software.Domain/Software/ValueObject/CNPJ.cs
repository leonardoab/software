using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Domain.Software.ValueObject
{
    public class CNPJ
    {
        public CNPJ(String codigo)
        {
            if (codigo.Length == 14)
            {
                this.Codigo = codigo;
            }
            else
            {
                throw new ArgumentNullException("CNPJ tem que ter 14 digitos");

            }
        }

        public string Codigo { get; set; }



        // validacao de CNPJ, quantidade de digitos
    }
}
