using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_OkuhleNgada.Decorators;
using Assignment_OkuhleNgada.Factories;
using Assignment_OkuhleNgada.Observers;
using Assignment_OkuhleNgada.Models;

namespace Assignment_OkuhleNgada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ONT4101 Assignment 1";
            int selectedRegion = SelectRegion();
            int selectedDish;
            int dishOption;
            int selectedTopping = -1;
            String dishType = "";
            AbstractFactory BurritoFactory;
            Dish MyDish = null;
            if (selectedRegion == 1)
            {//Load the united states store
                Console.Clear();
                BurritoFactory = new BurritoWorldUS();
                selectedDish = DisplayUnitedStatesMenu();
                if (selectedDish == 1)
                {
                    dishOption = SelectDishOption(DishType.Burrito);
                }
                else
                {
                    dishOption = SelectDishOption(DishType.Taco);
                }

                if (dishOption == 1 && selectedDish == 1)
                {
                    MyDish = BurritoFactory.CreateDish(DishType.Burrito, DishOption.Chicken);
                }
                else if (dishOption == 2 && selectedDish == 1)
                {
                    MyDish = BurritoFactory.CreateDish(DishType.Burrito, DishOption.Meat);
                }
                else if (dishOption == 3 && selectedDish == 1)
                {
                    MyDish = BurritoFactory.CreateDish(DishType.Burrito, DishOption.Vegitarian);
                }
                else if (dishOption == 1 && selectedDish == 2)
                {
                    MyDish = BurritoFactory.CreateDish(DishType.Taco, DishOption.Chicken);
                }
                else if (dishOption == 2 && selectedDish == 2)
                {
                    MyDish = BurritoFactory.CreateDish(DishType.Taco, DishOption.Meat);
                }
                else if (dishOption == 3 && selectedDish == 2)
                {
                    MyDish = BurritoFactory.CreateDish(DishType.Taco, DishOption.Vegitarian);
                }

                selectedTopping = DisplayToppingsMenu(MyDish, out dishType);

                while (selectedTopping != 8)
                {
                    selectedTopping = DisplayToppingsMenu(MyDish, out dishType);
                    if (selectedTopping == 8)
                    {
                        break;
                    }
                    else
                    {
                        switch (selectedTopping)
                        {
                            case 1:
                                if (MyDish.Country == Locale.ZA)
                                {
                                    MyDish.Topping = new Cheese(MyDish, "Cheedar Cheese", 5.00);
                                }
                                else
                                {
                                    MyDish.Topping = new Cheese(MyDish, "Pepper Jack Cheese", 5.00);
                                }

                                break;
                            case 2:
                                if (MyDish.Country == Locale.ZA)
                                {
                                    MyDish.Topping = new Guacamole(MyDish, "Sliced Avocado's", 10.00);
                                }
                                else
                                {
                                    MyDish.Topping = new Guacamole(MyDish, "Guacomole", 10.00);
                                }
                                break;
                            case 3:
                                if (MyDish.Country == Locale.ZA)
                                {
                                    MyDish.Topping = new Rice(MyDish, "Jasmine Rice", 2.99);
                                }
                                else
                                {
                                    MyDish.Topping = new Rice(MyDish, "Basmati Rice", 2.99);
                                }
                                break;
                            case 4:
                                if (MyDish.Country == Locale.ZA)
                                {
                                    MyDish.Topping = new Beans(MyDish, "Refried Beans", 4.50);
                                }
                                else
                                {
                                    MyDish.Topping = new Beans(MyDish, "Black Beans", 4.99);
                                }

                                break;
                            case 5:
                                if (MyDish.Country == Locale.ZA)
                                {
                                    MyDish.Topping = new CreamCheese(MyDish, "Smooth Cream Cheese", 11.99);
                                }
                                else
                                {
                                    MyDish.Topping = new CreamCheese(MyDish, "Chunky Cream Cheese", 11.99);
                                }
                                break;
                            case 6:
                                if (MyDish.Country == Locale.ZA)
                                {
                                    MyDish.Topping = new Tomato(MyDish, "Relish", 5.00);
                                }
                                else
                                {
                                    MyDish.Topping = new Tomato(MyDish, "Salsa", 5.00);
                                }
                                break;
                            case 7:
                                if (MyDish.Country == Locale.ZA)
                                {
                                    MyDish.Topping = new Chilli(MyDish, "Jalapeno Chillies", 7.50);
                                }
                                else
                                {
                                    MyDish.Topping = new Chilli(MyDish, "Habanero Chillies", 7.50);
                                }
                                break;
                        }
                    }
                }

                IObserver TheObserver = new BurrutoWorldObserver(MyDish, dishType);
                MyDish.Register(TheObserver);
                MyDish.NotifyObserver(); //Send the order to the kitchen



            }
            else
            {//Load the south african store
                Console.Clear();
                BurritoFactory = new BurritoWorldZA();
                selectedDish = DisplaySouthAfricanMenu();
                if (selectedDish == 1)
                {
                    dishOption = SelectDishOption(DishType.Burrito);
                }
                else
                {
                    dishOption = SelectDishOption(DishType.Taco);
                }

                if (dishOption == 1 && selectedDish == 1)
                {
                    MyDish = BurritoFactory.CreateDish(DishType.Burrito, DishOption.Chicken);
                }
                else if (dishOption == 2 && selectedDish == 1)
                {
                    MyDish = BurritoFactory.CreateDish(DishType.Burrito, DishOption.Meat);
                }
                else if (dishOption == 3 && selectedDish == 1)
                {
                    MyDish = BurritoFactory.CreateDish(DishType.Burrito, DishOption.Vegitarian);
                }
                else if (dishOption == 1 && selectedDish == 2)
                {
                    MyDish = BurritoFactory.CreateDish(DishType.Taco, DishOption.Chicken);
                }
                else if (dishOption == 2 && selectedDish == 2)
                {
                    MyDish = BurritoFactory.CreateDish(DishType.Taco, DishOption.Meat);
                }
                else if (dishOption == 3 && selectedDish == 2)
                {
                    MyDish = BurritoFactory.CreateDish(DishType.Taco, DishOption.Vegitarian);
                }

                while (selectedTopping != 8)
                {
                    selectedTopping = DisplayToppingsMenu(MyDish, out dishType);
                    if (selectedTopping == 8)
                    {
                        break;
                    }
                    else
                    {
                        switch (selectedTopping)
                        {
                            case 1:
                                if (MyDish.Country == Locale.ZA)
                                {
                                    MyDish.Topping = new Cheese(MyDish, "Cheedar Cheese", 5.00);
                                }
                                else
                                {
                                    MyDish.Topping = new Cheese(MyDish, "Pepper Jack Cheese", 5.00);
                                }

                                break;
                            case 2:
                                if (MyDish.Country == Locale.ZA)
                                {
                                    MyDish.Topping = new Guacamole(MyDish, "Sliced Avocado's", 10.00);
                                }
                                else
                                {
                                    MyDish.Topping = new Guacamole(MyDish, "Guacomole", 10.00);
                                }
                                break;
                            case 3:
                                if (MyDish.Country == Locale.ZA)
                                {
                                    MyDish.Topping = new Rice(MyDish, "Jasmine Rice", 2.99);
                                }
                                else
                                {
                                    MyDish.Topping = new Rice(MyDish, "Basmati Rice", 2.99);
                                }
                                break;
                            case 4:
                                if (MyDish.Country == Locale.ZA)
                                {
                                    MyDish.Topping = new Beans(MyDish, "Refried Beans", 4.50);
                                }
                                else
                                {
                                    MyDish.Topping = new Beans(MyDish, "Black Beans", 4.99);
                                }

                                break;
                            case 5:
                                if (MyDish.Country == Locale.ZA)
                                {
                                    MyDish.Topping = new CreamCheese(MyDish, "Smooth Cream Cheese", 11.99);
                                }
                                else
                                {
                                    MyDish.Topping = new CreamCheese(MyDish, "Chunky Cream Cheese", 11.99);
                                }
                                break;
                            case 6:
                                if (MyDish.Country == Locale.ZA)
                                {
                                    MyDish.Topping = new Tomato(MyDish, "Relish", 5.00);
                                }
                                else
                                {
                                    MyDish.Topping = new Tomato(MyDish, "Salsa", 5.00);
                                }
                                break;
                            case 7:
                                if (MyDish.Country == Locale.ZA)
                                {
                                    MyDish.Topping = new Chilli(MyDish, "Jalapeno Chillies", 7.50);
                                }
                                else
                                {
                                    MyDish.Topping = new Chilli(MyDish, "Habanero Chillies", 7.50);
                                }
                                break;
                        }

                    }
                }

                IObserver TheObserver = new BurrutoWorldObserver(MyDish, dishType);
                MyDish.Register(TheObserver);
                MyDish.NotifyObserver(); //Send the order to the kitchen
            }

        }

        static void DisplayHeader()
        {
            Console.WriteLine("BurritoWorld Kitchen Order System");
            Console.WriteLine("=====================================");
            Console.WriteLine("Please select an option from the menu");
            Console.WriteLine("1. Access the United States Store");
            Console.WriteLine("2. Access the South Africa Store");
            Console.WriteLine();
        }
        static int SelectRegion()
        {
            int result = -1;

            String errorMessage = "";
            do
            {
                try
                {
                    Console.Clear();
                    if (errorMessage != "")
                    {
                        Console.WriteLine($"ERROR: {errorMessage}");
                        errorMessage = "";
                        Console.WriteLine();
                    }
                    DisplayHeader();
                    Console.Write("Your Choice: ");
                    result = Convert.ToInt32(Console.ReadLine());
                    if (result == 1 || result == 2)
                    {
                        break;
                    }

                }
                catch (Exception error)
                {
                    errorMessage = error.Message;
                    continue;
                }
            } while (result != 1 || result != 2);
            return result;
        }

        static int DisplayUnitedStatesMenu()
        {
            int result = -1;
            String errorMessage = "";
            do
            {
                try
                {
                    Console.Clear();
                    if (errorMessage != "")
                    {
                        Console.WriteLine($"ERROR: {errorMessage}");
                        errorMessage = "";
                        Console.WriteLine();
                    }
                    Console.WriteLine("Welcome to BurritoWorld (US)");
                    Console.WriteLine("==============================");
                    Console.WriteLine("Please select the type of dish you want to serve");
                    Console.WriteLine("1. Burrito");
                    Console.WriteLine("2. Taco");
                    Console.WriteLine();
                    Console.Write("Your Choice: ");
                    result = Convert.ToInt32(Console.ReadLine());
                    if (result == 1 || result == 2)
                    {
                        break;
                    }
                }
                catch (Exception error)
                {
                    errorMessage = error.Message;
                    continue;
                }
            } while (result != 1 || result != 2);
            return result;
        }

        static int SelectDishOption(DishType Type)
        {
            int selectedOption = -1;
            String errorMessage = "";
            Console.Clear();
            String type = "";

            do
            {
                Console.Clear();
                if (Type == DishType.Burrito || type == "Burrito")
                {
                    Console.WriteLine("You have selected Burrito Dish. Select the dish make: ");
                    type = "Burrito";
                }
                else
                {
                    Console.WriteLine("You have selected Taco Dish. Select the dish make: ");
                    type = "Taco";
                }
                try
                {

                    if (errorMessage != "")
                    {
                        Console.WriteLine($"ERROR: {errorMessage}");
                        errorMessage = "";
                    }
                    Console.WriteLine();
                    Console.WriteLine("1. Chicken Dish");
                    Console.WriteLine("2. Meat Dish");
                    Console.WriteLine("3. Vegitarian Dish");
                    Console.WriteLine();
                    Console.Write("Your Choice: ");
                    selectedOption = Convert.ToInt32(Console.ReadLine());
                    if (selectedOption == 1 || selectedOption == 2 || selectedOption == 3)
                    {
                        break;
                    }
                }
                catch (Exception error)
                {
                    errorMessage = error.Message;
                    continue;
                }
            } while (selectedOption != 1 || selectedOption != 2 || selectedOption != 3);
            return selectedOption;
        }

        static int DisplaySouthAfricanMenu()
        {
            int result = -1;
            String errorMessage = "";
            do
            {
                try
                {
                    Console.Clear();
                    if (errorMessage != "")
                    {
                        Console.WriteLine($"ERROR: {errorMessage}");
                        errorMessage = "";
                        Console.WriteLine();
                    }
                    Console.WriteLine("Welcome to BurritoWorld (ZA)");
                    Console.WriteLine("==============================");
                    Console.WriteLine("Please select the type of dish you want to serve");
                    Console.WriteLine("1. Burrito");
                    Console.WriteLine("2. Taco");
                    Console.WriteLine();
                    Console.Write("Your Choice: ");
                    result = Convert.ToInt32(Console.ReadLine());
                    if (result == 1 || result == 2)
                    {
                        break;
                    }
                }
                catch (Exception error)
                {
                    errorMessage = error.Message;
                    continue;
                }
            } while (result != 1 || result != 2);
            return result;
        }

        static int DisplayToppingsMenu(Dish Option, out String type)
        {
            Console.Clear();
            int dishOption = (int)Option.Option;
            int selectedChoice = -1;
            String errorMessage = "";
            type = "";
            do
            {
                try
                {
                    Console.Clear();
                    if (Option is Burrito || type == "Burrito")
                    {
                        Console.WriteLine($"You have selected a {Enum.GetName(typeof(DishOption), dishOption)}, of a Burrito Dish");
                        type = "Burrito";
                    }
                    else
                    {
                        Console.WriteLine($"You have selected a {Enum.GetName(typeof(DishOption), dishOption)}, of a Taco Dish");
                        type = "Taco";
                    }
                    if (errorMessage != "")
                    {
                        Console.WriteLine($"ERROR: {errorMessage}");
                        errorMessage = "";
                        Console.WriteLine();
                    }
                    Console.WriteLine("You can add the following toppings to the menu: ");
                    Console.WriteLine("NOTE: Variation depends on your selected store region");
                    Console.WriteLine();
                    Console.WriteLine("1. Cheese");
                    Console.WriteLine("2. Guacamole");
                    Console.WriteLine("3. Rice");
                    Console.WriteLine("4. Beans");
                    Console.WriteLine("5. Cream Cheese");
                    Console.WriteLine("6. Tomato");
                    Console.WriteLine("7. Chilli");
                    Console.WriteLine();
                    Console.WriteLine("8. Finalize Order");
                    Console.WriteLine();
                    Console.Write("Your choice: ");
                    selectedChoice = Convert.ToInt32(Console.ReadLine());
                    if (selectedChoice > 0 || selectedChoice < 9)
                    {
                        break;
                    }

                }
                catch (Exception error)
                {
                    errorMessage = error.Message;
                    continue;
                }
            } while (selectedChoice > 8 || selectedChoice < 0);
            return selectedChoice;

        }
    }


}