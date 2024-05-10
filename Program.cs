using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toomeet_Pos.BLL;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DAL;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.DAL.Repositories;
using Toomeet_Pos.Entites;
using Toomeet_Pos.UI.Forms;
using Toomeet_Pos.UI.Forms.Dashboard;
using Toomeet_Pos.UI.Forms.Products;
using Toomeet_Pos.UI.Forms.Staffs;
using Toomeet_Pos.UI.Validations;

namespace Toomeet_Pos
{
    internal static class Program
    {

        public static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Add handler to handle the exception raised by main threads
            Application.ThreadException +=  new ThreadExceptionEventHandler(Application_ThreadException);

            var services = new ServiceCollection();

            ConfigureServices(services);



            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {

                ServiceProvider = serviceProvider;

                Application.ApplicationExit += new EventHandler((object sender, EventArgs e) =>
                {
                  // clean up here
                });

                Application.Run(new FrmLoading());
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // DAL
            services.AddSingleton<IDataAccessLayer, DataAccessLayer>();
            services.AddSingleton<IStoreRepository, StoreRepository>();
            services.AddSingleton<IStaffRepository, StaffRepository>();
            services.AddSingleton<IRoleRepository, RoleRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<ICategoryRepository, CategoryRepository>();
            services.AddSingleton<IBrandRepository, BrandRepository>();

            // BLL
            services.AddSingleton<IRoleService, RoleService>();
            services.AddSingleton<IStaffService, StaffService>();
            services.AddSingleton<IStoreService, StoreService>();
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<ICategoryService, CategoryService>();
            services.AddSingleton<IBrandService, BrandService>();
            services.AddSingleton<IAuthService, AuthService>();
            services.AddSingleton<IImageService, ImageService>();

            // VALIDATE
            services.AddSingleton<IAuthValidate, AuthValidate>();
            services.AddSingleton<IStaffValidate, StaffValidate>();
            services.AddSingleton<IStoreValidate, StoreValidate>();
            services.AddSingleton<IRoleValidate, RoleValidate>();
        }

      

        static void Application_ThreadException (object sender, ThreadExceptionEventArgs e)
        {// All exceptions thrown by the main thread are handled over this method

            ShowExceptionDetails(e.Exception);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // All exceptions thrown by additional threads are handled in this method
            ShowExceptionDetails(e.ExceptionObject as Exception);

            // Suspend the current thread for now to stop the exception from throwing.
            Thread.CurrentThread.Suspend();
        }

        static void ShowExceptionDetails(Exception Ex)
        {
            // Do logging of exception details
            MessageBox.Show(Ex.Message, "Đã có lỗi xảy ra! ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            Console.WriteLine("Error ================================================================ Error");
            Console.WriteLine("||");
            Console.WriteLine("||");
            Console.WriteLine("||");
            Console.WriteLine("||");

            Console.WriteLine("Error target: " + Ex.TargetSite.ToString());
            Console.WriteLine("Error message: " + Ex.Message);
            Console.WriteLine(Ex.GetBaseException().Message);

            Console.WriteLine("Error ================================================================ Error");

        }

        public static T GetService<T>() where T : class
        {
            var serviceProvider = ServiceProvider.GetService(typeof(T));
            return serviceProvider as T;
        }

    }
}
