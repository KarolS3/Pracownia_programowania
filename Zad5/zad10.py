lista = [1,2,4,5,6]

try:
    r = len(lista)
    # r = lista.length
    print("Dlugosc listy", r)
except AttributeError:
    print("Atribute error")
