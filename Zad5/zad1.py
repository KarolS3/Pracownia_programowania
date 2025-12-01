def dzielnie_przez0(x,y):
    try:
        wynik = x/y
        print("Wynik", wynik)
    except ZeroDivisionError:
        print("Nie mozna dzielic przez 0")
dzielnie_przez0(10,0)