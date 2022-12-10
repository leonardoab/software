using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Domain.Software
{
    public class Consulta : Entity<Guid>
    {
        
        public Fornecedor Fornecedor { get; set; }
        public Contrato? Contrato { get; set; }
        public PlanoTarifacao PlanoTarifacao { get; set; }

        // tem q ter um plano de tarifacao
        // ter q ter um fornecedor
        // pode ter um contrato


        public IList<Usuario> Usuarios { get; set; }

    }
}
