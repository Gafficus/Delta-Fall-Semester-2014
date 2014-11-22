#Created by Nathan Gaffney
#8-Sep-2014
#Chapter 3 Project 2
#THis program will simulate flipping a coin.
import random
flips = 0
heads = 0
tails = 0
while flips <= 99:
    coin = random.randrange(2)
    if coin == 1:
        heads+= 1
    else:
        tails+= 1
    flips += 1
print "Number of heads: "
print heads
print "\nNumber of tails: "
print tails
raw_input("\nPress enter to exit.")
