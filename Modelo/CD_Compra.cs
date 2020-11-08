using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_C_SHARP.Modelo
{
    class CD_Compra
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarCliente()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrar_clientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarDomiciliario()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrar_domiciliario";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarMenu()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrar_menu";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarCompras()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrar_compras";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(int id_cli, int id_dom, int id_men, int cant, string fecha, string entregado)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertar_compra";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_cli", id_cli);
            comando.Parameters.AddWithValue("@id_dom", id_dom);
            comando.Parameters.AddWithValue("@id_men", id_men);
            comando.Parameters.AddWithValue("@cant", cant);
            comando.Parameters.AddWithValue("@fecha_com", fecha);
            comando.Parameters.AddWithValue("@entrega_rec", entregado);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(int id_cli, int id_dom, int id_men, int cant, string fecha, string entregado, int id)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editar_compra";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_cli", id_cli);
            comando.Parameters.AddWithValue("@id_dom", id_dom);
            comando.Parameters.AddWithValue("@id_men", id_men);
            comando.Parameters.AddWithValue("@cant", cant);
            comando.Parameters.AddWithValue("@fecha_com", fecha);
            comando.Parameters.AddWithValue("@entrega_rec", entregado);
            comando.Parameters.AddWithValue("@id_com", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminar_compra";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_com", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
