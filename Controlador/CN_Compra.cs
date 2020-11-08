using Restaurante_C_SHARP.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_C_SHARP.Controlador
{
    class CN_Compra
    {
        private CD_Compra objetoCD = new CD_Compra();

        public DataTable MostrarCli()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCliente();
            return tabla;
        }

        public DataTable MostrarDom()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarDomiciliario();
            return tabla;
        }

        public DataTable MostrarMenu()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarMenu();
            return tabla;
        }

        public DataTable MostrarCompras()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCompras();
            return tabla;
        }

        public void InsertarEmp(string id_cli, string id_dom, string id_men, string cant, string fecha, string entregado)
        {
            objetoCD.Insertar(Convert.ToInt32(id_cli), Convert.ToInt32(id_dom), Convert.ToInt32(id_men), Convert.ToInt32(cant), fecha, entregado);
        }

        public void EditarEmp(string id_cli, string id_dom, string id_men, string cant, string fecha, string entregado, string id)
        {
            objetoCD.Editar(Convert.ToInt32(id_cli), Convert.ToInt32(id_dom), Convert.ToInt32(id_men), Convert.ToInt32(cant), fecha, entregado, Convert.ToInt32(id));
        }

        public void EliminarEmp(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
