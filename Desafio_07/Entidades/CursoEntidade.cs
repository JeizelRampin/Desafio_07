using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_07.Entidades
{
    public class CursoEntidade
    {
        int id, ano;
        string nome;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Ano { get => ano; set => ano = value; }
    }
}
