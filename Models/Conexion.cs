﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
 public   class Conexion
    {
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

            return cn;

        }

        public static string cone = "Data Source=DESKTOP-S3RV3R;Initial Catalog=Sitradoc;Integrated Security=True";
    }
}
