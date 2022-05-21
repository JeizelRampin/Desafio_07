using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_07
{
    public interface IDaoBase
    {
        void AbrirConexao();
        void FecharConexao();
    }
}
