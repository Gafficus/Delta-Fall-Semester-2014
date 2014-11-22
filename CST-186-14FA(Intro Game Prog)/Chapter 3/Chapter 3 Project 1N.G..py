#Created by NAthan Gaffney
#8-Sep-2014
#Chapter 3 Project 1
#THis program will evaluate a score.
flag = 1
while flag == 1:
    score = int(raw_input("Enter your score: "))
    if score > 9999:
        print "\nVery Good."
        flag = 0
    elif score >= 1000:
        print "\nGood score."
        flag = 0
    elif score >= 0:
        print "\nNothing to brag about."
        flag = 0
    else:
        print "\nThat's not a valid score."
        flag = 1
raw_input("\nPress enter to exit.")

