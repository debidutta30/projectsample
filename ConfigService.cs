using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBDDProject.Utility
{
    internal class ConfigService
    {
        public void ConfigServicePasswordProtected(IServiceCollection serviceCollection)
        {
            //serviceCollection.Configure<IdentityOption>(AssertionOptions =>
            //{
            //    AssertionOptions.PasswordProtected = true;  
            //});
        }
    }
}
