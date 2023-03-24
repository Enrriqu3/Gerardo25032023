using ActividadAsincrona_Semana_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadAsincrona_Semana_8.DAO
{
    public class CrudProductos
    {
        public void AgregarProductos(Producto ParametroosProductos) 
        { 
            using(AlmacenContext db = new AlmacenContext())
            {
                Producto producto = new Producto();
                producto.Nombre = ParametroosProductos.Nombre;
                producto.Descripcion = ParametroosProductos.Descripcion;
                producto.Precio = ParametroosProductos.Precio;
                producto.Stock = ParametroosProductos.Stock;
                db.Add(producto);
                db.SaveChanges();
            }
        }
    }
}
