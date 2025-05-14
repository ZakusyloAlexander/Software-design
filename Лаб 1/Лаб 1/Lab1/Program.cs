using System;
using System.Collections.Generic;
using Interfaces;
using Classes;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        {
            IProduct juice = new Product("Сік апельсиновий", "л", new Money(42, 00, "UAH"), "Напої");
            IProduct rice = new Product("Рис", "кг", new Money(29, 50, "UAH"), "Крупи");

            var warehouse = new Warehouse();
            warehouse.Incoming(juice, 80, DateTime.Now);
            warehouse.Incoming(rice, 150, DateTime.Now);

            Reporting.PrintIncomingInvoice(juice, 80, DateTime.Now);
            Reporting.PrintIncomingInvoice(rice, 150, DateTime.Now);

            warehouse.Outgoing("Сік апельсиновий", 20, DateTime.Now);
            warehouse.Outgoing("Рис", 60, DateTime.Now);

            Reporting.PrintOutgoingInvoice(juice, 20, DateTime.Now);
            Reporting.PrintOutgoingInvoice(rice, 60, DateTime.Now);

            var inventory = warehouse.GetInventory();
            Reporting.PrintInventory(inventory);
        }
    }
}
