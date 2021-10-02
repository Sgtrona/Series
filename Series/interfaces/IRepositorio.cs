using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Autor: Luiz Felipe Lopes da Silva

namespace Series.interfaces
{
    interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaId(int id);

        void Insere(T entidade);

        void Exclui(int id);
        void Atualiza(int id, T entidade);

        int ProximoId();

    }
}
