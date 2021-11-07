using System;
using System.Collections.Generic;
using Series.Interfaces;

namespace Series
{
    public class SerieRepositorio : IRepositorio<Serie> //herdando a interface "IRepositorio"
    {
        private List<Serie> listaSerie = new List<Serie>(); //lista das series
        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;

        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir(); //marca This.Excluido com true
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count; //O COUNT vai ao ultimo elemento da lista, e mostra o proximo
        }

        public Serie RetornaPorId(int id)
        {   
            return listaSerie[id];
        }

    }
}