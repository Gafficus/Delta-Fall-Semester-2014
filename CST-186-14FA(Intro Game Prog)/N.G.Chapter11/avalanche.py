# Modified from Pizza Panic
#Modified by Nathan Gaffney
#07/DEC/2014
#CST 186 INTRO GAME PROG
#Chapter 11 Project 2
from livewires import games, color
import random

games.init(screen_width = 640, screen_height = 480, fps = 50)


class Chef(games.Sprite):
    """
    The Chef
    """
    image = games.load_image("chef.bmp")

    def __init__(self):
        """ Initialize Pan object and create Text object for score. """
        super(Chef, self).__init__(image = Chef.image,
                                  x = games.mouse.x,
                                  bottom = games.screen.height)

    def update(self):
        """ Move to mouse x position. """
        self.x = games.mouse.x
        
        if self.left < 0:
            self.left = 0
            
        if self.right > games.screen.width:
            self.right = games.screen.width
        self.check_catch()
    def check_catch(self):
        """ Check if catch pizzas. """
        for rock in self.overlapping_sprites:
            rock.handle_caught()
            
class Rock(games.Sprite):
    """
    The Rock.
    """ 
    image = games.load_image("rock.bmp")
    speed = 1
    numRocks = 0
    i = 0
    def __init__(self, x, y = 90):
        """ Initialize a Pizza object. """
        super(Rock, self).__init__(image = Rock.image,
                                    x = x, y = y,
                                    dy = Rock.speed)
        self.numRocks += 1
    def update(self):
        """ Check if bottom edge has reached screen bottom. """
        
        if self.bottom > games.screen.height:
            self.destroy()
            self.numRocks += 1
            while (self.i<self.numRocks):
                new_Rock = Rock(x=self.getX())
                games.screen.add(new_Rock)
                self.i = self.i + 1
            self.speed += 1

    def handle_caught(self):
        """ Destroy self if caught. """
        self.destroy()
        self.end_game()
    def end_game(self):
        """ End the game. """
        end_message = games.Message(value = "Game Over",
                                    size = 90,
                                    color = color.red,
                                    x = games.screen.width/2,
                                    y = games.screen.height/2,
                                    lifetime = 3 * games.screen.fps,
                                    after_death = games.screen.quit)
        games.screen.add(end_message)
    def getX(self):
        return random.randint(0,640)
        

        

def main():
    """ Play the game. """
    #wall_image = games.load_image("wall.jpg", transparent = False)
    #games.screen.background = wall_image

    the_chef = Chef()
    games.screen.add(the_chef)

    the_rock = Rock(x=640/2)
    games.screen.add(the_rock)

    games.mouse.is_visible = False

    games.screen.event_grab = True
    games.screen.mainloop()

# start it up!
main()
