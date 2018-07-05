using Microsoft.Extensions.DependencyInjection;
using MvcAtoZ.Components.Card;
using MvcAtoZ.Components.Carousel;
using MvcAtoZ.Components.Jumbotron;
using MvcAtoZ.Components.Navigation;
using Sitecore.DependencyInjection;

namespace MvcAtoZ
{
    public class MvcAtoZConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<CardController>();
            serviceCollection.AddTransient<CarouselController>();
            serviceCollection.AddTransient<JumbotronController>();
            serviceCollection.AddTransient<NavigationController>();
        }
    }
}
