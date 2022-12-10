using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Domain.Software
{
    public class Operacao : Entity<Guid>
    {
        public string Descricao { get; set; }
    }
}
