using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_C_SHARP.Modelo
{
    class CD_Empleado
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrar_domiciliario";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string genero, string telefono)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertar_domiciliario";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre_dom", nombre);
            comando.Parameters.AddWithValue("@genero_dom", genero);
            comando.Parameters.AddWithValue("@telefono_dom", telefono);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string nombre, string genero, string telefono, int id)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editar_domiciliario";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre_dom", nombre);
            comando.Parameters.AddWithValue("@genero_dom", genero);
            comando.Parameters.AddWithValue("@telefono_dom", telefono);
            comando.Parameters.AddWithValue("@id_dom", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminar_domiciliario";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_dom", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
