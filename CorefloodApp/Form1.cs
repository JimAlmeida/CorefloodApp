using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

using CorefloodApp.Components;

using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

using MatBlazor;

namespace CorefloodApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();

            //must come before BlazorWebView, otherwise it won't work.
            serviceCollection.AddBlazorise(options =>
            {
                options.ChangeTextOnKeyPress = true; // optional
            })
            .AddBootstrapProviders()
            .AddFontAwesomeIcons();

            serviceCollection.AddMatBlazor();

            serviceCollection.AddBlazorWebView();
            

            var blazor = new BlazorWebView()
            {
                Dock = DockStyle.Fill,
                HostPage = "wwwroot/index.html",
                Services = serviceCollection.BuildServiceProvider(),
            };

            blazor.RootComponents.Add<Index>("#app");
          
            Controls.Add(blazor);
        }

    }
}
