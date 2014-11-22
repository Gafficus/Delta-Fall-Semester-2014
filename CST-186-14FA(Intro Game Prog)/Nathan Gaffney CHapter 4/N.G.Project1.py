#Created by Nathan Gaffney
#14-Sep-2014
#Chapter 4 Project 1
VOWELS = "aeiou"
numVowels= 0
phrase = raw_input("Enter a phrase: ")
for letter in phrase:
  if letter.lower() in VOWELS:
      numVowels += 1
print numVowels
numVowels = 0
strLen = len(phrase)
i=0
while i<= strLen -1:
    if phrase[i] in VOWELS:
        numVowels += 1
    i += 1
print numVowels
    
