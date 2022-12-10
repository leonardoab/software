using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Domain.Software
{
    public class Contrato : Entity<Guid>
    {
        public float Valor { get; set; }
        public DateTime? DataVigencia { get; set; }
    }
}
