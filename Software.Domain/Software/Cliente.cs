using Software.Domain.Software.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Domain.Software
{
    public class Cliente 
    {
       

        public string Nome { get; set; }
        public CNPJ CNPJ { get; set; }

        public IList<Telefone> Telefones { get; set; }
        public IList<Usuario> Usuarios { get; set; }






    }
}
