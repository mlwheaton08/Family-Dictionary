Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "20" } });
myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Jack" }, { "age", "22" } });
myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Lora" }, { "age", "56" } });

foreach (var member in myFamily)
{
    string relation = member.Key;
    string name = member.Value["name"];
    string age = member.Value["age"];
    Console.WriteLine($"{name} is my {relation} and is {age} years old.");
}