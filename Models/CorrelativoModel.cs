using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;


namespace Models
{
  public   class CorrelativoModel
    {
        SqlConnection con = new SqlConnection();
        Conexion objCon = new Conexion();

        public DataTable View()
        {
            con = objCon.Conectar();
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("USP_SEL_CORRELATIVO", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void Add(GenmExpedientesEntity objEnt)
        {
            con = objCon.Conectar();
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "USP_INS_CORRELATIVO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.Add("@Anio",SqlDbType.Int).Value=objEnt.IdAnio;
            cmd.Parameters.Add("@Correlativo",SqlDbType.Int).Value=objEnt.Correlativo;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void Update(GenmExpedientesEntity objEnt)
        {
            con = objCon.Conectar();
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "USP_UPD_CORRELATIVO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;


            cmd.Parameters.Add("@IdAnio", SqlDbType.Int).Value = objEnt.IdAnio ;
            cmd.Parameters.Add("@Correlativo", SqlDbType.Int).Value = objEnt.Correlativo;

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Delete()
        {

        }

        public void ListCorrelativoDataGridView(DataGridView dgv)
        {
            var tabla = this.View();
            this.ListarGrid(dgv,tabla);
        }
        public void ListarGrid(DataGridView dgv,DataTable tabla)
        {
            var numeroFilas = tabla.Rows.Count;

            if (numeroFilas>0)
            {
                dgv.Rows.Clear();
                for (int i = 0; i < numeroFilas; i++)
                {
                    int idAnio =int.Parse( tabla.Rows[i][0].ToString());
                    int correlativo = int.Parse(tabla.Rows[i][1].ToString());

                    dgv.Rows.Add(idAnio,correlativo,"Editar");
                }
            }
        }
    }
}
