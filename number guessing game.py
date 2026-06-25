from random import randint

def get_guess(prompt):
    
    while True:
        user_input = input(prompt)
        user_input_conditions = [str(user_input) == '', not user_input.isdigit()]

        if any(user_input_conditions):       
            print ('Enter an integer this time.')
            continue
        elif int(user_input) < 1 or int(user_input) > 10:
            print ('The number is between 1 and 10.')
            continue
        else:
            user_input = int(user_input)

        return user_input

while True:
    num = randint(1, 10)
    user_num = get_guess('I am thinking of a number from 1 to 10. Guess my number: ')
    
    attempts = 1
    
    while num != user_num:
        attempts += 1
        user_num = get_guess('Wrong! Try again: ')

    if attempts == 1:
        print (f'Well done! You guessed my number ({num}) in {attempts} attempt!')
    elif attempts > 1:
        print (f'Well done! You guessed my number ({num}) in {attempts} attempts!')
    
    play_again = input('Would you like to play again? (Y/N) ')
    if play_again.upper() == 'Y':
        continue
    else:
        break