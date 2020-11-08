using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_C_SHARP.Modelo
{
    class CD_Categoria
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrar_categoria";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertar_categoria";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre_cat", nombre);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string nombre, int id)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editar_categoria";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre_cat", nombre);
            comando.Parameters.AddWithValue("@id_cat", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminar_categoria";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_cat", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
