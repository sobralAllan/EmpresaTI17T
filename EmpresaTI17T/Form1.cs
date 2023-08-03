using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTI17T
{
    public partial class Empresa : Form
    {
        Cadastrar cad;
        Consultar con;
        Atualizar atu;
        Excluir exc;
        public Empresa()
        {
            InitializeComponent();
            cad = new Cadastrar();
            con = new Consultar();
            atu = new Atualizar();
            exc = new Excluir();
        }//fim do construtor

        private void Empresa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();//Abre a tela
        }//Fim do Cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            con.ShowDialog();//Abre a tela
        }//Fim do Consultar

        private void button3_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();//Abre a tela
        }//Fim do Atualizar

        private void button4_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();//Abre a tela
        }//fim do Excluir
    }//fim da classe
}//fim do projeto
