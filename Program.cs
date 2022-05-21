
using WebFileValidator;

string path = @"d:\urls.txt";


if(!File.Exists(path))
{
    Console.WriteLine("The file doesn't exist");
    return;
}

var text = File.ReadAllText(path);

foreach(var item in text.Split(Environment.NewLine))
{
    var boo = await Helper.CheckUrl(item);

    if(!boo)
        Console.WriteLine(item);
}

