using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinqToExcel.Startup))]
namespace LinqToExcel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
