using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
	public class ContatoController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Create()
		{
			return View();
		}

		public IActionResult Edit()
		{
			return View();
		}

		public IActionResult Delete()
		{
			return View();
		}
	}
}
