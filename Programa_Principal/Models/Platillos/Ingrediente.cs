using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Principal.Models
{
    public class Ingrediente
    {
        private int nocodigo_Ingrediente;
        private string nombre_Ingrediente;
        private int id_Proveedor;
        private SqlMoney precio;
        //----------------------------
        private static List<Ingrediente> lista = new List<Ingrediente>();
        private static Ingrediente ingre;

        public int NoCodigo_Ingrediente { get => nocodigo_Ingrediente; set => nocodigo_Ingrediente = value; }
        public string Nombre_Ingrediente { get => nombre_Ingrediente; set => nombre_Ingrediente = value; }

        public int Id_Proveedor { get => id_Proveedor; set => id_Proveedor = value; }
        public SqlMoney Precio { get => precio; set => precio = value; }

        public static List<string> GetIngredientesDeUnPlatillo()
        {
            var listaingredientes = new List<string>();
            SqlConnection SqlCon = new SqlConnection(Controllers.ConnectionClass.Connection);
            try
            {
                SqlCon.Open();
                string SqlQuery = "select Nombre_Ingrediente as Ingrediente from Ingredientes";
                SqlCommand Sqlcmd = new SqlCommand(SqlQuery, SqlCon);
                SqlDataReader Sqlrdr = Sqlcmd.ExecuteReader();

                while (Sqlrdr.Read())
                {
                    listaingredientes.Add(Sqlrdr[0].ToString());
                }
                Sqlrdr.Close();
                SqlCon.Close();
            }
            catch (Exception ex)
            {
                listaingredientes = null;
                MessageBox.Show("Problema con la base de datos " + ex.Message);
            }
            finally
            {
                SqlCon.Close();
            }
            return listaingredientes;
        }
        /// <summary>
        /// Buscar mediante el nombre y buscar el precio
        /// </summary>
        /// <param name="Ingrediente"></param>
        /// <returns>Retorna la lista de ingredientes a agregar en el datagriedview</returns>
        public static List<Ingrediente> AdddgvExtra(string Ingrediente)
        {
            SqlConnection SqlCon = new SqlConnection(Controllers.ConnectionClass.Connection);
            try
            {
                SqlCon.Open();
                string SqlQuery = "select Nombre_Ingrediente as Ingrediente, Precio from Ingredientes where Nombre_Ingrediente = @NameIngrediente";
                SqlCommand Sqlcmd = new SqlCommand(SqlQuery, SqlCon);
                Sqlcmd.Parameters.AddWithValue("@NameIngrediente", Ingrediente);
                SqlDataReader Sqlrdr = Sqlcmd.ExecuteReader();
                while (Sqlrdr.Read())
                {
                    lista.Add(new Ingrediente() 
                    { 
                        Nombre_Ingrediente = Sqlrdr[0].ToString(), 
                        precio = (SqlMoney)Sqlrdr[1]
                    });
                }
                Sqlrdr.Close();
                SqlCon.Close();
            }
            catch (Exception ex)
            {
                lista = null;
                MessageBox.Show("Problema con la base de datos " + ex.Message);
            }
            finally
            {
                SqlCon.Close();
            }
            return lista;
        }
        public static List<Ingrediente> RemovedgvExtra(string v)
        {
            if (v != null)
            {
                lista.ForEach(x =>
                    {
                        if (x.Equals(v))
                            ingre = x;
                    });
                lista.Remove(ingre); 
                return lista;
            }
            else 
            {
                MessageBox.Show("Debe seleccionar un producto " );
                return null;
            }
        }
    }
}
