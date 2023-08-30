using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using CoreLayer.Entities;
using DataLayer.Abstract;
using DataLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection services)
        {

            services.AddScoped<IChildNameManager, ChildNameManager>();
            services.AddScoped<IChildNameDal, EfChildNameDal>();

            services.AddScoped<IAnimalNameManager, AnimalNameManager>();
            services.AddScoped<IAnimalNameDal, EfAnimalNameDal>();

            services.AddScoped<IAnimalTypeDal, EfAnimalTypeDal>();
            services.AddScoped<Context>();

            return services;

        }
    }
}
