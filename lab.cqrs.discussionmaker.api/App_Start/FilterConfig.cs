﻿using System.Web;
using System.Web.Mvc;

namespace lab.cqrs.discussionmaker.api
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
