using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6_WFEx2.Services
{
    public class Locacao
    {
        public DateTime dataLocacao { get; set; }
        public DateTime dataDevolucao { get; set; }

        public Locacao(DateTime dataLocacao, DateTime dataDevolucao)
        {
            this.dataLocacao = dataLocacao;
            this.dataDevolucao = dataDevolucao;
        }
    }
}
