using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_bd
{
    public class claseConexion
    {
        public static SqlConnection con;
        public static void abrir()
        {
            try
            {
                string cadena = "data source = .\\SQLEXPRESS; initial catalog = BDUTN;Integrated Security = True";
                con = new SqlConnection(cadena);
                con.Open();
               // MessageBox.Show("conectado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void cerrar()
        {
            con.Close();
        }
        //metodo generico para traer listas
        public static DataTable listaDatos(string query)
        {
            try
            {
                DataTable memoria = new DataTable();
                abrir();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader lector;
                lector = cmd.ExecuteReader();
                memoria.Load(lector);
                return memoria;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                cerrar();
            }
        }
        //metodo generico para realizer acciones insert delete y update
        public static void accionSQL(string query)
        {
            try
            {
                abrir();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cerrar();
            }
        }
    }
}
