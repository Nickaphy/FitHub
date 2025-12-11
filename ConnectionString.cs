using FitHub._2._BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitHub.B_BLL;
using FitHub.B_BLL.ENT_OBJ;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;


namespace FitHub
{
    public class ConnectionString
    {
        public readonly string conn =
         "Server=NICKLAS;Database=FitHubDB;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

    }
}
