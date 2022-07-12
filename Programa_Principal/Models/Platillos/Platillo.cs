using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Programa_Principal.Models
{
    enum Ecategoria
    {
        Carne,
        Ensalada
    }
    public class Platillo
    {
        private int codigo_Plato;
        private string nombre_Platillo;
        private string descripcion;
        private Ecategoria categoria;
        private double precio;
        //----------------------------------
        private static List<Platillo> lista = new List<Platillo>();

        public int Codigo_Plato { get => codigo_Plato; set => codigo_Plato = value; }
        public string Nombre_Platillo { get => nombre_Platillo; set => nombre_Platillo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        internal Ecategoria Categoria { get => categoria; set => categoria = value; }

        public static List<string> GetNames()
        {
            var Names = new List<string>();
            
            SqlConnection SqlCon = new SqlConnection(Controllers.ConnectionClass.Connection);
            try
            {
                SqlCon.Open();

                string SqlQuery = "select Nombre_Platllo as Nombre_Platillo from Platillos";

                SqlCommand SqlCmd = new SqlCommand(SqlQuery, SqlCon);

                SqlDataReader reader = SqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    Names.Add(reader[0].ToString());
                }
                reader.Close();
                SqlCon.Close();

            }
            catch(Exception ex)
            {
                Names = null;
                MessageBox.Show("Problema con la base de datos " + ex.Message);
            }
            finally
            {
                SqlCon.Close();
            }


            return Names;
        }
        internal static List<Platillo> AddPlatillo(string v)
        {
            SqlConnection SqlCon = new SqlConnection(Controllers.ConnectionClass.Connection);
            try
            {
                SqlCon.Open();
                string SqlQuery = "select Codigo_Plato, Nombre_Platllo, Precio, Tipo_Categoria from Platillos where Nombre_Platllo = @NameIngrediente";
                SqlCommand Sqlcmd = new SqlCommand(SqlQuery, SqlCon);
                Sqlcmd.Parameters.AddWithValue("@NameIngrediente", v);
                SqlDataReader Sqlrdr = Sqlcmd.ExecuteReader();
                while (Sqlrdr.Read())
                {
                    lista.Add(new Platillo()
                    {
                        Codigo_Plato = (int)Sqlrdr[0],
                        Nombre_Platillo = Sqlrdr[1].ToString(),
                        Precio = (double)Sqlrdr[2],
                        Categoria = (Ecategoria)Sqlrdr[3],
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
    }
}
