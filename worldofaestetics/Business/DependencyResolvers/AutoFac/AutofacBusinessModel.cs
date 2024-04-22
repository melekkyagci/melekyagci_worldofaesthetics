using Autofac;
using Business.Abstract;
using Business.Concrate;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutofacBusinessModel : Module
    {
        protected override void Load 

        (ContainerBuilder builder)
        {
            builder.RegisterType<KullanicilarManager>().As<IKullanicilarService>().SingleInstance();
        }
    }
} 