class Program
{
    class Person
    {
        public string Name { get; set; }
        public double Asset { get; set; }
        public bool IsFemale { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} {Asset}B {(IsFemale ? "F" : "M")} {Country} {Age}yrs";
        }
    }


    static List<Person> persons = new List<Person>()
    {
     new Person(){ Age = 72, Asset = 7.0, Country="South Africa", IsFemale=false, Name="Nicky Oppenheimer"},
     new Person(){ Age = 67, Asset = 7.6, Country="India", IsFemale=true, Name="Savitri Jindal"},
     new Person(){ Age = 81, Asset = 3.1, Country="India", IsFemale=true, Name="Indu Jain"},
     new Person(){ Age = 70, Asset = 2.5, Country="India", IsFemale=true, Name="Vinod Gupta"},
     new Person(){ Age = 77, Asset = 27.0, Country = "US",IsFemale = true,Name = "Jacqueline Mars"},
     new Person(){ Age = 76, Asset = 25.2, Country = "Italy", IsFemale = true, Name = "Maria Franca Fissolo"},
     new Person(){ Age = 55, Asset = 20.4, Country = "Germany", IsFemale = true, Name = "Susanne Klatten"},
     new Person(){ Age = 53, Asset = 20.0, Country = "US",IsFemale = true,Name = "Laurene Jobs"},
     new Person(){ Age = 60, Asset = 12.5, Country = "Nigeria", IsFemale=false, Name="Aliko Dangote" },
     new Person(){ Age = 76, Asset = 10.9, Country = "Ethiopia", IsFemale=false, Name="Mohammed Al Amoudi"},
     new Person(){ Age = 60, Asset = 30.7, Country = "Canada", IsFemale=false, Name="David Thomson" },
     new Person(){ Age = 76, Asset = 11.4, Country = "Canada", IsFemale=false, Name="Galen Weston"},
     new Person(){ Age = 60, Asset = 22.3, Country = "India", IsFemale=false, Name="Mukesh Ambani"},
     new Person(){ Age = 50, Asset = 17.5, Country = "India", IsFemale=false, Name="Dilip Shanghvi"},
     new Person(){ Age = 83, Asset = 30.4, Country = "US", IsFemale=false, Name="Sheldon Adelson"},
     new Person(){ Age = 78, Asset = 30.0, Country = "Brazil", IsFemale=false, Name="Jorge Lemann"},
     new Person(){ Age = 62, Asset = 18.4, Country = "Russia", IsFemale=false, Name="Leonid Mikhelson"},
     new Person(){ Age = 51, Asset = 17.5, Country = "Russia", IsFemale=false, Name="Alexey Mordashov"},
     new Person(){ Age = 89, Asset = 31.2, Country = "Hong Kong", IsFemale=false, Name="Li Ka-shing"},
     new Person(){ Age = 62, Asset = 31.2, Country = "China", IsFemale=false, Name="Wang Jianlin"},
     new Person(){ Age = 67, Asset = 33.8, Country = "US", IsFemale=true, Name="Alice Walton" },
     new Person(){ Age = 60, Asset = 34.0, Country = "US", IsFemale=false, Name="Jim Walton"},
     new Person(){ Age = 72, Asset = 34.1, Country = "US", IsFemale=false, Name="Rob Walton"},
     new Person(){ Age = 94, Asset = 39.5, Country = "France", IsFemale=true, Name="Liliane Bettencourt"},
     new Person(){ Age = 43, Asset = 39.8, Country = "US", IsFemale=false, Name="Sergey Brin"},
     new Person(){ Age = 43, Asset = 39.6, Country = "US", IsFemale=false, Name="Larry Page"},
     new Person(){ Age = 68, Asset = 41.5, Country = "France", IsFemale=false, Name="Bernard Arnault"},
     new Person(){ Age = 75, Asset = 47.5, Country = "US", IsFemale=false, Name="Michael Bloomberg"},
     new Person(){ Age = 77, Asset = 48.3, Country = "US", IsFemale=false, Name="David Koch"},
     new Person(){ Age = 81, Asset = 48.3, Country = "US", IsFemale=false, Name="Charles Koch"},
     new Person(){ Age = 72, Asset = 52.2, Country = "US", IsFemale=false, Name="Larry Ellison"},
     new Person(){ Age = 77, Asset = 54.5, Country = "Mexico", IsFemale=false, Name="Carlos Slim Helu"},
     new Person(){ Age = 33, Asset = 56.0, Country = "US", IsFemale=false, Name="Mark Zuckerberg"},
     new Person(){ Age = 81, Asset = 71.3, Country = "Spain", IsFemale=false, Name="Amancio Ortega"},
     new Person(){ Age = 53, Asset = 72.8, Country = "US", IsFemale=false, Name="Jeff Bezos" },
     new Person(){ Age = 85, Asset = 75.6, Country = "US", IsFemale=false, Name="Warren Buffet" },
     new Person(){ Age = 60, Asset = 86.0, Country = "US", IsFemale=false, Name="Bill Gates"}
    };

    static void Main()
    {
        int i = 0;
        // Query 1: Select all the persons with assets of over 50B dollars.
        var query1 = from p in persons where p.Asset > 50 select p;
        Console.WriteLine("Query 1 Results:");
        foreach (var person in query1)
        {
            i += 1; //I thought this would make it easier for you to read :)
            Console.WriteLine($"{i}. {person}");
            Console.WriteLine();
        }

        i = 0;
        // Query 2: Select all non-US citizens.
        var query2 = from p in persons where p.Country != "US" select p;
        Console.WriteLine("\nQuery 2 Results:");
        foreach (var person in query2)
        {
            i += 1;
            Console.WriteLine($"{i}. {person}");
            Console.WriteLine();
        }

        i = 0;
        // Query 3: Select the name of all the females from India.
        var query3 = from p in persons where p.IsFemale && p.Country == "India" select p.Name;
        Console.WriteLine("\nQuery 3 Results:");
        foreach (var name in query3)
        {
            i += 1;
            Console.WriteLine($"{i}. {name}");
            Console.WriteLine();
        }

        i = 0;
        // Query 4: Select all persons whose first name is less than five letters long.
        var query4 = from p in persons where p.Name.Split(' ')[0].Length < 5 select p;
        Console.WriteLine("\nQuery 4 Results:");
        foreach (var person in query4)
        {
            i += 1;
            Console.WriteLine($"{i}. {person}");
            Console.WriteLine();
        }

        i = 0;
        // Query 5: Sort the collection by assets.
        var query5 = from p in persons orderby p.Asset select new { p.Name, p.Asset };
        Console.WriteLine("\nQuery 5 Results:");
        foreach (var item in query5)
        {
            i += 1;
            Console.WriteLine($"{i}. {item.Name} {item.Asset}B");
            Console.WriteLine();
        }

        i = 0;
        // Query 6: Group the collection by country.
        var query6 = from p in persons group p by p.Country into g select g;
        Console.WriteLine("\nQuery 6 Results:");
        foreach (var group in query6)
        {
            Console.WriteLine($"Country: {group.Key}");
            foreach (var person in group)
            {
                i += 1;
                Console.WriteLine($"{i}. {person}");
                Console.WriteLine();
            }
            Console.WriteLine();
            i = 0;
        }

        i = 0;
        // Query 7: Sort the groups from the previous query.
        var query7 = from g in query6 orderby g.Key select g;
        Console.WriteLine("\nQuery 7 Results:");
        foreach (var group in query7)
        {
            Console.WriteLine($"Country: {group.Key}");
            foreach (var person in group)
            {
                i += 1;
                Console.WriteLine($"{i}. {person}");
                Console.WriteLine();
            }
            Console.WriteLine();
            i = 0;
        }



        i = 0;
        // Fun Query 1: Get the summ of ascii value from each persons name, and just plays FizzBuzz with it!
        // it just converts the persons name to an ascii value, and see if the conditions are met
        // but figuring out how to make it a numbered list while using a ternary operator was fun
        var funQuery1 = from p in persons
                        let asciiSum = p.Name.Sum(c => (int)c)
                        select new { p.Name, AsciiSum = asciiSum };

        Console.WriteLine("\nFun Query 1 Results:");
        foreach (var item in funQuery1)
        {
            Console.Write(
                 ((item.AsciiSum % 3 == 0 && item.AsciiSum % 5 == 0) ? $"{i += 1}. {item.Name} is a FizzBuzz! ({item.AsciiSum})\n" :
                 (item.AsciiSum % 3 == 0) ? $"{i += 1}. {item.Name} is a Fizz! ({item.AsciiSum})\n" :
                 (item.AsciiSum % 5 == 0) ? $"{i += 1}. {item.Name} is a Buzz! ({item.AsciiSum})\n" : "\r")
            );
        }
        Console.WriteLine();



    }
}
