using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract; 
using Business.Concrete;
using Business.MessageBrokers.RabbitMq;
using Castle.DynamicProxy;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using SeturAssessment.ContactService.Business.Abstract;
using SeturAssessment.ContactService.Business.Concrete;
using SeturAssessment.ContactService.DataAccess.Abstract;
using SeturAssessment.ContactService.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {




            builder.RegisterType<ContactManager>().As<IContactService>().SingleInstance();
            builder.RegisterType<ContactRepository>().As<IContactRepository>().SingleInstance();


            builder.RegisterType<ContactInformationManager>().As<IContactInformationService>().SingleInstance();
            builder.RegisterType<ContactInformationRepository>().As<IContactInformationRepository>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<UserRepository>().As<IUserRepository>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            builder.RegisterType<ReportManager>().As<IReportService>().SingleInstance();
            builder.RegisterType<ReportRepository>().As<IReportRepository>().SingleInstance();
            builder.RegisterType<MqQueueHelper>().As<IMessageBrokerHelper>().SingleInstance();

        }
    }
}
