using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonahuellasSi.dao
{
    internal interface Crud<T>
    {
        bool insertar(T t);
        List<T> listar();
        bool eliminar(int id);
        bool actualizar(T t);
        T buscarPorId(int id);
    }
}
