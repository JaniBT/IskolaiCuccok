from tkinter import *
import random
import os
from kodoloappscript import fajlmegnyitas, fajlkeszites, fajlneve


window = Tk(className="Fájl készítő")
window.geometry("400x300")
button = Button(window, text="Mappa helye" ,command=fajlmegnyitas)
button.pack()
entry = Entry(window)
entry.pack()
entry2 = Entry(window)
entry2.pack()
def fajlnevbeszerzes():
    entry.cget()

def fajlbairas():
    entry2.cget()

button2 = Button(window, text="Fájl készítése", command=fajlkeszites)
button2.pack()

window.mainloop()