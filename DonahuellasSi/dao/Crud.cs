using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonahuellasSi.dao
{
    internal interface Crud<T>
    {
        bool Insertar(T t);
        List<T> Listar();
        bool Eliminar(int id);
        bool Actualizar(T t);
        T BuscarPorId(int id);
    }
}
