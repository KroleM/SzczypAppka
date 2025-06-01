# SzczypAppka - opis

## Tabele

1. Users:
    * User - osoba, dla której tworzona jest lista szczepionek
    * AgeType - dziecko, dorosły, senior
2. Vaccines:
    * Vaccination - całe szczepienie jakie przyjmuje dany użytkownik. Zawiera chorobę, szczepionkę i daty szczepień
    * Illness - choroba, do której może być przyporządkowanych wiele szczepionek
    * Vaccine - konkretna szczepionka (nazwa handlowa), która ma swój indywidualny schemat przyjmowania dawek
    * Scheme - schemat przyjmowania dawek, zawiera liczbę podstawowych dawek
    * Dose - dawka w kolejności w danym schemacie z czasem jaki ma (minimalnie) minąć od poprzedniej dawki



## Architektura

### Baza danych

* `public virtual Illness Illness { get; set; }` - `virtual` oznacza Lazy-Loading, czyli ładowanie danej z bazy danych dopiero, gdy bezpośrednio się o nią poprosi (czyli kiedy? Include?)
* `public ICollection<Scheme> Schemes { get; } = new List<Scheme>();`
* Można stosować `enumy` - wówczas mają id typu int odpowiadające wartości enuma (patrz AgeType)
* 