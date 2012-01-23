using System;
using System.Collections.Generic;

namespace WindsorDemo
{
	public class ProductService : IProductService
	{
		private readonly ISatchmoProductService _satchmoProductService;
		private readonly INewtonSoftService _newtonService;
		
		public ProductService (ISatchmoProductService satchmoProductService,
								INewtonSoftService newtonService)
		{
			_satchmoProductService = satchmoProductService;
			_newtonService = newtonService;
		}
		
		public IList<Product> Search(string query)
		{
			var json = _satchmoProductService.Search (query);
			return _newtonService.DeserializeProducts (json);
		}
	}
}