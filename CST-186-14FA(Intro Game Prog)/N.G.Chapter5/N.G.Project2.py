#Created by: Nathan Gaffney
#21-Sep-2014
#Chapter 5 Project 1
#This program tell the user where they would go.
directions = {"north" : "Going north leads to the kitchen.",
              "south" : "GOing south leads to the dining room.",
              "east" : "Going east leads to the entry.",
              "west" : "Going west leads to the living room."}
whereToGo = raw_input("Enter a direction \'north\', \'south\', \'east\'," +
                      "\'west\',\'exit\'(To quit): ")
while whereToGo!= "exit":
    if whereToGo == "north":
        print directions.get("north")
    elif whereToGo == "south":
        print directions.get("south")
    elif whereToGo == "west":
        print directions.get("west")
    elif whereToGo == "east":
        print directions.get("east")
    else:
        print ("Invalid data.")
    whereToGo = raw_input("Enter a direction \'north\', \'sout\', \'east\'," +
                          "\'west\',\'exit\'(To quit): ")
