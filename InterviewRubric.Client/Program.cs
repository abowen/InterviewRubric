using InterviewRubric.Client.Pages.Add;
using InterviewRubric.Shared;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace InterviewRubric.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                services.Add(ServiceDescriptor.Singleton<AppState, AppState>());
                services.Add(ServiceDescriptor.Transient<ViewModel, ViewModel>());
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
