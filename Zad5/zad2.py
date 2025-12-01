def validate_int():
    try:
        x = int(input("Podaj int"))
        return print(x)
    except ValueError:
        return print("To nie int")
validate_int()