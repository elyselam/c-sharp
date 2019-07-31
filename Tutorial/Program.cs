using System;

namespace Tutorial {
	class Program {
		static void Main(string[] args) {

			//not capitalized bc not public
			var peeps = new CoolPeople().People;
			DateTime test = new DateTime(, )
			//accessing People property of type list
			peeps.Add("elyse");
			peeps.Add("not Vast");
			foreach (var peep in peeps) {
				Console.WriteLine(peep);

			}
		}
	}
}