#Created by: Nathan Gaffney
#Project 2
#Create a weapon Class and a derived sword
#18-10-2014
#CST 186

class Weapon(object):
    """A tool for bonking"""
    damage = 0
    def __init__(self, number):
        self.damage = number


class Sword(Weapon):
    """A tool for slicing"""
    def swing(self):
        print "You swing and inflict ", self.damage ,"points of damage."

wep = Sword(5)
wep.swing()
raw_input("Press Enter to exit.")
