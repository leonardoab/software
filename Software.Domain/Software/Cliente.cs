using Software.Domain.Software.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Domain.Software
{
    public class Cliente : Entity<Guid>
    {
       

        public string Nome { get; set; }
        public CNPJ CNPJ { get; set; }

        public IList<Telefone> Telefones { get; set; }
        public IList<Usuario> Usuarios { get; }


        public void SetUsuarios()
        {

            if (Usuarios != null)
            {
                int quantidadeAdm = 0;

                for (int i = 0; i < Usuarios.Count(); i++)
                {
                    if (Usuarios[i].Administrador == true)
                    {
                        quantidadeAdm++;

                    }
                }

                if (quantidadeAdm > 1)
                {


                    throw new ArgumentNullException("Um Cliente nao pode ter mais de um usuario administrador");

                }


            }

        }






    }
}
