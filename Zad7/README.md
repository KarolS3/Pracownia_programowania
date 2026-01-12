# Punkty rekrutacyjne

Twoim zadaniem jest stworzenie pięknej aplikacji konsolwej oraz znalezienie odpowiedzi na poniższe pytania. **Skorzystaj z dobrodziejstw programowania obiektowego**, odpowiednio zamodeluj dane, aby łatwiej było Ci na nich operować.

---

### Wymagania
Dzisiaj nauczysz się korzystania z **pakietów NuGet** - są to ogólnodostępne biblioteki, z których można korzystać przy pracy nad oprogramowaniem. Do wykonania zadania użyj pakietu `Spectre.Console`, dostępną [tutaj](https://www.nuget.org/packages/Spectre.Console/).

**Utwórz projekt aplikacji konsolowej .NET** - .NET 8 (*lub .NET 10, jeżeli dostępny*), wewnątrz niego zaimplementuj kod, który będzie odpowiedzialny za przetworzenie danych w pliku tekstowym oraz wyświetli odpowiedzi na pytania.

#### Instalacja pakietu NuGet
Pakiety NuGet możesz zainstalować na wiele sposobów, najprostszym będzie instalacja z poziomu **Menedżera pakietów NuGet** w Visual Studio.
*Narzędzia → Menedżer pakietów NuGet → **Zarządzaj pakietami NuGet rozwiązania***

![alt text](.github/assets/scr-vs.png)

#### Dokumentacja
Twoim zadaniem jest stworzenie pięknej aplikacji konsolowej - **tak pięknej, jak to tylko możliwe!** W tym celu skorzystaj z dokumentacji pakietu `Spectre.Console`, która znajduje się [tutaj](https://spectreconsole.net). W dokumentacji znajdziesz informacje, w jaki sposób tworzyć tabelki w konsoli czy też jak rysować wykresy.

---

### Dane wejściowe
Plik: `punkty_rekrutacyjne.txt`

Plik zawiera dane 514 uczniów zapisane w postaci tekstowej, gdzie:
- pierwszy wiersz to nagłówek,
- dane w kolejnych wierszach są rozdzielone średnikami (`;`).

Kolumny:
1. Nazwisko  
2. Imię  
3. Osiągnięcia (0–10)  
4. Zachowanie (2–6)  
5. Język polski (JP)  
6. Matematyka (Mat)  
7. Biologia (Biol)  
8. Geografia (Geog)  
9. GHP – egzamin: język polski (%)  
10. GHH – historia i WOS (%)  
11. GMM – matematyka (%)  
12. GMP – przedmioty przyrodnicze (%)  
13. GJP – język obcy (%)  

Przykładowe wiersze:
```text
Nazwisko;Imie;Osiagniecia;Zachowanie;JP;Mat;Biol;Geog;GHP;GHH;GMM;GMP;GJP
Swistek;Damian;0;4;4;5;6;6;62;13;26;67;62
Kowalik;Mateusz;7;4;4;2;5;6;90;8;21;52;33
Hintzke;Nikola;7;4;4;6;6;5;96;99;16;85;65
Grzelecki;Oliwier;8;6;4;4;3;5;17;100;100;100;31
```

---

### Punktacja rekrutacyjna

#### 1. Egzamin gimnazjalny (maks. 50 pkt)

Wynik punktowy z egzaminu gimnazjalnego obliczamy poprzez podzielenie wyniku procentowego przez 10, np:
*Wynik z historii = 70%, punkty rekrutacyjne = 70 / 10 = 7 pkt.*

#### 2. Oceny ze świadectwa (maks. 40 pkt)

| Ocena | Opis | Punkty |
|-------|------|--------|
| 2 | dopuszczająca | 0 |
| 3 | dostateczna | 4 |
| 4 | dobra | 6 |
| 5 | bardzo dobra | 8 |
| 6 | celująca | 10 |

Dotyczy przedmiotów: język polski, matematyka, biologia, geografia.


#### 3. Dodatkowe osiągnięcia (maks. 10 pkt)
- Osiągnięcia – zgodnie z wartością w pliku *(to już jest punktacja)*
- Zachowanie:
  - wzorowe *(6)* - 2 pkt
  - inne - 0 pkt

---

## Zadanie 1
Utwórz zestawienie uczniów, którzy spełniają jednocześnie następujące warunki: mają 0 punktów za osiągnięcia, co najmniej bardzo dobrą ocenę (5) zachowania oraz średnią z przedmiotów punktowanych w rekrutacji większą od 4. Zestawienie uporządkuj alfabetycznie według nazwisk. Podaj imiona i nazwiska pierwszych 5 osób.

---

## Zadanie 2
Oblicz zgodnie z zasadami opisanymi w treści zadania, ile punktów rekrutacyjnych uzyskał każdy z uczniów. Podaj liczbę punktów rekrutacyjnych występującą najczęściej oraz listę nazwisk i imion uczniów, którzy uzyskali tę liczbę punktów. 

---

## Zadanie 3
Utwórz zestawienie zawierające imiona i nazwiska uczniów, którzy uzyskali 100% punktów z co najmniej 3 zakresów egzaminu gimnazjalnego.

---

## Zadanie 4
Utwórz zestawienie zawierające rozkład ocen dla każdego punktowanego w rekrutacji przedmiotu (przykład schematu zestawienia poniżej). Dla otrzymanego zestawienia wykonaj wykres procentowy skumulowany. Zadbaj o czytelny opis wykresu.

| Liczba ocen | Język polski | Matematyka | Biologia | Geografia |
|-------------|--------------|------------|----------|-----------|
| dopuszczających | | | | |
| dostatecznych | | | | |
| dobrych | | | | |
| bardzo dobrych | | | | |
| celujących | | | | |

Przykład wykresu skumulowanego:
![Wykres skumulowany](./.github/assets/wykres-t007_1.png)

---

## Zadanie 5
Podaj liczbę uczniów, którzy uzyskali łącznie więcej punktów rekrutacyjnych za oceny z przedmiotów punktowanych i dodatkowe osiągnięcia (w tym ocenę z zachowania) niż za wyniki egzaminu gimnazjalnego.

---
