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
* Projekt `Database` jest typu `Class Library`, zatem definiowanie jego parametrów trzeba zrobić w klasie dziedziczącej z `DbContext` w metodzie `OnConfiguring`:
    ```
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=VacDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;");
	}
    ```
    Ten sposób tworzenia DbContext wymaga, aby konstruktor tej [klasy był bezparametrowy][link1].
* 


### Aplikacja desktopowa

* Klasyczne użycie wzorca MVVM bez posługiwania się kontrolerami (Shell - MVC)
* [Walidacja wprowadzanych danych][link2]
* [Obfuscar][link3]
* W MAUI nie można zadeklarować globalnego mapowania view-modeli na widoki?! Każdy `DataTemplate` w `ResourceDictionary` musi mieć x:Key (app-level / page-level). Tylko gdy jest definiowany wewnątrz np. CollectionView to wystarczy, żeby miał x:DataType (control-level). Oznacza to, iż żeby wprowadzić sterowanie VM-first należy używać `DataTemplateSelector`ów.




## Zadania

1. Utworzyć pierwszy zgrubny widok i jego view-model (MainViewModel + VM prawej części)
2. Opracować połączenie z bazą danych
3. Opracować style
4. Asynchroniczność
5. Przełączanie między widokami na ekranie głównym - DataTemplate w zależności od VM, czy sterowanie widocznością danych widoków poprzez VM?






[link1]: https://learn.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli
[link2]: https://learn.microsoft.com/en-us/dotnet/architecture/maui/validation?source=recommendations
[link3]: https://docs.lextudio.com/obfuscar/
