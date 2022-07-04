using Milestone3;

namespace Inventory_Management
{
    class Program
    {
        static void Main(string[] args)
        {


            InventoryManager inventoryManager = new InventoryManager();
            int userChoice;

            for (; ; )
            {

                Console.WriteLine("1---------|Add item to Inventory|");
                Console.WriteLine("2---------|Display Inventory|");
                Console.WriteLine("3---------|Remove item from Inventory|");
                Console.WriteLine("4---------|Search item by name in Inventory|");
                Console.WriteLine("5---------|Search item by price in Inventory|");
                Console.WriteLine("6---------|Re-adjust item quantity in Inventory|");
                Console.WriteLine("7---------|Exit Inventory Manager|");
                Console.WriteLine("\n");


                Console.WriteLine("Enter choice");
                userChoice = Convert.ToInt32(Console.ReadLine());


                switch (userChoice)
                {
                    case 1:
                        inventoryManager.addItemToInventory();
                        break;
                    case 2:
                        inventoryManager.displayInventoryItem();
                        break;

                    case 3:
                        inventoryManager.removeItemFromInventoryList();
                        break;
                    case 4:
                        Console.WriteLine("Enter item name to search ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        string nameOfItem = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                        inventoryManager.searchInventoryItemByName(nameOfItem);
                        break;

                    case 5:

                        Console.WriteLine("Enter price to search ");
                        double priceToSearch = Convert.ToDouble(Console.ReadLine());
                        inventoryManager.searchItemByPrice(priceToSearch);
                        break;

                    case 6:
                        Console.WriteLine("Enter item name to edit stock ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        string editItemName = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                        inventoryManager.modifyInventoryItem(editItemName);
                        break;

                    case 7:
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;

                }

            }

        }
    }
}

