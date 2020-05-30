using Microsoft.Extensions.DependencyInjection;
using Shiny.Prism;
using Shiny;
using System;
using System.Collections.Generic;
using System.Text;
using Prism.Container.Extensions;

namespace FrameTranslate
{
    public class ShinyAppStartup : PrismStartup
    {
        public ShinyAppStartup():base()
        {

        }
        protected override void ConfigureServices(IServiceCollection services)
        {
        }
    }
}
