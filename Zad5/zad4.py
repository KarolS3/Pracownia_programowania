def get_number(prompt):
    value = input(prompt)
    try:
        return float(value)
    except ValueError:
        raise TypeError(f"Zlyt input: '{value}' to nie numer.")
try:
    num1 = get_number("Liczba 2: ")
    num2 = get_number("Liczba 1: ")
    print(f"Wpisales {num1} i {num2}.")
except TypeError:
    print("Blad type error")
