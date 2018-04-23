using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using SmartHotel.Services.Authentication;
using SmartHotel.Services.Navigation;
using SmartHotel.ViewModels;

namespace SmartHotel
{
    public class ServiceLocator
    {
        private IContainer _container;

        //Nhớ add cái nuget Autofac để dùng ContainerBuilder
        private readonly ContainerBuilder _containerBuilder;

        public static ServiceLocator Instance { get; }

        static ServiceLocator()
        {
            Instance = new ServiceLocator();
        }

        public ServiceLocator()
        {
            _containerBuilder = new ContainerBuilder();
            RegisterInstance<INavigationService, NavigationService>();

            RegisterInstance<IAuthenticationServices, FakeAuthenticationService>();

            _containerBuilder.RegisterType<MainViewModel>();
            
            _containerBuilder.RegisterType<HomeViewModel>();

            _containerBuilder.RegisterType<LoginViewModel>();

            _containerBuilder.RegisterType<BookingViewModel>();

            _containerBuilder.RegisterType<MyRoomViewModel>();

            _containerBuilder.RegisterType<SuggestionsViewModel>();

            _containerBuilder.RegisterType<ConciergeViewModel>();
        }

        public void Register<T, U>() where U : T
        {
            _containerBuilder.RegisterType<U>().As<T>();
        }

        public void RegisterInstance<T, U>() where U : T
        {
            _containerBuilder.RegisterType<U>().As<T>().SingleInstance();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

        public void Build()
        {
            _container = _containerBuilder.Build();
        }
    }
}
