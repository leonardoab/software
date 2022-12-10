using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Domain.Software
{
    public class PlanoTarifacao : Entity<Guid>
    {
        public float Valor;
        public DateTime? DataVigencia { get; set; }


        public IList<Operacao> Operacoes { get; set; }

    }
}
