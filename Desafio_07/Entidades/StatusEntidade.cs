using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_07.Entidades
{
    public class StatusEntidade
    {
        int id;
        double nota_1, nota_2, nota_3, nota_4, media;
        string status;

        public int Id { get => id; set => id = value; }
        public double Nota_1 { get => nota_1; set => nota_1 = value; }
        public double Nota_2 { get => nota_2; set => nota_2 = value; }
        public double Nota_3 { get => nota_3; set => nota_3 = value; }
        public double Nota_4 { get => nota_4; set => nota_4 = value; }
        public double Media { get => media; set => media = value; }
        public string Status { get => status; set => status = value; }
    }
}
