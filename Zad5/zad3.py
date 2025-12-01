try:
    file = open("zad3.txt", 'r')
    content = file.read()
    print(content)
    file.close()
except FileNotFoundError:
    print("Nie ma takiego pliku")