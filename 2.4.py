cel = int(input("Podaj cel oszczednosci"))
monthly_pay = int(input("Podaj miesieczna wplate"))
opro = int(input("Podaj oprocentowanie"))
saldo = 0
msc = 0
while saldo < cel and msc < 12:
    msc +=1
    saldo += monthly_pay
    saldo += saldo * (opro / 100)
    print("Miesiac: ", saldo)
if cel <= saldo:
    print("Wykonano cel")