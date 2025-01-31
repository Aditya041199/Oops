﻿using OOPS.InventoryManagement;
using System;
namespace OOPS
{
    public class Program
    {
        public static string inventoryFilePath = @"D:\Bridgelabz\OOPS\OOPS\InventoryManagement\Inventory.json";
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Oops JsonFile");
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("\nWhat do you want to do?\n1. InventoryDetails\n" +
                                  "2. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
                        inventoryDetailsManagement.ReadJsonFile(inventoryFilePath);
                        break;
                    default:
                        condition = false;
                        break;
                }
            }
        }
    }
}