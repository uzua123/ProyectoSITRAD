using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entity;
using System.Windows.Forms;

namespace Models
{
  public  class MultiTablaModel
    {
        SqlConnection con = new SqlConnection();
        Conexion objCon = new Conexion();

        public DataTable View()
        {
            //    SqlConnection cn = new SqlConnection();
            //    cn.ConnectionString = Conexion.cone;
            //    cn.Open();
            con = objCon.Conectar();
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("USP_SEL_MULTITABLA", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void Add(RcdMultiTablaEntity obj)
        {
            con = objCon.Conectar();
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "USP_INS_MULTITABLA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.Add("@IdTabla", SqlDbType.Int).Value = obj.IdTabla;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100).Value = obj.Descripcion1;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void Update(RcdMultiTablaEntity obj)
        {
            con = objCon.Conectar();
            con.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "USP_UPD_MULTITABLA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.Add("@IdTabla", SqlDbType.Int).Value = obj.IdTabla;
            cmd.Parameters.Add("@IdSubTabla", SqlDbType.Int).Value = obj.IdTablaDetalle;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100).Value = obj.Descripcion1;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

        }


        public void Delete(RcdMultiTablaEntity obj)
        {
            con = objCon.Conectar();
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "USP_DEL_MULTITABLA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.Add("@IdTabla", SqlDbType.Int).Value = obj.IdTabla;
            cmd.Parameters.Add("@IdSubTabla", SqlDbType.Int).Value = obj.IdTablaDetalle;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable SearchIdTabla(RcdMultiTablaEntity obj)
        {
            con = objCon.Conectar();
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("USP_SEL_MULTITABLA", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@CodigoTabla", SqlDbType.Int).Value = obj.IdTabla;
            //da.SelectCommand.Parameters.Add("@CodigoValor1",SqlDbType.Int).Value=obj.IdTablaDetalle;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void ListMultiTablaPorIdTabla(DataGridView dgv, RcdMultiTablaEntity obj)
        {
            var tabla = this.SearchIdTabla(obj);
            this.ListarGrid(dgv, tabla);
        }
        public void ListMultiTablaPorDataGridView(DataGridView dgv)
        {
            var tabla = this.View();
            this.ListarGrid(dgv, tabla);
        }

        public void ListarGrid(DataGridView dgv, DataTable tabla)
        {
            var numeroFilas = tabla.Rows.Count;

            if (numeroFilas > 0)
            {
                dgv.Rows.Clear();
                for (int i = 0; i < numeroFilas; i++)
                {
                    int idtabla = int.Parse(tabla.Rows[i][0].ToString());
                    string descripcion = tabla.Rows[i][1].ToString();
                    string iddetalletabla = tabla.Rows[i][2].ToString();
                    string valor1 = tabla.Rows[i][3].ToString();
                    string descripcion1 = tabla.Rows[i][4].ToString();
                    string valor2 = tabla.Rows[i][5].ToString();
                    string descripcion2 = tabla.Rows[i][6].ToString();


                    dgv.Rows.Add(idtabla, descripcion, iddetalletabla, valor1, descripcion1, valor2, descripcion2, "Editar", "Eliminar");
                }
            }
        }
    }
}
