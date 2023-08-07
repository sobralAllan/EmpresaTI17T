﻿using System;
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
    public partial class Excluir : Form
    {
        DAO exc;
        public Excluir()
        {
            InitializeComponent();
            exc = new DAO();
        }//fim do construtor

        private void button1_Click(object sender, EventArgs e)
        {
            string result = exc.Excluir(Convert.ToInt64(cpf.Text), "pessoa");
            MessageBox.Show(result);
        }//Botão Excluir

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do CPF
    }//fim da classe
}//fim do projeto
