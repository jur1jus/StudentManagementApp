using Microsoft.Extensions.DependencyInjection;
using StudentManagementApp.Repositories;

namespace StudentManagementApp
{
    internal static class Program
    {
        const string DB_CONNECTION_STRING = "Data Source=.\\StudentManagement.sqlite; Version=3; New=True; Compress=True";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var serviceProvider = GetServiceProvider();
            DIContainer.Initialize(serviceProvider);

            var dashboardForm = serviceProvider.GetRequiredService<Dashboard>();

            Application.Run(dashboardForm);
        }

        static ServiceProvider GetServiceProvider()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<Dashboard>();
            serviceCollection.AddScoped<IDepartmentRepository>(x =>
            {
                return new DepartmentRepository(DB_CONNECTION_STRING);
            });

            serviceCollection.AddScoped<IStudentRepository>(x =>
            {
                return new StudentRepository(DB_CONNECTION_STRING);
            });

            serviceCollection.AddScoped<ILectureRepository>(x =>
            {
                return new LectureRepository(DB_CONNECTION_STRING);
            });

            return serviceCollection.BuildServiceProvider();
        }
    }
}