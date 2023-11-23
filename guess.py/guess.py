def play_game():
    #import random module 
    import random

    #generate random number for the computer
    random_number = random.randint(1,10)

    guesses = 0

    #ask user for name
    print('Hello user! Welcome to the guessing game!')
    player_name = input('What is your name? ')

    play_option = input(f'Hi, {player_name}, would you like to play' f' the guessing game?(Enter Y/N): ')
    if play_option.lower() != 'y':
        print('That is cool, Thanks!')
        exit()

    else:
        while True:
            #increment guesses variable
            guesses += 1
            #ask user for input
            user_guesses = int(input("Guess a number between 1 and 10: "))

            #code to run if user gueess = computer guess
            if user_guesses == random_number:
                print("You got it in", guesses, "guesses")
                exit()
                
            #code to run if user guess > computer guess
            elif user_guesses >random_number:
                print("It is lower...") 
                
            #code to run if user guess < computer guess
            else:
                print("It is highher...")
            
            
play_game()