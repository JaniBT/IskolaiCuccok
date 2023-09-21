import os
from tkinter.filedialog import askdirectory
from kodoloapp import fajlnevbeszerzes, fajlbairas

def fajlneve():
    fajlnevbeszerzes()

def fajlkeszites():
    file_path = r'{fajlnevbeszerzes}'
    if os.path.exists(file_path):
        print('A fájl már létezik!')
    else:
        with open(file_path, 'w') as fp:
            fp.write(fajlbairas())

def fajlmegnyitas():
    file = askdirectory()
    print(file)