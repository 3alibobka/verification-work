string[] array =
{
    "12345",
    "32",
    "Минск",
    "5",
    "мяч",
    "Беларусь"
};

var result = new string[array.Length];
var Size = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[Size] = value;
        Size++;
    }
}

Console.WriteLine(string.Join(Environment.NewLine, result, 0, Size));