using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Domain.Software
{
    public class Consulta : Entity<Guid>
    {
        public Consulta(Fornecedor fornecedor)
        {
            if (fornecedor != null)
            {
                this.Fornecedor = fornecedor;
                Usuarios = new List<Usuario>();
            }
            else
            {
                throw new ArgumentNullException("Uma consulta tem que ter um fornecedor");

            }
        }

        private Fornecedor Fornecedor { get; set; }
        
       




        public IList<Usuario> Usuarios { get; set; }

    }
}
