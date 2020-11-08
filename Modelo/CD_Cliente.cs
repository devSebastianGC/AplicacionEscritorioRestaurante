using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante_C_SHARP.Modelo
{
    class CD_Cliente
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrar_clientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string genero, string telefono, string direccion)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertar_cliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre_cli", nombre);
            comando.Parameters.AddWithValue("@genero_cli", genero);
            comando.Parameters.AddWithValue("@telefono_cli", telefono);
            comando.Parameters.AddWithValue("@direccion_cli", direccion);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string nombre, string genero, string telefono, string direccion, int id)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editar_cliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre_cli", nombre);
            comando.Parameters.AddWithValue("@genero_cli", genero);
            comando.Parameters.AddWithValue("@telefono_cli", telefono);
            comando.Parameters.AddWithValue("@direccion_cli", direccion);
            comando.Parameters.AddWithValue("@id_cli", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminar_cliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_cli", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
