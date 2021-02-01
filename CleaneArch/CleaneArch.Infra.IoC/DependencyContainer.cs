using CleaneArch.Application.Interfaces;
using CleaneArch.Application.Services;
using CleaneArch.Domain.CommandHandlers;
using CleaneArch.Domain.Commands;
using CleaneArch.Domain.Core.Bus;
using CleaneArch.Domain.Interfaces;
using CleaneArch.Infra.Bus;
using CleaneArch.Infra.Data.Context;
using CleaneArch.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleaneArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR

            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers 
            services.AddScoped<IRequestHandler<CreateCourseCommand,bool>, CourseCommandHandler>();


            // Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();

            //Infra.Data Layer
            services.AddScoped<UniversityDBContext>();

        }
    }
}
