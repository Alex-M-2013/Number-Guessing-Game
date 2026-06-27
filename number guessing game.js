const readline = require('readline-sync')

function get_guess(prompt) {
    while (true) {
        
        let user_input = readline.question(prompt);
        
        if (isNaN(user_input) || user_input.includes('.')) {
            console.log('Enter an integer.');
            continue;
        }
        else if ((Number(user_input)) < 1 || (Number(user_input)) > 10) {
            console.log('The number is between 1 and 10.');
            continue;
        }
        else {
            user_input = Number(user_input);
        }
        
        return user_input
    }
}

while (true){    
    let attempts = 1;
    
    const num = Math.floor(Math.random() * 11);
    let user_num = get_guess('I am thinking of a number from 1 to 10. Guess my number: ');

    while (user_num !== num) {
        attempts += 1;
        user_num = get_guess('Wrong! Try again: ');
    }
    
    if (attempts === 1) {
        console.log(`Well done! You guessed my number (${num}) in ${attempts} attempt!`);
    }
    else if (attempts > 1) {
        console.log(`Well done! You guessed my number (${num}) in ${attempts} attempts!`);
    }

    const play_again = readline.question('Would you like to play again? (Y/n) ');

    if (play_again.toUpperCase() === 'Y') {
        continue;
    }
    else {
        break;
    }
}