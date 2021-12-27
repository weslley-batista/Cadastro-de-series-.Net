using System;
namespace Series
{
    public class Serie : EntidadeBase
    {
        public Serie(Genero genero, Desenvolvedora desenvolvedora, string titulo, string descricao, int ano, bool excluido) 
        {
            this.Genero = genero;
                this.Desenvolvedora = desenvolvedora;
                this.Titulo = titulo;
                this.Descricao = descricao;
                this.Ano = ano;
                this.Excluido = excluido;
               
        }
                private Genero Genero{ get; set;}
        private Desenvolvedora Desenvolvedora{ get; set;}
        private string Titulo{ get; set;}
        private string Descricao{ get; set;}
        private int Ano{ get; set;}
        private bool Excluido { get; set;}
        //construtor
        public Serie (int id, Genero genero, Desenvolvedora desenvolvedora, string titulo, string descricao,int ano){
            this.Id =id;
            this.Genero = genero;
            this.Desenvolvedora = desenvolvedora;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        //return de String
        public override string ToString()
        {
            string  retorno="";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Desenvolvedora: " + this.Desenvolvedora + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido; 
            
            return retorno;
        }
        public string retornaTitulo(){
            return this.Titulo;
        }
        public int  retornaId(){
            return this.Id;
        }
        public void Excluir(){
            this.Excluido = true;
        }
        public bool retoraExcluido(){
            return this.Excluido;
        }
    }
}