#import random module 
import random

#generate random number for the computer
random_number = random.randint(1,10)

guesses = 0

while True:
    #increment guesses variable
    guesses += 1
    #ask user for input
    user_guesses = int(input("Guess a number between 1 and 10: "))

    #code to run if user gueess = computer guess
    if user_guesses == random_number:
        print("You got it!")