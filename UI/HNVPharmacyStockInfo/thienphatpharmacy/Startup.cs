using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HNVPharmacyStockInfo.Startup))]
namespace HNVPharmacyStockInfo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
