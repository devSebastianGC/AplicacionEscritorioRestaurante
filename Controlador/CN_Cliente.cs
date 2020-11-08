using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurante_C_SHARP.Modelo;
using System.Data;

namespace Restaurante_C_SHARP.Controlador
{
    class CN_Cliente
    {
        private CD_Cliente objetoCD = new CD_Cliente();

        public DataTable MostrarCli()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarCli(string nombre, string genero, string telefono, string direccion)
        {
            objetoCD.Insertar(nombre, genero, telefono, direccion);
        }

        public void EditarCli(string nombre, string genero, string telefono, string direccion, string id)
        {
            objetoCD.Editar(nombre, genero, telefono, direccion, Convert.ToInt32(id));
        }

        public void EliminarCli(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
