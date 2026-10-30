using System;
using System;
using System.Collections.Generic;
using System.Text;  
using System.Data.SqlClient; 
using Microsoft.Data.SqlClient;


namespace ProyectoFinal_Jefferson_Y_Isaac
{
    internal class ConexionBD
    {
        public static string CadenaConexion = @"Data Source=localhost;Initial Catalog=AcademiaDB;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection ObtenerConexion()
        {
            return new 
                SqlConnection(CadenaConexion);

        }




    }
}
