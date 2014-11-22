# High Scores 2.0 from book
#Edited by: NAthan Gaffney
#5-Oct-2014
#INTRO GAME PROG - CST-186-FA210-14FA-COURSE
#Project 1
import cPickle, shelve
"""This will check the file"""
def open_file(file,mode):
    try:
        the_file = open(file,mode)
    except:
        print "File not found creating new file."
        the_file = open(file,"w+")
    else:
        return the_file



scores = []
file= "scores.dat"
choice = None
open_file(file,"r+")
while choice != "0":

    print \
    """
    High Scores Keeper
    
    0 - Quit
    1 - List Scores
    2 - Add a Score
    """
    
    choice = raw_input("Choice: ")
    print

    # exit
    if choice == "0":
        print "Good-bye."
        pickle_file = open("scores.dat","w")
        cPickle.dump(scores,pickle_file)
        pickle_file.close()
        

    # display high-score table
    elif choice == "1":
        print "High Scores\n"
        print "NAME\tSCORE"
        pickle_file = open_file(file,"r")
        try:
            scores = cPickle.load(pickle_file)
        except:
            print "Cannot read empty file. Creating Empty FIle"
        print scores
        pickle_file.close()

    # add a score
    elif choice == "2":
        name = raw_input("What is the player's name?: ")
        score = int(raw_input("What score did the player get?: "))
        entry = (name, score)
        scores.append(entry)
        scores.sort()
        scores.reverse()        # want the highest number first
        scores = scores[:5]     # keep only top 5 scores
        pickle_file= open(file,"w")
        cPickle.dump(scores,pickle_file)
        pickle_file.close()

    # some unknown choice
    else:
        print "Sorry, but", choice, "isn't a valid choice."
  
raw_input("\n\nPress the enter key to exit.")
