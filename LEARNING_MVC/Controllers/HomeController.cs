using System.Linq;
//using System.Data.Entity;

namespace LEARNING_MVC.Controllers
{
	public class HomeController : System.Web.Mvc.Controller
	{
		public HomeController() : base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Index()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1000()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1010()
		{
			return (View(viewName: "Learn1000"));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1020()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1030()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1040()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1050()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1060()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1070()
		{
			{
				int intSomeVariable = 10;
			}

			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1080()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1090()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1100()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1110()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1120()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1130()
		{
			ViewData["Message"] = "Hello, World!";

			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1140()
		{
			ViewBag.Message = "Hello World!";

			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1150()
		{
			ViewBag.Message1 = "Hello World (1)!";
			ViewData["Message2"] = "Hello World (2)!";

			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1160()
		{
			// Solution (1)
			//Models.Person oPerson = new Models.Person();

			//oPerson.Age = 20;
			//oPerson.FullName = "Ali Reza Alavi";
			// /Solution (1)

			// Solution (2)
			//Models.Person oPerson =
			//	new Models.Person("Ali Reza Alavi", 20);
			// /Solution (2)

			// Solution (3)
			//Models.Person oPerson =
			//	new Models.Person()
			//	{
			//		Age = 20,
			//		FullName = "Ali Reza Alavi"
			//	};
			// /Solution (3)

			// Solution (4)
			Models.Person oPerson =
				new Models.Person()
				{
					Age = 20,
					FullName = "Ali Reza Alavi",
				};
			// /Solution (4)

			ViewBag.Person = oPerson;

			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1170()
		{
			Models.Person oPerson =
				new Models.Person()
				{
					Age = 20,
					FullName = "Ali Reza Alavi",
				};

			ViewBag.Person = oPerson;

			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1180()
		{
			Models.Person oPerson =
				new Models.Person()
				{
					Age = 20,
					FullName = "Ali Reza Alavi",
				};

			ViewBag.Person = oPerson;

			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1190()
		{
			Models.Person oPerson =
				new Models.Person()
				{
					Age = 20,
					FullName = "Ali Reza Alavi",
				};

			return (View(model: oPerson));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1200()
		{
			Models.Person oPerson =
				new Models.Person()
				{
					Age = 20,
					FullName = "Ali Reza Alavi",
				};

			return (View(model: oPerson));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1210()
		{
			Models.Person oPerson =
				new Models.Person()
				{
					Age = 20,
					FullName = "Ali Reza Alavi",
				};

			return (View(model: oPerson));
		}

		/// <summary>
		/// راه حل کلاسيک
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1220()
		{
			Models.Person oPerson =
				new Models.Person()
				{
					Age = 20,
					FullName = "Ali Reza Alavi",
				};

			return (View(model: oPerson));
		}

		/// <summary>
		/// راه حل کلاسيک
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1230()
		{
			ViewBag.FactoryName = "Iran Khodro Co.";

			Models.Person oPerson =
				new Models.Person()
				{
					Age = 20,
					FullName = "Ali Reza Alavi",
				};

			return (View(model: oPerson));
		}

		/// <summary>
		/// راه حل هوشمندانه
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1240()
		{
			ViewModels.Home.Learn1240ViewModel
				oViewModel = new ViewModels.Home.Learn1240ViewModel();

			oViewModel.FactoryName = "Iran Khodro Co.";

			Models.Person oPerson =
				new Models.Person()
				{
					Age = 20,
					FullName = "Ali Reza Alavi",
				};

			oViewModel.Person = oPerson;

			return (View(model: oViewModel));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1250()
		{
			System.Collections.Generic.List<Models.Person>
				oPeople = new System.Collections.Generic.List<Models.Person>();

			for (int intIndex = 1; intIndex <= 10; intIndex++)
			{
				Models.Person oPerson =
					new Models.Person()
					{
						Age = 20 + intIndex,
						FullName = string.Format("Full Name ({0})", intIndex),
					};

				oPeople.Add(oPerson);
			}

			return (View(model: oPeople));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1260()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1270()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1280()
		{
			System.Collections.Generic.List<Models.Person>
				oPeople = new System.Collections.Generic.List<Models.Person>();

			for (int intIndex = 1; intIndex <= 10; intIndex++)
			{
				Models.Person oPerson =
					new Models.Person()
					{
						Age = 20 + intIndex,
						FullName = string.Format("Full Name ({0})", intIndex),
					};

				oPeople.Add(oPerson);
			}

			return (View(model: oPeople));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1290()
		{
			System.Collections.Generic.List<Models.Person>
				oPeople = new System.Collections.Generic.List<Models.Person>();

			for (int intIndex = 1; intIndex <= 10; intIndex++)
			{
				Models.Person oPerson =
					new Models.Person()
					{
						Age = 20 + intIndex,
						FullName = string.Format("Full Name ({0})", intIndex),
					};

				oPeople.Add(oPerson);
			}

			return (View(model: oPeople));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1300()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1310()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1320()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1330()
		{
			Models.Person oPerson =
				new Models.Person()
				{
					Age = 20,
					FullName = "Ali Reza Alavi",
					Description = "<b>Nothing!</b>",
				};

			return (View(model: oPerson));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1340()
		{
			Models.Person oPerson =
				new Models.Person()
				{
					Age = 20,
					FullName = "Ali Reza Alavi",
					Description = "<b>Nothing!</b>",
				};

			return (View(model: oPerson));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1350()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1360()
		{
			return (View());
		}
	}
}
