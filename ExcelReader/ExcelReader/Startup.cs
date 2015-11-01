using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExcelReader.Startup))]
namespace ExcelReader
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
