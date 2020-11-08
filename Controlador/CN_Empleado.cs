using Restaurante_C_SHARP.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_C_SHARP.Controlador
{
    class CN_Empleado
    {
        private CD_Empleado objetoCD = new CD_Empleado();

        public DataTable MostrarEmp()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarEmp(string nombre, string genero, string telefono)
        {
            objetoCD.Insertar(nombre, genero, telefono);
        }

        public void EditarEmp(string nombre, string genero, string telefono, string id)
        {
            objetoCD.Editar(nombre, genero, telefono, Convert.ToInt32(id));
        }

        public void EliminarEmp(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
