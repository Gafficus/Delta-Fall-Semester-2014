# High Scores
# Demonstrates list methods

scores = []

choice = None
while choice != "0":

    print \
    """
    High Scores Keeper
    
    0 - Exit
    1 - Show Scores
    2 - Add a Score
    3 - Delete a Score 
    4 - Sort Scores
    """
    
    choice = raw_input("Choice: ")
    print

    # exit
    if choice == "0":
        print "Good-bye."

    # list high-score table
    elif choice == "1":
         print "High Scores"
         for score in scores:
            print score

    # add a score
    elif choice == "2":
        score = int(raw_input("What score did you get?: "))
        scores.append(score)

    # delete a score
    elif choice == "3":
        score = int(raw_input("Delete which score?: "))
        if score in scores:
            scores.remove(score)
        else:
            print score, "isn't in the high scores list."

    # sort scores
    elif choice == "4":
        scores.sort()
        scores.reverse()        # want the highest number first

    # some unknown choice
    else:
        print "Sorry, but", choice, "isn't a valid choice."
  
raw_input("\n\nPress the enter key to exit.")
