using System;
using System.Collections.Generic;

namespace WindsorDemo
{
	public interface INewtonSoftService
	{
		IList<Product> DeserializeProducts(string json);
	}
}