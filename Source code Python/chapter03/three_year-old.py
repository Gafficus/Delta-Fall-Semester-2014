# Three Year-Old Simulator
# Demonstrates the while loop

print "\tWelcome to the 'Three-Year-Old Simulator'\n"
print "This program simulates a conversation with a three-year-old child."
print "Try to stop the madness.\n"

response = ""
while response != "Because.":
    response = raw_input("Why?\n")

print "Oh.  Okay."

raw_input("\n\nPress the enter key to exit.")
