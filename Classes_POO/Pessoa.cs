using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_POO
{
    class Pessoa
    {
        //Atributos da minha classe
        private string nome;
        private int idade;

        //metodos get e set
        //get vai pegar
        //set vai gravar

        //set
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        //get

        public string getNome()
        {
            return this.nome;
        }

        public int getIdade()
        {
            return this.idade;
        }
    }
}
