using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_C_SHARP.Modelo
{
    class CD_Menu
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrar_menu";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string descripcion, float precio)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertar_menu";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre_men", nombre);
            comando.Parameters.AddWithValue("@descripcion_men", descripcion);
            comando.Parameters.AddWithValue("@precio_men", precio);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string nombre, string descripcion, float precio, int id)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editar_menu";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre_men", nombre);
            comando.Parameters.AddWithValue("@descripcion_men", descripcion);
            comando.Parameters.AddWithValue("@precio_men", precio);
            comando.Parameters.AddWithValue("@id_men", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            //Procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminar_menu";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_men", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
