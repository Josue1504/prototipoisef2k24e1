﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo_CompraVenta
{
    class Conexion
    {
        public OdbcConnection conectar()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=colchoneria1");

            try
            {
                conectar.Open();
                return conectar;
            }
            catch (OdbcException ex)
            {

                Console.WriteLine("No conecto la Base de Datos ", ex);
                return null;
            }
        }
    }
}
