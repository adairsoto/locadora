using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6_WFEx2.Services
{
    public class Cliente : Form1
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnh { get; set; }

        public Cliente(int id, string nome, string cnh)
        {
            Id = id;
            Nome = nome;
            Cnh = cnh;
        }
    }
}
