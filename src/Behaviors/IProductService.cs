using System;
using System.Collections.Generic;

namespace WindsorDemo
{
	public interface IProductService
	{
		IList<Product> Search(string query);
	}
}

