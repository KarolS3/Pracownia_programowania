cel = int(input("Podaj docelowy dystans"))
pdys = int(input("Podaj poczatkowy dystans"))
pwzrost = int(input("Podaj wzrost dystansu"))
dys = pdys
tyg = 0
while dys <= cel:
    tyg += 1
    dys += dys * (pwzrost / 100)
    print(tyg,"Tydzien: ", dys)