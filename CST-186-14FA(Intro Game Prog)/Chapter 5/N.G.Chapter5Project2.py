#Created by: Nathan Gaffney
#28-Sep-2014
#Chapter 5 Project 4
#THis program modifys the Guess My Number
#The base source code was taken from the files
#found on the book cd.

# Guess My Number
#
# The computer picks a random number between 1 and 100

# The player tries to guess it and the computer lets
# the player know if the guess is too high, too low
# or right on the money

import random
#From the CD source Files
def ask_number(low, high): #Removed the guess 
    """Ask for a number within a range."""
    response = None
    while response not in range(low, high):
        response = int(raw_input("Take a guess: "))
    return response

print "\tWelcome to 'Guess My Number'!"
print "\nI'm thinking of a number between 1 and 100." 
print "Try to guess it in as few attempts as possible.\n"
low = 1
high = 100

# set the initial values
the_number = random.randrange(100) + 1
guess = ask_number(low, high)
tries = 1

# guessing loop
while (guess != the_number):
    if (guess > the_number):
        print "Lower..."
    else:
        print "Higher..."
            
    guess = ask_number(low, high)
    tries += 1

print "You guessed it!  The number was", the_number
print "And it only took you", tries, "tries!\n"
  
raw_input("\n\nPress the enter key to exit.")

