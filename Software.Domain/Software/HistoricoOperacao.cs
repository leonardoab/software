using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Domain.Software
{
    public class HistoricoOperacao : Entity<Guid>
    {
        public Operacao Operacao { get; set; }
        public DateTime DataOperacao { get; set; }
    }
}
