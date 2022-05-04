using Class6_WFEx2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class6_WFEx2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void btnListarCarros_Click(object sender, EventArgs e)
        {
            lstCarro.Visible = true;
            if (lstCarro.Items.Count > 2)
            {
                List<Carro> listAtual = new List<Carro>();
                for (int i = 0; i < lstCarro.Items.Count; i++)
                {
                    listAtual.Add((Carro)lstCarro.Items[i]);
                }
                lstCarro.Items.Clear();
                foreach (var c in listAtual)
                {
                    lstCarro.Items.Add(c);
                }
            } 
            else
            {
                lstCarro.Items.Clear();
                List<Carro> carros = CarroRepository.InicializarCarros();
                foreach (var c in carros)
                {
                    lstCarro.Items.Add(c);
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lstCarro.Visible = true;
            if (lstCarro.Items.Count > 2)
            {
                List<Carro> listAtual = new List<Carro>();
                for (int i = 0; i < lstCarro.Items.Count; i++)
                {
                    listAtual.Add((Carro)lstCarro.Items[i]);
                }
                List<Carro> carrosBusca = new List<Carro>();
                carrosBusca = listAtual.FindAll(x => x.Marca == txtBuscar.Text || x.Modelo == txtBuscar.Text);
                lstCarro.Items.Clear();
                txtBuscar.Clear();
                foreach (var c in carrosBusca)
                {
                    lstCarro.Items.Add(c);
                }
            }
            else
            {
                List<Carro> carros = CarroRepository.InicializarCarros();
                List<Carro> carrosBusca = new List<Carro>();
                carrosBusca = carros.FindAll(x => x.Marca == txtBuscar.Text || x.Modelo == txtBuscar.Text);
                lstCarro.Items.Clear();
                txtBuscar.Clear();
                foreach (var c in carrosBusca)
                {
                    lstCarro.Items.Add(c);
                }
            }
        }

        private void btnConfEscolha_Click(object sender, EventArgs e)
        {
            int ind = lstCarro.SelectedIndex;
            DateTime dtLocacao = Convert.ToDateTime(txtDataLocacao.Text);
            DateTime dtDevolucao = Convert.ToDateTime(txtDataDevolucao.Text);

            List<Carro> listAtual = new List<Carro>();
            for (int i = 0; i < lstCarro.Items.Count; i++)
            {
                listAtual.Add((Carro)lstCarro.Items[i]);
            }

            double calc = (dtDevolucao.Day - dtLocacao.Day) * listAtual[ind].ValorDiaria;

            lblConf.Text = $"Locação confirmada para {txtNomeCliente.Text} - Veículo: {listAtual[ind].Marca} {listAtual[ind].Modelo}";
            lblConf2.Text = $"Data de devolução: {dtDevolucao:dd/MM/yyyy} - Valor total: R$ {calc}";

            listAtual[ind].Disponivel = false;
            List<Carro> listaAtual2 = new List<Carro>();
            listaAtual2 = listAtual.FindAll(x => x.Disponivel == true);
            lstCarro.Items.Clear();

            foreach (var c in listaAtual2)
            {
                lstCarro.Items.Add(c);
            }
        }

    }
}
