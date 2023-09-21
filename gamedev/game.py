from ursina import *

class Player(Entity):
    def input(self, key):
        if key == 'w':
            self.position += self.forward
        if key == 'd':
            self.animate('rotation_y', self.rotation_y + 90, duration=.1)

        if key == 'a':
            self.animate('rotation_y', self.rotation_y - 90, duration=.1)
        if key == 's':
            self.position -= self.forward



app = Ursina()

Entity = Sprite('cube')
Player()

app.run()