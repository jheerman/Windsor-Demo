using System;

using Castle.Windsor;

namespace WindsorDemo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var container = new WindsorContainer();
			container.Install(new ServicesInstaller());
			
			var productService = container.Resolve<IProductService>();
			var products = productService.Search ("shirt");
			Console.WriteLine ("Products: {0}", products.Count);
		}
	}
}
