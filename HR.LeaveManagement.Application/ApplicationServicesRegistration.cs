using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HR.LeaveManagement.Application {
    public static class ApplicationServicesRegistration {
        /*
         'this' keyword - Extension methods allow developers to add 
        new methods to the public contract of an existing CLR type, 
        without having to sub-class it or recompile the original type. 
        Extension Methods help blend the flexibility of "duck typing" 
        support popular within dynamic languages today with the performance 
        and compile-time validation of strongly-typed languages.
         */
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services) {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            // variant 2
            //services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
