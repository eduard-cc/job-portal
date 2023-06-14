using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalInfrastructure.Helpers;

public static class ConnectionStringHelper
{
    public static string GetConnectionString()
    {
        // from App.config
        return ConfigurationManager.ConnectionStrings["JobPortalDatabase"].ConnectionString;
    }
}
