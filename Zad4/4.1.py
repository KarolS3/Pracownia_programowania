def waliduj_haslo(haslo):
    znaki8 = False
    czy_wielkalitera = False
    czy_malalitera = False
    czy_cyfra = False
    if len(haslo) >= 8:
        znaki8 = True
        for char in haslo:
            if char.isupper():
                czy_wielkalitera = True
            if char.islower():
                czy_malalitera = True
            if char.isdigit():
                czy_cyfra = True
    if czy_cyfra == True & czy_wielkalitera == True & czy_malalitera == True & czy_cyfra == True:
        return True
    return False


passw = input("Podaj haslo: ")
if waliduj_haslo(passw):
    print("Wdzystko super")
else:
    print("Haslo niepoprawne")
