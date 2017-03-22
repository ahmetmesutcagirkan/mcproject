using BlackOs.Interfaces;
using BlackOs.MessageSenders;
using BlackOs.Loggers;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackOs
{
    public static class IocUtil
    {
        private static IWindsorContainer _container = null;
        private static IWindsorContainer Container
        {
            get
            {
                if (_container == null)
                {
                    _container = BootstrapContainer();
                }
                return _container;
            }
        }

        private static IWindsorContainer BootstrapContainer()
        {
            //config dosyasından tanımlamalar için bu kod açık olmalı.
            //return new WindsorContainer(new XmlInterpreter(new ConfigResource("castle")));

            //Kod tarafından tanımlama için aşağıdaki kod açık olmalı.
            return new WindsorContainer().Register(
                    Component.For<Interceptor>().LifeStyle.Transient,
                    Component.For<IMessageSenders>().ImplementedBy<MailSender>().Interceptors<Interceptor>(),
                    Component.For<ILogger>().ImplementedBy<DbLogger>().Interceptors<Interceptor>()
            );
        }
        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
