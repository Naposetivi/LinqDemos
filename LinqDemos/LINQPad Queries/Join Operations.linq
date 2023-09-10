<Query Kind="Program" />

void Main()
{
	var people = new Person[]{
		new Person("Jane", "jane@foo.com"),
		new Person("John", "john@foo.com"),
		new Person("Chris", string.Empty),
	};
	
	var records = new Record[]{
		new Record("jane@foo.com", "1111"),
		new Record("john@foo.com", "2222"),
		new Record("jane@foo.com", "3333"),
	};
	
	var query = people.Join(records,
		x => x.Email,
		y => y.Mail,
		(person, record) => new {Name = person.Name, SkypeId = record.SkypeId});
		
	Console.WriteLine(query);
	
	Console.WriteLine(
	
		people.GroupJoin(
			records,
			x => x.Email,
			y => y.Mail,
			(person, recs) => new {Name = person.Name, SkypeIds = recs.Select(r => r.SkypeId).ToArray()
			}
		));
}

// Define other methods and classes here
public class Person
{
	public string Name, Email;
	
	public Person(string name, string email){
		Email = email;
		Name = name;
	} 
}

public class Record
{
	public string Mail, SkypeId;
	
	public Record(string mail, string skypeId)
	{
		Mail = mail;
		SkypeId = skypeId;
	}
}