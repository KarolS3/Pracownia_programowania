list = [4,5,6]
n = int(input("Podaj index"))
try:
    print(list[n])
except IndexError:
    print("Za mala ta tablica")