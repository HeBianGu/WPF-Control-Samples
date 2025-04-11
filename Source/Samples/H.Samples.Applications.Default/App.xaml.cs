using H.Extensions.ApplicationBase;
using H.Themes.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace H.Samples.Applications.Default
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : ApplicationBase
    {
        protected override void ConfigureServices(IServiceCollection services)
        {
            //  Do ：使用默认配置
            services.AddApplicationServices();

            //  Do ：自定义配置
            services.AddApplicationServices(x =>
            {
                //  Do ：配置系统模块
                x.UseModulesOptions(x =>
                {
                    //  Do ：配置关于模块
                    x.UseAboutOptions(x =>
                    {
                        x.Name = "关于产品";
                        x.ProductName = "H.Samples.Applications.Default";
                        x.Version = "1.0.0";
                        x.Copyright = "Copyright © 2023 H";
                    });
                    //  Do ：配置技术支持模块
                    x.UseSupportOptions(x =>
                    {
                        x.Uri = "https://hebiangu.github.io/WPF-Control-Docs/";
                    });
                    //  Do ：配置官方网址模块
                    x.UseWebsiteOptions(x =>
                    {
                        x.Uri = "https://hebiangu.github.io/WPF-Control/Home.html";
                    });
                    //  Do ：其他配置参考上面
                });

                //  Do ：配置主题模块
                x.UseThemeModuleOptions(x =>
                {
                    x.UseThemeOptions(x =>
                    {
                        //  Do ：配置默认字体大小
                        x.FontSize = FontSizeThemeType.Large;
                    });
                });
            });
        }

        protected override void Configure(IApplicationBuilder app)
        {
            //  Do ：启用默认配置，会把这些配置添加到系统设置页面中
            app.UseApplicationOptions();
        }

        protected override Window CreateMainWindow(StartupEventArgs e)
        {
            return new MainWindow();
        }
    }
}
