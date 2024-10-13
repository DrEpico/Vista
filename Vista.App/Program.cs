using Vista.App.Data;

var trainerDbContext = new TrainersDbContext(); //Create databse context

ListCategories(trainerDbContext);
ListTrainers(trainerDbContext);

//Method to List Categories from the database 
static void ListCategories(TrainersDbContext dbContext)
{
    // Load list of categories from the database
    var categoryList = dbContext.Categories.ToList();

    Console.WriteLine("Category List\n");

    //Display list of categories from the memory object (categoryList)
    foreach (var category in categoryList)
    {
        Console.WriteLine($"{category.CategoryCode} {category.CategoryName}");
    }
    Console.WriteLine();
}

// Method to List trainers from the database
static void ListTrainers(TrainersDbContext dbContext)
{
    // Load list of categories from the database
    var trainerList = dbContext.Trainers.ToList();

    Console.WriteLine("Trainer List\n");

    //Display list of categories from the memory object (trainerList)
    foreach (var trainer in trainerList) 
    {
        Console.WriteLine($"{trainer.TrainerId} {trainer.Name}");
    }
    Console.WriteLine();

}