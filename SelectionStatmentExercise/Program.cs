
// Exercise 1
using SelectionStatmentExercise;

Console.WriteLine("Please try to guess my favorite number between 1 and 50.");

GuessTheNumber.FavNumber();

// Exercise 2

Console.WriteLine("What is your favorite school subject?");

var subject = Console.ReadLine();

switch (subject)
{
    case "Math":
        Console.WriteLine("Oh nice! I really like math too!");
        break;
    case "Science":
        Console.WriteLine("Nice! Did you know the midochondria is the powerhouse of the cell?");
        break;
    case "English":
        Console.WriteLine("Yeah English wasn't my strong suit in school.");
        break;
    case "Lunch":
        Console.WriteLine("Easily the best subject.");
        break;
    default:
        Console.WriteLine("I'm not really familiar with that subject actually.");
        break;
}