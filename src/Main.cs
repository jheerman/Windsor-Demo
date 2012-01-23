using System;

using Castle.Windsor;

namespace WindsorDemo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var container = new WindsorContainer ();
			container.Install (new ServicesInstaller ());
			
			container.Resolve<DemoApp> ().Run ();
		}
	}
	
	class DemoApp
	{
		private readonly IProductService _productService;
		
		public DemoApp (IProductService productService)
		{
			_productService = productService;
		}
		
		public void Run ()
		{
			var products = _productService.Search ("shirt");
			
			Console.WriteLine ("<--- Products --->");
			foreach (var product in products)
				Console.WriteLine (product.Name);
		}
	}
}
