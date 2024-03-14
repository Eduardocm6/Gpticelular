using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gpticelular.AccesoDatos.Repositorio.IRepositorio
{
    internal interface IUnidadTrabajo  : IDisposable
    {
        IAlmacenRepositorio Almacen { get; }
        Task Guardar();
    }
}
