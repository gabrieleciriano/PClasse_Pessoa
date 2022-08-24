using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse_Pessoa
{
    internal class Pessoa
    {
        /*faça um programa que faça o estancionamento de três objetos que venham de uma classe chamada pessoa, 
         onde ela vai conter quatro atributos: nome, data de nascimento, CPF, e telefone*/
        String nome;
        String dataNasc;
        String cpf;
        String telefone;


        //metodo construtor de parametros onde os atributos recebem os parametros
        public Pessoa(string nome, string dataNasc, string cpf, string telefone)
        {
            this.nome = nome;
            this.dataNasc = dataNasc;
            this.cpf = cpf;
            this.telefone = telefone;

        }
      
        public override string ToString() //metodo que retorna os parametros em string p usuário
        {
            return "Nome: " + nome + "\t|Data de Nascimento: " + dataNasc + "\t|CPF: " + cpf + "\t|Telefone: " + telefone;
        }
    }
}
