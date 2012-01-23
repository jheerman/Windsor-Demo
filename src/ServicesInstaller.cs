using System;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;

namespace WindsorDemo
{
	public class ServicesInstaller : IWindsorInstaller
	{
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.Register(
				Component.For<IProductService>().ImplementedBy(typeof(ProductService)),
				Component.For<INewtonSoftService>().ImplementedBy(typeof(NewtonSoftService)),
				Component.For<ISatchmoProductService>().ImplementedBy(typeof(SatchmoProductService))
			);
		}
	}
}

