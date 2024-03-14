using Gpticelular.AccesoDatos.Repositorio.IRepositorio;
using Gpticelular.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gpticelular.AccesoDatos.Repositorio
{
    public class AlmacenRepositorio : Repositorio<Almacen>, IAlmacenRepositorio
    {
        private readonly ApplicationDbContext _db;

        public AlmacenRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Almacen almacen)
        {
            var almacenBD = _db.Almacenes.FirstOrDefault(b =>  b.Id == almacen.Id);
            if(almacenBD != null) 
            {
                almacenBD.Nombre = almacen.Nombre; 
                almacenBD.Descripcion = almacen.Descripcion;
                almacenBD.Status = almacen.Status;
                _db.SaveChanges();

            }
        }
    }
}
