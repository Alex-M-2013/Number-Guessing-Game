int get_guess()
{
    while (true) {
        var user_input = Console.ReadLine();

        if (!user_input.All(char.IsDigit) || user_input.Contains('.') || user_input == "")
        {
            Console.WriteLine("Enter an integer. ");
            continue;
        }
        else if (Convert.ToInt16(user_input) < 1 || Convert.ToInt16(user_input) > 10)
        {
            Console.WriteLine("The number is between 1 and 10. ");
            continue;
        }
        else
        {
            var user_input_number = Convert.ToInt16(user_input);
            return user_input_number;
        }
}
}

while (true) {
    var attempts = 1;
    var num = Random.Shared.Next(1, 11);

    Console.WriteLine("I am thinking of a number from 1 to 10. Guess my number:");
    var user_num = get_guess();

    while (Convert.ToInt16(user_num) != num)
    {
        attempts += 1;
        Console.WriteLine("Wrong! Try again:");
        user_num = get_guess();
    }
    if (attempts == 1)
    {
        Console.WriteLine($"Well done! You guessed my number ({num}) in {attempts} attempt!");
    }
    else if (attempts > 1)
    {
        Console.WriteLine($"Well done! You guessed my number ({num}) in {attempts} attempts!");        
    }
    Console.WriteLine("Would you like to play again? (Y/n)");
    var play_again = Console.ReadLine();

    if (play_again.ToUpper() == "Y")
    {
        continue;
    } 
    else
    {
        break;
    }
}   
     