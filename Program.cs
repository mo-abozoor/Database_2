using Database_2;

var db = new CarsDbContext();



// insert 
/*
db.Cars.Add(new Car
{ 
    Maker = "test2",
    Model = "test2",
    ProductionYear = 2022
});
await db.SaveChangesAsync();
*/


/*
db.Cars.AddRange(new Car[]
{
    new Car { Maker = "fiat", Model = "pontu", ProductionYear = 2022 },
    new Car { Maker = "skode", Model = "octavia", ProductionYear = 2015 },
    new Car { Maker = "bmw", Model = "M8", ProductionYear = 2023 }
});
await db.SaveChangesAsync();
*/


//updata
//var carToDelete = db.Cars.FirstOrDefault(c => c.Id = 2);
//carToDelete.ProductionYear = 2017;
//await db.SaveChangesAsync();


//Delete
/*
var carToDelete = db.Cars.FirstOrDefault(c => c.Id == 3);
db.Cars.Remove(carToDelete);
await db.SaveChangesAsync();
*/


var allcars = db.Cars.ToList();

/*
var allcars = db.Cars.
    Where(c => c.ProductionYear > 2020)
    .ToList();
*/


foreach (var car in allcars)
{
    Console.WriteLine(car);
}