using Mission3;
internal class Program
{
    public static void Main(string[] args)
    {
        int choice;
        
        List<FoodItem> foodList = new List<FoodItem>();
        
        do
        { 
            // user choice menu
            Console.WriteLine("Hello, Welcome to the Food Bank System!");
            Console.WriteLine("Choose an option from the menu:");
            Console.WriteLine("1. Add Food Items");
            Console.WriteLine("2. Delete Food Items");
            Console.WriteLine("3. Print List of Current Food Items");
            Console.WriteLine("4. Exit the Program");
            
            // choice
            choice = Convert.ToInt32(Console.ReadLine());

             if (choice == 1)
             {
                 // add food items
                 Console.WriteLine("How many food items do you want to add?");
                 int amount = Convert.ToInt32(Console.ReadLine());

                 if (amount > 0)
                 {
                     for (int i = 0; i < amount; i++)
                     {
                         Console.WriteLine("Please enter the name of the item you want to add:");
                         string name = Console.ReadLine();
                         Console.WriteLine("Please enter the category of the item you want to add:");
                         string category = Console.ReadLine();
                         Console.WriteLine("Please enter the quantity of the item you want to add:");
                         int quantity = Convert.ToInt32(Console.ReadLine());
                         Console.WriteLine("Please enter the expiration date of the item you want to add:");
                         DateTime expirationDate = DateTime.Parse(Console.ReadLine());
                        
                         // create food item object 
                         FoodItem foodItem = new FoodItem(name, category, quantity, expirationDate);
                         
                         // appending food item to food list
                         foodList.Add(foodItem);
                     }
                 }

             }
             else if (choice == 2)
             {
                 // delete food items
                 Console.WriteLine("Enter the number correlated to the item you want to delete:");
                 
                 // list of food to delete
                 for (int i = 0; i < foodList.Count; i++)
                 {
                     Console.WriteLine((i + 1) + ". " + foodList[i].Name);
                 }
                 
                 // get user answer
                 int userInput = Convert.ToInt32(Console.ReadLine());
                 
                 // remove chosen item 
                 if (userInput > 0 && userInput <= foodList.Count)
                 {
                     foodList.RemoveAt(userInput - 1);
                 }
                 else
                 {
                     Console.WriteLine("You entered an invalid option");
                 }
             }
             else if (choice == 3)
             {
                 Console.WriteLine("Current food list:");
                 
                 // print current list of food items
                 for (int i = 0; i < foodList.Count; i++)
                 {
                     Console.WriteLine((i + 1) + ". " + foodList[i].Name + " - Category: " + foodList[i].Category + " - Quantity: " + foodList[i].Quantity.ToString() + " - Expiration: " + foodList[i].ExpirationDate);
                 }
                 
                 Console.WriteLine("\nPress any key to continue...");
                 Console.ReadKey();
                 
             }
             // error handling for invalid options
             else if (choice > 4 || choice < 1)
             {
                 Console.WriteLine("Please enter a valid choice");
             }
            // exits when user enters option 4, otherwise it will continue to loop
        } while (choice != 4);
        
        Console.WriteLine("Thank you for using the Food Bank System. Goodbye!");
        
    }
}