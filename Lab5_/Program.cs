using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            EcoStockItem ecoStockItem = new EcoStockItem();
            StockItem stockItem = new StockItem();
            Plate plate = new Plate();
            Juice juice = new Juice();

            StartProgram(stock, ecoStockItem, stockItem, plate, juice);
        }

        private static void StartProgram(Stock stock, EcoStockItem ecoStockItem, StockItem stockItem, Plate plate, Juice juice)
        {
            bool loop = true;
            while (loop)
            {
                bool loop1 = true;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Välj");
                    Console.WriteLine("1 - Skapa vara");
                    Console.WriteLine("2 - Inventera vara");
                    Console.WriteLine("3 - Lista vara");
                    Console.WriteLine("4 - Avsluta");
                    int userChoice;
                    
                    if (int.TryParse(Console.ReadLine(), out userChoice) && userChoice >= 1 && userChoice <= 4)
                    {
                        switch (userChoice)
                        {
                            case 1:
                            {
                                CreateItem(stock, ecoStockItem, stockItem, plate, juice);
                                loop1 = false;
                                break;
                            }
                            case 2:
                            {
                                InventoryMetod(stock);
                                loop1 = false;
                                break;
                            }
                            case 3:
                            {
                                loop1 = Show(stock, loop1);
                                   
                                break;
                            }
                            case 4:
                            {
                                loop1 = false;
                                loop = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Du kan bara välja med siffror mellan 1 - 4! Prova igen!");
                    }
                } while (loop1);
            }
        }

        private static bool Show(Stock stock, bool loop1)
        {
            Console.Clear();
            Console.WriteLine("Ekologiska varor");
            for (int i = 0; i < stock.StockItemLength(); i++)
            {
                var a = stock[i] is EcoStockItem;
                if (a)
                {
                    Console.WriteLine(stock[i]);
                }
            }
            Console.WriteLine("Ej ekologiska varor");
            for (int i = 0; i < stock.StockItemLength(); i++)
            {
                var validEco = stock[i] is EcoStockItem;
                if (!validEco)
                {
                    if (stock[i] != null)
                        Console.WriteLine(stock[i]);
                }
            }
            Console.WriteLine("Tryck Enter för att gå tillbaka");
            Console.ReadLine();
            loop1 = false;
            return loop1;
        }


        private static void InventoryMetod(Stock stock)
        {

            Console.Clear();
            Console.WriteLine("Välj");
            Console.WriteLine("1 - Ekologiskvara");
            Console.WriteLine("2 - Tallrikar");
            Console.WriteLine("3 - Juice");
            Console.WriteLine("4 - Annat");
            Console.WriteLine("5 - Tillbaka");
            int secondUserChoice;
            if (int.TryParse(Console.ReadLine(), out secondUserChoice) && secondUserChoice >= 1 && secondUserChoice <= 5)
            {
                switch (secondUserChoice)
                {
                    case 1:
                        {
                            Inventory(stock);
                            break;
                        }
                    case 2:
                        {
                            Inventory(stock);
                            break;
                        }
                    case 3:
                        {
                            Inventory(stock);
                            break;
                        }
                    case 4:
                        {
                            Inventory(stock);
                            break;
                        }
                    case 5:
                        {

                            break;

                        }
                }
            }
            else
            {
                Console.WriteLine("Du kan bara välja med siffror mellan 1 - 5!Prova igen!");
                Console.WriteLine("Tryck Enter!");
                Console.ReadLine();

            }

        }



        private static void Inventory(Stock stock)
        {
            Console.Clear();
            for (int i = 0; i < stock.StockItemLength(); i++)
            {
                if (stock[i] != null)
                    Console.WriteLine(stock[i]);
            }
            Console.WriteLine("Skriv id nummer!");
            int userId;
            bool loopId = true;
            do
            {
                if (int.TryParse(Console.ReadLine(), out userId))
                {
                    var itemFounder = stock.GetItem(userId);
                    Console.WriteLine(itemFounder);
                    Console.WriteLine("Hur många finns det?");
                    int userStockCount;
                    bool loopStockCount = true;
                    do
                    {
                        if (int.TryParse(Console.ReadLine(), out userStockCount))
                        {
                            itemFounder.StockCount = userStockCount;
                            loopStockCount = false;
                        }
                        else
                        {
                            Console.WriteLine("Du kan bara välja med siffror! Prova igen!");

                        }
                    } while (loopStockCount);
                    loopId = false;
                }
                else
                {
                    Console.WriteLine("Du kan bara välja med siffror! Prova igen!");

                }
            } while (loopId);

        }



        private static void CreateItem(Stock stock, EcoStockItem ecoStockItem, StockItem stockItem, Plate plate, Juice juice)
        {
            Console.Clear();
            Console.WriteLine("Välj");
            Console.WriteLine("1 - Ekologiskvara");
            Console.WriteLine("2 - Tallrikar");
            Console.WriteLine("3 - Juice");
            Console.WriteLine("4 - Annat");
            Console.WriteLine("5 - Tillbaka");
            int firstUserChoice;
            if (int.TryParse(Console.ReadLine(), out firstUserChoice) && firstUserChoice >= 1 && firstUserChoice <= 5)
            {
                switch (firstUserChoice)
                {
                    case 1:
                        {
                            EcologicalItem(stock, ecoStockItem);
                            break;
                        }
                    case 2:
                        {
                            PlateItem(stock, plate);
                            break;
                        }
                    case 3:
                        {
                            JuiceItem(stock, juice);
                            break;
                        }
                    case 4:
                        {
                            EveryItem(stock, stockItem);
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Du kan bara välja med siffror mellan 1 - 5!Prova igen!");
                Console.WriteLine("Tryck Enter!");
                Console.ReadLine();
            }
        }
        private static void JuiceItem(Stock stock, Juice juice)
        {
            Console.WriteLine("Är juicen krav eller eg?");
            string userMark = Console.ReadLine();
            Console.WriteLine("Vad är för juice: äpple eller orange?");
            string userTyp = Console.ReadLine();
            Console.WriteLine("Vad är namnet på varan?");
            string userName = Console.ReadLine();
            Console.WriteLine("Vad är det för ID?");
            int userId = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många antal av varan finns det?");
            int userStockCount = int.Parse(Console.ReadLine());
            stock.AddItem(new Juice(typ: userTyp, id: userId, name: userName, stockCount: userStockCount, markning: userMark));
        }
        private static void EveryItem(Stock stock, StockItem stockItem)
        {
            Console.WriteLine("Vad är namnet på varan?");
            string userName = Console.ReadLine();
            Console.WriteLine("Vad är det för ID?");
            int userId = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många antal av varan finns det");
            int userStockCount = int.Parse(Console.ReadLine());
            stock.AddItem(new StockItem(id: userId, name: userName, stockCount: userStockCount));
        }
        private static void PlateItem(Stock stock, Plate plate)
        {
            Console.WriteLine("Är tallriken djup eller flat?");
            string userTyp = Console.ReadLine();
            Console.WriteLine("Vad är namnet på varan?");
            string userName = Console.ReadLine();
            Console.WriteLine("Vad är det för ID?");
            int userId = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många antal av varan finns det?");
            int userStockCount = int.Parse(Console.ReadLine());
            stock.AddItem(new Plate(name: userName, stockCount: userStockCount, id: userId, typ: userTyp));
        }

        private static void EcologicalItem(Stock stock, EcoStockItem ecoStockItem)
        {
            Console.WriteLine("Vad är det för märkning?");
            string userMarkning = Console.ReadLine();
            Console.WriteLine("Vad är namnet på varan?");
            string userName = Console.ReadLine();
            Console.WriteLine("Vad är det för ID?");
            int userId = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många antal av varan finns det?");
            int userStockCount = int.Parse(Console.ReadLine());
            stock.AddItem(new EcoStockItem(markning: userMarkning, name: userName, id: userId, stockCount: userStockCount));
        }
    }
}
