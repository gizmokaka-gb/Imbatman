string[] array = { "жи", "ши", "пиши", "через", "и" };
Console.WriteLine("\nПравило простое: ");

var str = string.Join(" ", array);
Console.WriteLine(str);

var result = new string[array.Length];
var size = 0;
foreach (var value in array)
{
    if (value.Length < 4)
    {
        result[size] = value;
        size++;
    }
}
Console.WriteLine("\nНо нам нужны только слова до 3х букв... Поэтому)");
Console.WriteLine(string.Join(" " , result, 0, size));

Console.WriteLine("\nСпасибо за курс <3 ");
Console.WriteLine("");