#Created by: Nathan Gaffney
#14-Sep-2014
#Chapter 4 Project 2
#THis program will reverse a string
phrase = raw_input("Enter a phrase: ")
strLen = len(phrase)
while strLen > 0:
    print phrase[strLen-1]
    strLen-=1
