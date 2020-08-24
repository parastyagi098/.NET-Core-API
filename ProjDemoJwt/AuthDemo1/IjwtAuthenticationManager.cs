using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo1
{
     public interface IjwtAuthenticationManager
    {
       string Authenticate(string username, string password);
    }
}
