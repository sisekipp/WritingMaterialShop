using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WritingMaterialsShop.Startup))]
namespace WritingMaterialsShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
