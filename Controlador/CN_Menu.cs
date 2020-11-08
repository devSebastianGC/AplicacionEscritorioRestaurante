using Restaurante_C_SHARP.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_C_SHARP.Controlador
{
    class CN_Menu
    {
        private CD_Menu objetoCD = new CD_Menu();

        public DataTable MostrarMen()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarMen(string nombre, string descripcion, string precio)
        {
            objetoCD.Insertar(nombre, descripcion, Convert.ToInt32(precio));
        }

        public void EditarMen(string nombre, string descripcion, string precio, string id)
        {
            objetoCD.Editar(nombre, descripcion, Convert.ToInt32(precio), Convert.ToInt32(id));
        }

        public void EliminarMen(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
