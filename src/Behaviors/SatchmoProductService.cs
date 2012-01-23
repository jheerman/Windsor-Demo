using System;
using System.Net;
using System.IO;

namespace WindsorDemo
{
	public class SatchmoProductService : ISatchmoProductService
	{ 
		public SatchmoProductService ()
		{ }
		
		public string Search (string query)
		{
			try
			{
				using (Stream stream =  new WebClient()
					.OpenRead(string.Format("http://50.56.79.53/ws/search/?include_categories=0&keywords={0}", query)))
					using (StreamReader reader = new StreamReader(stream))
					{
						return reader.ReadToEnd().ToString();
					}
			}
			catch (Exception)
			{
				return string.Empty;
			}
			
		}
	}
}

