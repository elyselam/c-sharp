using System.Collections.Generic;

//CoolPeople is a type
public class CoolPeople {
	//this is a declaration

	//this is a variable/field
	private string[] people;

	//this is a property, props are public
	public string[] People {
		get {
			return this.people;
		}
		set {
			//single '' denotes a char

			if (value[0] != "Vast") {
				people[0] = value[0];
			}
		}
	} //auto property, 
	public CoolPeople() {
		Example(1);

	}

	public int Example() {
		return 0;
	}

	public int Example(int ex) {
		return 1;
	}
	//signatures defined by parameter list, not by name
	public string Example(string ex, string ex2) {
		return string.Empty;
	}
}