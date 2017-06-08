//namespace LEARNING_MVC.Models
namespace Models
{
	//public class Person
	//public class Person : object
	//public class Person : System.Object
	public class Person : object
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		public Person() : base()
		{
		}

		// !دیگر عرف نیست
		//public Person(int age) : base()
		//{
		//	Age = age;
		//}

		// !دیگر عرف نیست
		//public Person(string fullName) : base()
		//{
		//	FullName = fullName;
		//}

		// !دیگر عرف نیست
		//public Person(string fullName, int age) : base()
		//{
		//	Age = age;
		//	FullName = fullName;
		//}

		public int Age { get; set; }

		public string FullName { get; set; }

		public string Description { get; set; }
	}
}
