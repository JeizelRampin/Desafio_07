using Desafio_07.DAO;
using Desafio_07.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_07.Model
{
    public class StatusModel
    {
        StatusDAO dao = new StatusDAO();

        public void salvarStatusModel(StatusEntidade dado)
        {
            try
            {
                dao.salvarStatusDAO(dado);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO EM SalvarModel" + ex.Message);
            }
        }
    }
}
