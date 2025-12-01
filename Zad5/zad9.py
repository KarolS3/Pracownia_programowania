encoding = input("Podaj encoding")
try:
    file = open("zad3.txt", "r", encoding=encoding)
    content = file.read()
    print(content)
    file.close()
except UnicodeDecodeError:
    print("Encoding error")