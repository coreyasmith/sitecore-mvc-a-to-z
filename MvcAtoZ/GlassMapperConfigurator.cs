using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Sitecore;
using Sitecore.DependencyInjection;

namespace MvcAtoZ
{
    public class GlassMapperConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ISitecoreService>(sp => new SitecoreService(Context.Database));
            serviceCollection.AddScoped<IMvcContext>(sp => new MvcContext(sp.GetService<ISitecoreService>()));
        }
    }
}
