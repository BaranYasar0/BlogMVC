﻿using Microsoft.AspNetCore.Mvc;

namespace Deneme.Controllers
{
	public class WriterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}