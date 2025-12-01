import random
def sprawdz_wynik(wybor_gracza, wybor_komputera):
    if wybor_gracza == 'papier' and wybor_komputera == 'papier':
        return 0
    elif wybor_gracza == 'kamien' and wybor_komputera == 'kamien':
        return 0
    elif wybor_gracza == 'nozyce' and wybor_komputera == 'nozyce':
        return 0
    elif (wybor_gracza == 'papier' and wybor_komputera == 'kamien') or (wybor_gracza == 'kamien' and wybor_komputera== 'nozyce') or (wybor_gracza == 'nozyce' and wybor_komputera=='papier'):
        return 1
    elif (wybor_gracza == 'papier' and wybor_komputera == 'nozyce') or (
            wybor_gracza == 'kamien' and wybor_komputera == 'papier') or (
            wybor_gracza == 'nozyce' and wybor_komputera == 'kamien'):
        return -1
def uruchom_gre():
    opcje = ["papier", "kamien", "nozyce"]
    punkty_gracz = 0
    punkty_komputer = 0

    while True:
       ruch_gracza = input("Podaj co chcesz zrobic ")
       ruch_komputera = random.choice(opcje)

       if ruch_gracza == "koniec":
           break
       if ruch_gracza not in opcje:
           print("Zly wybor")
           continue
       if sprawdz_wynik(ruch_gracza, ruch_komputera) == 1:
           punkty_gracz += 1
           print("WYGRAL GRACZ")
       elif sprawdz_wynik(ruch_gracza, ruch_komputera) == -1:
           punkty_komputer += 1
           print("WYGRAL KOMPUTER")
       else:
           print("REMIS")
           punkty_gracz += 1
           punkty_komputer +=1
    return print(punkty_gracz, punkty_komputer)
uruchom_gre()