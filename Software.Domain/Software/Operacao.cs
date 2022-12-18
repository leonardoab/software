using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Domain.Software
{
    public class HistoricoOperacao : Entity<Guid> // Operacao
    {
        public TipOperacao TipOperacao { get; set; }
        public DateTime DataOperacao { get; set; }
        public Contrato Contrato { get; set; }
        public PlanoTarifacao PlanoTarifacao { get; set; }

        public HistoricoOperacao(Operacao operacao, DateTime dataOperacao, Contrato contrato, PlanoTarifacao planoTarifacao)
        {
            if (operacao != null && contrato != null && planoTarifacao != null)
            {
                this.Operacao = operacao;
                this.PlanoTarifacao = planoTarifacao;
                this.Contrato = contrato;
            }
            else
            {
                throw new ArgumentNullException("Um Historico de operacao tem que estar associado a um contrato, operacao e um plano de tarifacao");

            }
        }

    }
}
