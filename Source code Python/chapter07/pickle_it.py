# Pickle It
# Demonstrates pickling and shelving data

import cPickle, shelve

print "Pickling lists."
variety = ["sweet", "hot", "dill"]
shape = ["whole", "spear", "chip"]
brand = ["Claussen", "Heinz", "Vlassic"]
pickle_file = open("pickles1.dat", "w")
cPickle.dump(variety, pickle_file)
cPickle.dump(shape, pickle_file)
cPickle.dump(brand, pickle_file)
pickle_file.close()

print "\nUnpickling lists."
pickle_file = open("pickles1.dat", "r")
variety = cPickle.load(pickle_file)
shape = cPickle.load(pickle_file)
brand = cPickle.load(pickle_file)
print variety, "\n", shape, "\n", brand
pickle_file.close()

print "\nShelving lists."
pickles = shelve.open("pickles2.dat")
pickles["variety"] = ["sweet", "hot", "dill"]
pickles ["shape"] = ["whole", "spear", "chip"]
pickles["brand"] = ["Claussen", "Heinz", "Vlassic"]
pickles.sync()    # make sure data is written

print "\nRetrieving the lists from a shelved file:"
for key in pickles.keys():
    print key, "-", pickles[key]
pickles.close()

raw_input("\n\nPress the enter key to exit.")
