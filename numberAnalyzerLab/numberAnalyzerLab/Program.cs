RestartApplication:

Console.WriteLine("please enter a number from 1 to 100");


string usernumber = Console.ReadLine();

int user = int.Parse(usernumber);           // stores user input and converts to integer

if (user >= 1 && user <= 100)
{
    Console.WriteLine("thankyou!! Also, what is your name if you don't mind me asking?");   //stores username
    string username = Console.ReadLine().Trim();

    if (user % 2 == 1 && user < 60)
    {
        Console.WriteLine(username, "Your number is odd and less than 60");
    }
    else if (user % 2 == 0 && user >= 2 && user <= 24)
    {
        Console.WriteLine(username, "Your number is even and less than 25");
    }
    else if (user % 2 == 0 && user >= 26 && user <= 60)
    {
        Console.WriteLine(username, "Your number is even and between 26 & 60");
    }
    else if (user % 2 == 0 && user > 60)
    {
        Console.WriteLine(username, "Your number is even and greater than 60");
    }
    else if (user % 2 == 1 && user > 60)
    {
        Console.WriteLine(username, "Your number is odd and greater than 60");
    }

}
else
{
    Console.WriteLine("Please enter a valid number");
    goto RestartApplication;
}


Console.WriteLine("Would you like to start over? please type y to begin again or any other key to leave");
string answer = Console.ReadLine();
if (answer == "y")
{
    goto RestartApplication;        //not sure if this is the best way to restart but it works
}
else
{
    Console.WriteLine("Goodbye");
}