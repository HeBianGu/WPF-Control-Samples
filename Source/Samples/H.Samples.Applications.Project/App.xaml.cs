using H.Extensions.ApplicationBase;
using H.Themes.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace H.Samples.Applications.Project;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : ApplicationBase
{
    protected override void ConfigureServices(IServiceCollection services)
    {
        //  Do ：使用默认配置
        services.AddApplicationServices();
        services.AddProject();
    }

    protected override void Configure(IApplicationBuilder app)
    {
        //  Do ：启用默认配置，会把这些配置添加到系统设置页面中
        app.UseApplicationOptions();
        app.UseProjectOptions();
    }

    protected override Window CreateMainWindow(StartupEventArgs e)
    {
        return new MainWindow();
    }
}
