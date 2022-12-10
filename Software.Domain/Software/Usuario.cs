using Software.Domain.Software.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Domain.Software
{
    public class Usuario : Entity<Guid>
    {
        public string Login { get; set; }
        public Senha Senha { get; set; }
        public bool Administrador { get; set; }

        //so pode ter uma adminitrador por cliente


        public IList<Consulta> Consultas { get; set; }
        public IList<Operacao> Operacoes { get; set; }
        public IList<HistoricoOperacao> HistoricoOperacao { get; set; }
    }
}
