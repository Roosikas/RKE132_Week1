// This is a comment to my code

//rakendus küsib kasutajal sisestada tema nime
//rakendus tervitab kasutajad nimepidi

Console.WriteLine("Enter your name:");
//string - sõne
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string userName = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.


//Console.WriteLine("Hello"+ ", " + userName + "!");
//string interpolation
Console.WriteLine($"Hello, {userName}!");
