﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtMgmtSystem
{
    public class ManageSales
    {
        public static Dictionary<int, (string, string, DateTime, int)> salesList = new Dictionary<int, (string, string, DateTime, int)>();

        public static void AddASale()
        {
            Console.WriteLine("Enter sales id");
            int salesId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter customer Name");
            string cusName = Console.ReadLine();
            Console.WriteLine("Enter food item name");
            string itemName = Console.ReadLine();
            DateTime datetime = DateTime.Now;
            Console.WriteLine("Enter number of plates");

            int quantity = Convert.ToInt32(Console.ReadLine());

            //getting item id number by item Name
            int id = ManageFoodItems.foodItemList.FirstOrDefault(x => x.Value.Item1 == itemName).Key;
            int rate = ManageFoodItems.foodItemCostList[id];

            salesList.Add(salesId, (cusName, itemName, datetime, quantity * rate));
        }

        public static void viewSalesDetails(int salesId)
        {
            if (salesList.ContainsKey(salesId))
            {
                Console.WriteLine(salesList[salesId]);
            }
        }
        public static void ShowAllSalesDetails()
        {
            foreach (var item in salesList)
            {
                Console.WriteLine(item.Value);
            }
        }

        public static void EditSales(int salesID)
        {
            salesList.Remove(salesID);
            Console.WriteLine($"{salesID} successfully removed from the sales portal");
        }


    }
}
