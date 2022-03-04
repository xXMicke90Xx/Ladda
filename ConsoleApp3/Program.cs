
using BussinessLogicLibrary;
using DatabaseAccessLibrary;


int val = 0;
Parking_Garage garage = new Parking_Garage();
//AddCars();
while (val != 10)
{
    Console.Clear();
    Console.WriteLine("Ange ett val: ");
    Console.WriteLine("[1] Läs data från databas: ");
    Console.WriteLine("[2] Skriv ut p platser: ");
    Console.WriteLine("[3] Ta bort fordon: ");
    Console.WriteLine("[4] sök fordon: ");
    Console.WriteLine("[5] Fyll GarageLista: ");
    val = int.Parse(Console.ReadLine());

    switch (val)
    {
        case 1:
            {
                break;
            }
        case 2:
            {
                break;
            }
        case 3:
            {
                break;
            }
        case 4:
            {
                break;
            }
        case 5:
            {
                FillGarage();
                FillSpots();
                Console.Clear();
                int count = 0;
                foreach(var item in garage.Parkingspots)
                {
                    if (item.Parked_Vehicles.Count() < 0)
                        foreach(var thing in item.Parked_Vehicles)
                            Console.WriteLine(item.Parked_Vehicles);
                    else
                        Console.WriteLine(count);
                    count++;

                }
                Console.ReadLine();
                break;
            }
        default:
            break;
    }
}

void AddCars()
{
   
    using(var db = new FabolousDbContext())
    {
        List<Car> cars = db.SeedTestData();
        db.cars.AddRange(cars);
        List<Motorcycle> mc = db.SeedTestDataMc();
        db.motorcycles.AddRange(mc);
        db.SaveChanges();
    }
}
void AddVehicles() 
{
    List<Car> cars = new List<Car>();
    using (var c = new FabolousDbContext())
    {

    }
}

void FillGarage()
{
    for(int i = 0; i < 100; i++)
    {
        garage.Parkingspots.Add(new Parkingspot());
    }
}
void FillSpots()
{
    using(var db = new FabolousDbContext())
    {
        foreach(var item in db.cars)
        {
            if (item.Parkingspot != null && item.Parkingspot != 0)
            {
                garage.Parkingspots[item.Parkingspot].Parked_Vehicles.Add(item.Registration, item);
            }
        }
    }
}

