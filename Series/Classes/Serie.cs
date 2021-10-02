
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Autor: Luiz Felipe Lopes da Silva

namespace Series
{
    class Serie : EntidadeBase
    {
        private object p;

        private Genero Genero { get; set; }
        private String Titulo { get; set; }
        private String Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero " + this.Genero + Environment.NewLine;
            retorno += "Titulo  " + this.Titulo + Environment.NewLine;
            retorno += "Descricao " + this.Descricao + Environment.NewLine;
            retorno += "Ano de inicio " + this.Ano + Environment.NewLine;
            retorno += "Excluido " + this.Excluido;
            return retorno;        
        }


        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public void Exclui()
        {
            this.Excluido = true;
        }

        public bool RetornaExcluido()
        {
            return this.Excluido;
        }
    }

    
}
