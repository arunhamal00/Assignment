class CsvParser
{
    List<Person> people = new();

    public List<Person> Parse()
    {
        // Read file
        string filePath = @"E:\Assignment\Assignment2\Data\People.csv";
        var lines = File.ReadAllLines(filePath);

        // Parsing
        foreach(var line in lines.Skip(1))
        {
            var parts = line.Split(",", StringSplitOptions.RemoveEmptyEntries);
            var person = new Person
            {
                Index = int.Parse(parts[0]),
                UserId = parts[1],
                FirstName = parts[2],
                LastName = parts[3],
                Gender = parts[4],
                Email = parts[5],
                Phone = parts[6],
                Dob = DateTime.Parse(parts[7]),
                JobTitle = parts[8]
            };

            people.Add(person);
        }

        return people;
    }
}