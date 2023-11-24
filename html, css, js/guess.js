var message1 = document.getElementById("message1");
var message2 = document.getElementById("message2");
var result = document.getElementById("result");

var randomNumber = Math.floor(Math.random()*10) + 1;
var number_of_guesses = 0;
var guessed_numbers = [];

//function to allow user to user
function play(){
    var user_guess = document.getElementById("guess-input").value;

    //check if user input is between 1 and 10
    if(user_guess < 1 || user_guess > 10){
        alert("Please enter a number between 1 and 10!")
    }
    else{
        guessed_numbers.push(user_guess);
        number_of_guesses += 1;

        if(user_guess < randomNumber){
            result.textContent = "It is higher..."
            message1.textContent = "No of guesses: " + number_of_guesses;
            message2.textContent = "Guessed number are: " + guessed_numbers;
        }
        else if(user_guess > randomNumber){
            result.textContent = "It is lower..."
            message1.textContent = "No of guesses: " + number_of_guesses;
            message2.textContent = "Guessed number are: " + guessed_numbers;
        }
        else if(user_guess == randomNumber){
            result.textContent = "You got it right!"
            message1.textContent = "The number was: " + randomNumber;
            message2.textContent = "You guessed it in " + number_of_guesses + " guesses!"
            document.getElementById("guess-btn").disabled = true;

           
        }
        
    }
}