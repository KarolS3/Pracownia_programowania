def dzielenie(x,y):
    try:
        wynik = x /y
        print(wynik)
    except ArithmeticError:
        print("Arithmetic error")
x = int(input("Podaj liczbe x"))
y = int(input("Podaj liczbe y"))
dzielenie(x,y)