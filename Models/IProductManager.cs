using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models
{
	  interface IProductManager
	{
		List<Product> GetAll();
		Product Get(int id);
		Product Add(Product product);
		void Remove(int id);
		bool Update(Product product);
	}
}