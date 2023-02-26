using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core.Wrapper
{
    /// <summary>
    /// Wrapperklasse für den aktuell genutzten IoC-Container. 
    /// Derzeit: Autofac
    /// </summary>
    public class IoCWrapper
    {
        private IContainer _container;
 
        public IoCWrapper(IoCInitializator initMethod) { _container = initMethod.Build(); }


        /// <summary>
        /// Baut mittels des Autofac-Containers mit dem übergebenen Key den übergebenen Typ zusammen
        /// </summary>
        /// <typeparam name="T">Der Typ / Das Interface des Objektes, welches erstellt werden soll</typeparam>
        /// <param name="key">Der key, der den Typen näher differnziert</param>
        /// <returns></returns>
        public T Resolve<T>(string key) where T : class
        {
            return _container.ResolveNamed<T>(key);
        }

        /// <summary>
        /// Baut mittels des Autofac-Containers ein Objekt zusammen
        /// </summary>
        /// <typeparam name="T">Der Typ / Das Interface des Objektes, welches erstellt werden soll</typeparam>
        /// <returns></returns>
        public T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }


        /// <summary>
        /// Klasse zum Initalisieren des IoC-Containers
        /// </summary>
        public class IoCInitializator
        {
            private readonly ContainerBuilder _builder;

            public IoCInitializator() { _builder = new ContainerBuilder(); }



            /// <summary>
            /// Registriert eine Instanz vom Typ T im IoC-Container
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="instance"></param>
            public void RegisterInstance<T>(T instance) where T : class
            {
                _builder.RegisterInstance(instance);
            }

            /// <summary>
            /// Registriert einen Typ, der von einem Interface ableitet im IoC-Container
            /// </summary>
            /// <typeparam name="I"></typeparam>
            /// <typeparam name="T"></typeparam>
            public void Register<I, T>() where T : I where I : class
            {
                _builder.RegisterType<T>().As<I>();
            }

            /// <summary>
            /// Registriert einen einzelnen Typ im IoC-Container, damit dieser resolved werden kann
            /// </summary>
            /// <typeparam name="T"></typeparam>
            public void Register<T>() where T : class
            {
                _builder.RegisterType<T>();
            }

            /// <summary>
            /// Registriert einen Typ, der von einem Interface ableitet im IoC-Container.
            /// Hierbei wird der Key zur Unterscheidung genommen, sodass man hier mit dem übergebenen key resolven muss.
            /// </summary>
            /// <typeparam name="I">Das Interface, welches den Typen implementiert</typeparam>
            /// <typeparam name="T">Der konkrete Typ der instanziert werden soll</typeparam>
            /// <param name="key">Der Schlüsselparameter unter dem das Objekt aus dem IoC-Container herausgeholt wird</param>
            public void Register<I, T>(string key) where T : I where I : class
            {
                _builder.RegisterType<T>().Named<I>(key);
            }

            /// <summary>
            /// Baut den Container aufgrund aller bisher registrierten Typen zusammen
            /// </summary>
            /// <returns>Der fertig gebaute Autofac-Container, der im IoCWrapper gekapselt wird</returns>
            internal IContainer Build()
            {
                return _builder.Build();
            }
        }
    }
}
