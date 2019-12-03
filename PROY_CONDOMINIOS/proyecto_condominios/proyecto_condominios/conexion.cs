using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace proyecto_condominios
{
    class conexion
    {
        public static SqlConnection Conectar() {

            SqlConnection cn = new SqlConnection("Server=LAPTOP-NTRD7E66 ;Database=Condominio ;User Id=arqui; Password=123456");
            cn.Open();
            return cn;

        }
            
    }
}
