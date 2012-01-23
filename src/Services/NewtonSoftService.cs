using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WindsorDemo
{
	public class NewtonSoftService : INewtonSoftService
	{
		public NewtonSoftService ()
		{ }
		
		public IList<Product> DeserializeProducts(string json)
		{
			return JsonConvert.DeserializeObject<IList<Product>>(json);
		}
	}
}