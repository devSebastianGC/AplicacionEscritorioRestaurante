using Restaurante_C_SHARP.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_C_SHARP.Controlador
{
    class CN_Categoria
    {
        private CD_Categoria objetoCD = new CD_Categoria();

        public DataTable MostrarCat()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarCat(string nombre)
        {
            objetoCD.Insertar(nombre);
        }

        public void EditarCat(string nombre, string id)
        {
            objetoCD.Editar(nombre, Convert.ToInt32(id));
        }

        public void EliminarCat(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
