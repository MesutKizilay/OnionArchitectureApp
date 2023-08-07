using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Domain.Wrappers
{
	public class PageResponse<T> : ServiceResponse<T>
	{
		public int PageNumber { get; set; }
		public int PageSize { get; set; }

		public PageResponse()
		{
			PageNumber = 1;
			PageSize = 10;
		}

		public PageResponse(int pageNumber, int pageSize,T value):base(value)
		{
			PageNumber = pageNumber;
			PageSize = pageSize;
		}
	}
}