
Acceptansprov 1: Tilläggsberäkning och historik

Scenario:

    Med ett körbart kalkylatorprogram
    Och inga tidigare beräkningar i historiken

Steg:

    Användaren väljer operationen: Addition genom att ange: 1
    Användaren anger det första värdet: 5
    Användaren matar in det andra värdet: 3
    Användaren bekräftar beräkningen
    Användaren väljer menyalternativet "Visa historik" genom att mata in: 5

Förväntade resultat:

    Kalkylatorn visar "Resultat: 5 + 3 = 8"
    Historiken innehåller nu: "5 + 3 = 8"

Acceptanstest 2: Subtraktionsberäkning och historik

Scenario:

    Med ett körande kalkylatorprogram
    Och en historik som innehåller den tidigare beräkningen "5 + 3 = 8"

Steg:

    Användaren väljer operationen: Addition genom att mata in: 2
    Användaren matar in det första värdet: 8
    Användaren matar in det andra värdet: 3
    Användaren bekräftar beräkningen
    Användaren väljer menyalternativet "Visa historik" genom att mata in: 5

Förväntade resultat:

    Kalkylatorn visar "Resultat: 8 - 3 = 5"
    Historiken är densamma som vid föregående beräkning
    Historiken innehåller nu: "5 + 3 = 8", "8 - 3 = 5"

Acceptanstest 3: Multiplikationsberäkning och historik

Scenario:

    Givet ett körande kalkylatorprogram
    Och en historik som innehåller de tidigare beräkningarna "5 + 3 = 8", "8 - 3 = 5"

Steg:

    Användaren väljer operationen: Addition genom att ange: 3
    Användaren matar in det första värdet: 4
    Användaren matar in det andra värdet: 2
    Användaren bekräftar beräkningen
    Användaren väljer menyalternativet "Visa historik" genom att mata in: 5

Förväntade resultat:

    Kalkylatorn visar resultatet: 4 * 2 = 8
    Historiken förblir densamma med tidigare beräkningar
    Historiken innehåller nu: "5 + 3 = 8", "8 - 3 = 5", "4 * 2 = 8"
