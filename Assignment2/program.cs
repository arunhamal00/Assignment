CsvParser parser = new();
List<Person> people = parser.Parse();
PeopleReport.SaveMales(people);
PeopleReport.SaveFemales(people);
PeopleReport.SaveDotComUsers(people);