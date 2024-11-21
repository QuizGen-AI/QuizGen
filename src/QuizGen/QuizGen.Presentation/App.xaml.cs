﻿using Microsoft.UI.Xaml;
using System;
using Microsoft.Extensions.DependencyInjection;
using QuizGen.BLL.Configuration;
using QuizGen.BLL.Services.Interfaces;
using QuizGen.Presentation.Views;
using QuizGen.DAL.Extensions;
using QuizGen.BLL.Extensions;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace QuizGen.Presentation
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        private Window m_window;
        internal readonly IServiceProvider ServiceProvider;
        private readonly IAuthStateService _authStateService;

        public static Window MainWindow { get; private set; }

        public App()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();
            
            _authStateService = ServiceProvider.GetRequiredService<IAuthStateService>();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            var config = new AppConfig
            {
                DatabaseConnectionString = "Server=localhost;Port=5432;Database=quizgen;User Id=postgres;Password=1111;",
                LocalSettingsPath = System.IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "QuizGen")
            };

            services.AddDataAccessLayer(config.DatabaseConnectionString);
            services.AddBusinessLogicLayer(config);
        }

        protected override async void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            await _authStateService.LoadSavedStateAsync();

            if (_authStateService.IsAuthenticated)
            {
                m_window = new MainWindow(ServiceProvider);
            }
            else
            {
                m_window = new LoginWindow(ServiceProvider);
            }

            MainWindow = m_window;
            m_window.Activate();
        }
    }
}
