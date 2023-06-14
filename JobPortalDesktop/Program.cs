using Autofac;
using JobPortalDesktop.Forms;
using JobPortalInfrastructure.Repositories;
using JobPortalLogic.Extensions;
using JobPortalLogic.Interfaces;
using JobPortalLogic.Services;

namespace JobPortalDesktop;

internal static class Program
{
    public static IContainer Container { get; private set; }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        ApplicationConfiguration.Initialize();

        var builder = new ContainerBuilder();
        builder.RegisterType<UserRepository>().As<IUserRepository>();
        builder.RegisterType<JobRepository>().As<IJobRepository>();
        builder.RegisterType<SavedJobRepository>().As<ISavedJobRepository>();
        builder.RegisterType<ApplicationRepository>().As<IApplicationRepository>();

        builder.RegisterType<UserService>();
        builder.RegisterType<JobService>();
        builder.RegisterType<PasswordService>();
        builder.RegisterType<SavedJobService>();
        builder.RegisterType<ApplicationService>();
        builder.RegisterType<InputValidator>();

        Container = builder.Build();

        Login login = new Login();
        login.Show();
        Application.Run();
    }
}