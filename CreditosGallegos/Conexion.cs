using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
namespace CreditosGallegos
{
    class Conexion
    {
        public static OracleConnection conectar()
        {
            /*SqlConnection cn = new SqlConnection
                ("SERVER=LAPTOP-06K7LBH5\\SQLEXPRESS;DATABASE=Consultorio;integrated security=true");
            cn.Open();*/

            OracleConnection cn =
                new OracleConnection("DATA SOURCE = xe; PASSWORD=patito; USER ID = creditos");
            cn.Open();
            return cn;
        }
        public static OracleConnection cerrar()
        {
            OracleConnection cn = new OracleConnection("DATA SOURCE = xe; PASSWORD=patito; USER ID = consultorio");
            cn.Close();
            return cn;
        }
    }
}
