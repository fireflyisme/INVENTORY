using FirstProgram1.Data;
using Unity.Lifetime;
using Unity;
using InfastructureLayer.Repositories;

namespace FirstProgram1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IUnityContainer UnityC = new UnityContainer();

            UnityC.RegisterType<IProgramRepository, ProgramRepository>(new HierarchicalLifetimeManager());

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var programRepository = UnityC.Resolve<IProgramRepository>();

            Application.Run(new Form1(programRepository));
        }
    }
}