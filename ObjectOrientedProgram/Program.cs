﻿using ObjectOrientedProgramming.InventoryManagement;
using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        const string INVENTORY_JSON = @"V:\BridgeLabz\ObjectOrientedProgramming\ObjectOrientedProgram\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            InventoryManager inventoryManager = new InventoryManager();
            inventoryManager.DisplayData(INVENTORY_JSON);
        }
    }
}
