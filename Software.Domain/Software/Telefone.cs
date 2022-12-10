using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Domain.Software
{
    public class Telefone : Entity<Guid>
    {
        public string Codigo { get; set; }
    }
}
