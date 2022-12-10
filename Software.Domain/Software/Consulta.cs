using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Domain.Software
{
    public class Consulta : Entity<Guid>
    {
        public PlanoTarifacao PlanoTarifacao { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Contrato Contrato { get; set; }
    }
}
