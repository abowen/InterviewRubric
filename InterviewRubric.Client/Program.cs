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
                // Add any custom services here
                services.Add(ServiceDescriptor.Singleton<AppState, AppState>());
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
