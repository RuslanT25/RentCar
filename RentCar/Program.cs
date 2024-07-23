using Autofac;
using AutoMapper;
using Data;
using Data.Mappers;
using Repository.Contracts;
using Repository.Implementations;
using ApplicationContext = Data.ApplicationContext;

namespace RentCar
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationContext context = new ApplicationContext();

            IUserRepository userRepo = new UserRepository(context);
            ICustomerRepository customerRepo = new CustomerRepository(context);
            ICarRepository carRepo = new CarRepository(context);
            IExtraRepository extraRepo = new ExtraRepository(context);
            ITransmissionRepository transmissionRepo = new TransmissionRepository(context);
            ICategoryRepository categoryRepo = new CategoryRepository(context);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapProfile>();
            });

            IMapper mapper = config.CreateMapper();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Frm_Loading(userRepo, categoryRepo, carRepo, customerRepo, transmissionRepo, extraRepo, mapper));
        }
    }
}