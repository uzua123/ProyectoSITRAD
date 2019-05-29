using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Models
{
  public  class TipoDocumentoModel
    {
        SqlConnection con = new SqlConnection();
        Conexion objCon = new Conexion();


        public DataTable View()
        {
            //SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = Conexion.con;
            //cn.Open();
            con = objCon.Conectar();
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("USP_SEL_TIPODOCUMENTO", con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;



        }

        public void Add(GenmTipoDocumentoEntity objTipoEnt)
        {
            con = objCon.Conectar();
            con.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "USP_INS_TIPODOCUMENTO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //cmd.Parameters.Add("ID_TIPO_DOCUMENTO", SqlDbType.Int).Value = objTipoEnt.IdTipoDocumento;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = objTipoEnt.Descripcion;
            // cmd.Parameters.Add("DESTADO",SqlDbType.NVarChar,1).Value=objTipoEnt.Estado;
            cmd.Parameters.Add("@Sigla", SqlDbType.NVarChar, 20).Value = objTipoEnt.Sigla;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {


                throw;
            }
        }

        public void Update(GenmTipoDocumentoEntity objTypeDoc)
        {
            con = objCon.Conectar();
            con.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "USP_UPD_TIPODOCUMENTO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = objTypeDoc.IdTipoDocumento;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = objTypeDoc.Descripcion;
            cmd.Parameters.Add("@Sigla", SqlDbType.NVarChar, 20).Value = objTypeDoc.Sigla;
            cmd.Parameters.Add("@Estado", SqlDbType.NVarChar, 1).Value = objTypeDoc.Estado;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {


                throw;
            }

        }

        public void Delete(GenmTipoDocumentoEntity objTypeDoc)
        {
            con = objCon.Conectar();
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "USP_DEL_TIPODOCUMENTO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = objTypeDoc.IdTipoDocumento;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }


        }

        public DataTable SearchTIpoDocumento(string textoDescripcion)
        {
            con = objCon.Conectar();
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SP_BUSCA_TIPODOCUMENTO_POR_DESCRIPCION", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@texto", SqlDbType.VarChar, 50).Value = textoDescripcion;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }


        public DataTable SearchId(GenmTipoDocumentoEntity objTypeDoc)
        {
            con = objCon.Conectar();
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SP_BUSCA_TIPODOCUMENTO_POR_ID", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = objTypeDoc.IdTipoDocumento;
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void ListTipoDocumentPorDataGriview(DataGridView dgv)
        {
            var tabla = this.View();
            this.ListarGrid(dgv, tabla);
        }
        public void SearchTipoDocumentoDescripcion(DataGridView dgv, GenmTipoDocumentoEntity objTipDoc)
        {

            var tabla = this.SearchTIpoDocumento(objTipDoc.Descripcion);
            this.ListarGrid(dgv, tabla);
        }

        public void ListarGrid(DataGridView dgv, DataTable tabla)
        {
            var numero_filas = tabla.Rows.Count;
            if (numero_filas > 0)
            {
                dgv.Rows.Clear();

                for (int i = 0; i < numero_filas; i++)
                {
                    string descripcion = tabla.Rows[i][1].ToString();
                    string sigla = tabla.Rows[i][2].ToString();
                    string estado = tabla.Rows[i][3].ToString();

                    int idcategoria = int.Parse(tabla.Rows[i][0].ToString());

                    dgv.Rows.Add(idcategoria, descripcion, sigla, estado, "Editar", "Eliminar");
                }
            }

        }
    }
}
