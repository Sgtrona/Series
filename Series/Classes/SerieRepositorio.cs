using Series.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Autor: Luiz Felipe Lopes da Silva

namespace Series
{
    class SerieRepositorio : IRepositorio<Serie>
    {


        private List<Serie> listaSerie = new List<Serie>();


        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;

        }

        public void Exclui(int id)
        {
            listaSerie[id].Exclui();

        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);

        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaId(int id)
        {

            return listaSerie[id];

        }
    }
}
