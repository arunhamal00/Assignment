class PeopleReport
{
    public static void SaveMales(List<Person> people)
    {
        string filePath=@"E:\Assignment\Assignment2\Data\males.csv";
        var males = people.Where(p => p.Gender == "Male").ToList();
        var csv = string.Join("\n", males.Select(m => $"{m.Index},{m.UserId},{m.FirstName},{m.LastName},{m.Gender},{m.Email},{m.Phone},{m.Dob},{m.JobTitle}"));
        File.WriteAllText(filePath, csv);
    }

    public static void SaveFemales(List<Person> people)
    {
        string filePath = @"E:\Assignment\Assignment2\Data\adultfemales.csv";
        var adultFemales = people.Where(p => p.Gender == "Female" && DateTime.Now.Year - p.Dob.Year >= 20).ToList();
        var csv = string.Join("\n", adultFemales.Select(f => $"{f.Index},{f.UserId},{f.FirstName},{f.LastName},{f.Gender},{f.Email},{f.Phone},{f.Dob},{f.JobTitle}"));
        File.WriteAllText(filePath, csv);
    }

    public static void SaveDotComUsers(List<Person> people)
    {
        string filePath = @"E:\Assignment\Assignment2\Data\dotcomusers.csv";
        var dotComUsers = people.Where(p => p.Email.EndsWith("@example.com")).ToList();
        var csv = string.Join("\n", dotComUsers.Select(d => $"{d.UserId},{d.Email},{d.Phone}"));
        File.WriteAllText(filePath, csv);
    }
}