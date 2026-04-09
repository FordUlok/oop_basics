namespace realestate;

class Program
{
    static void Main(string[] args)
    {
        // 1. ApartmentHouse létrehozása (max 2 lakás, 1 garázs)
    ApartmentHouse house = new ApartmentHouse(2, 1);

    // 2. Objektumok létrehozása
    Lodgings l1 = new Lodgings(50, 2, 200000); // 50m2, 2 szoba (max 16 fő / min 2m2 per fő)
    FamilyApartment f1 = new FamilyApartment(80, 3, 300000); // 80m2, 3 szoba (max 6 fő / min 10m2 per fő)
    Garage g1 = new Garage(20, 50000, true,1, true); // 20m2, fűtött

    // 3. Ingatlanok felvétele a házba
    Console.WriteLine("--- Ingatlanok felvétele ---");
    Console.WriteLine("Lodgings hozzáadva: " + house.Create(l1)); // True
    Console.WriteLine("Family hozzáadva: " + house.Create(f1));   // True
    Console.WriteLine("Garage hozzáadva: " + house.Create(g1));   // True
    Console.WriteLine("Még egy garázs (limit túllépés): " + house.Create(new Garage(10, 10, false, 2, false))); // False

    // 4. Lodgings (Albérlet) tesztelése
    Console.WriteLine("\n--- Lodgings teszt ---");
    Console.WriteLine("Beköltözés foglalás nélkül: " + l1.MoveIn(2)); // False
    l1.Book(6);
    Console.WriteLine("Foglalás után beköltözés (2 fő): " + l1.MoveIn(2)); // True
    Console.WriteLine("Túl sok ember (20 fő): " + l1.MoveIn(18)); // False (max 16 fő a 2 szobában)
    Console.WriteLine("Bérleti díj (6 hónap, 2 főre): " + l1.GetCost(6));

    // 5. FamilyApartment (Családi lakás) tesztelése
    Console.WriteLine("\n--- FamilyApartment teszt ---");
    Console.WriteLine("Gyerek születik (0 felnőttnél): " + f1.ChildIsBorn()); // False
    f1.MoveIn(2); // 2 felnőtt beköltözik
    Console.WriteLine("Gyerek születik (2 felnőttnél): " + f1.ChildIsBorn()); // True
    Console.WriteLine(f1.ToString()); // Ellenőrizzük a gyerekek számát

    // 6. Garage tesztelése
    Console.WriteLine("\n--- Garage teszt ---");
    Console.WriteLine("Garázs foglalt-e alapból: " + g1.IsBooked); // False (ha 0 hónap és nincs autó)
    g1.Book(1); // Autó beáll
    Console.WriteLine("Garázs foglalt-e autóval: " + g1.IsBooked); // True
    Console.WriteLine("Garázs értéke: " + g1.TotalValue());

    // 7. ApartmentHouse összesített adatok
    Console.WriteLine("\n--- Ház összesített adatok ---");
    Console.WriteLine("Összes lakó a házban: " + house.InhabitantsCount); // 2 (albi) + 3 (családi) = 5
    // Összérték: albi (használt), családi (használt), garázs (foglalt az autó miatt)
    Console.WriteLine("Ház teljes aktuális értéke: " + house.TotalValue());

    Console.WriteLine("\n--- ToString tesztek ---");
    Console.WriteLine(l1.ToString());
    Console.WriteLine(f1.ToString());
    Console.WriteLine(g1.ToString());
    
    Console.ReadLine();
    }
}