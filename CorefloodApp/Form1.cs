using CorefloodApp.wwwroot;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

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

            serviceCollection.AddBlazorWebView();
            
            
            
            var blazor = new BlazorWebView()
            {
                Dock = DockStyle.Fill,
                HostPage = "wwwroot/index.html",
                Services = serviceCollection.BuildServiceProvider(),
            };

            blazor.RootComponents.Add<SimForm>("#form");
            blazor.RootComponents.Add<ChartScreen>("#chartscreen");
            Controls.Add(blazor);
        }

    }
}
