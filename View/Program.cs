///////////////////////////////////////////////////////////////////////////////
//  Calculator
//
//  Copyright (c) 2019, Alonso R.
//  License GNU Affero v3

using Autofac;
using Presenter;

namespace View
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            InitializeContainer();

            using (var scope = Container.BeginLifetimeScope())
            {
                var view = scope.Resolve<IMainView>();
            }
        }

        private static void InitializeContainer()
        {
            var builder = new ContainerBuilder();

            builder.Register(c => new MainView())
                .As<IMainView>();
            builder.RegisterType<MainView>();

            builder.Register(c => new OperationPresenter(Container.ResolveOptional<IMainView>()))
                .As<IOperationPresenter>();
            builder.RegisterType<OperationPresenter>();

            Container = builder.Build();
        } 
    }
}
