#import random module
import random
#array to store  high scores
attempt_list = []

#function to store and display high score
def show_score():
    if not attempt_list:
        print('There is currently no high score, it\'s yours for the taking!')
    else:
        print(f'The current high score is' f' {min(attempt_list)} attempts')
        
def play_game():
    #generate random number for the computer
    random_number = random.randint(1,10)
    guesses = 0

    #ask user for name
    print('Hello user! Welcome to the guessing game!')
    player_name = input('What is your name? ')

    #ask user if they want to pay the game
    play_option = input(f'Hi, {player_name}, would you like to play' f' the guessing game?(Enter Y/N): ')
    if play_option.lower() != 'y':
        print('That is cool, Thanks!')
        exit()

    else:
        show_score()
        
        while True:
            #increment guesses variable
            guesses += 1
            #ask user for input
            user_guesses = int(input("Guess a number between 1 and 10: "))

            #code to run if user gueess = computer guess
            if user_guesses == random_number:
                print("You got it in", guesses, "guesses")
                attempt_list.append(guesses)
                
                play_option = input('Would you like to play again? (Enter Y/N)')

                #code to run if user does not want to play again
                if play_option.lower() != 'y':
                    print('That is cool, Thanks!')
                    break
                else:
                    guesses = 0
                    random_number = random.randint(1, 10)
                    show_score()
                    continue
            
                
            #code to run if user guess > computer guess
            elif user_guesses >random_number:
                print("It is lower...") 
                
            #code to run if user guess < computer guess
            else:
                print("It is highher...")
            
            
play_game()