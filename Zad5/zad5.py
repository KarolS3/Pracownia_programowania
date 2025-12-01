try:
    file = open("zad3.txt", "r")
    content = file.read()
    print(content)
    file.close()
except PermissionError:
    print("Permission error, nie otwieraj")