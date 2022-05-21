using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Desafio_07.DAO;
using Desafio_07.Entidades;

namespace Desafio_07.Model
{
    public class CursoModel
    {
        CursoDAO dao = new CursoDAO();

        public void salvarCursoModel(CursoEntidade dado)
        {
            try
            {
                dao.salvarCursoDAO(dado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO EM SalvarModel" + ex.Message);
            }
        }
    }
}
